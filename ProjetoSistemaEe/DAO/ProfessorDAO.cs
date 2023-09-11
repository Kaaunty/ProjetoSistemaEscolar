﻿using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace ProjetoSistemaEe.DAO
{
    internal class ProfessorDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public List<Professor> ListarProfessor()
        {
            List<Professor> professores = new List<Professor>();
            List<Materia> materia = new List<Materia>();
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT p.id, p.nome,m.nome as nome_materia, p.salario, p.estadocivil, p.genero, p.datanascimento,
                                    p.email, p.telefone, p.cep,pm.id_materia,p.cidade,p.uf,p.bairro,p.rua,p.numerorua
                                   FROM professor p
                                    LEFT JOIN professor_materia pm on p.id = pm.id_professor
                                    INNER JOIN materia m on pm.id_materia = m.id
                                    ", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string nome = dr["nome"].ToString();
                    materia.Add(new Materia(Convert.ToInt32(dr["id_materia"]), dr["nome_materia"].ToString()));
                    string salario = dr["salario"].ToString();
                    string estadocivil = dr["estadocivil"].ToString();
                    string genero = dr["genero"].ToString();
                    DateTime datanascimento = Convert.ToDateTime(dr["datanascimento"]);
                    string email = dr["email"].ToString();
                    string telefone = dr["telefone"].ToString();
                    string cep = dr["cep"].ToString();
                    string cidade = dr["cidade"].ToString();
                    string uf = dr["uf"].ToString();
                    string bairro = dr["bairro"].ToString();
                    string rua = dr["rua"].ToString();
                    string numerorua = dr["numerorua"].ToString();

                    Professor professor = new Professor(id, nome, materia, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua);
                    professores.Add(professor);
                }
                return professores;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public void CadastrarProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"INSERT INTO professor(nome, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua)
                   VALUES(@nome, @salario, @estadocivil, @genero, @datanascimento, @email, @telefone, @cep, @cidade, @uf, @bairro, @rua, @numerorua); ", con.con);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@salario", professor.Salario);
                sql.Parameters.AddWithValue("@estadocivil", professor.EstadoCivil);
                sql.Parameters.AddWithValue("@genero", professor.Genero);
                sql.Parameters.AddWithValue("@datanascimento", professor.Datanascimento.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", professor.Email);
                sql.Parameters.AddWithValue("@telefone", professor.Telefone);
                sql.Parameters.AddWithValue("@cep", professor.Cep);
                sql.Parameters.AddWithValue("@cidade", professor.Cidade);
                sql.Parameters.AddWithValue("@uf", professor.Uf);
                sql.Parameters.AddWithValue("@bairro", professor.Bairro);
                sql.Parameters.AddWithValue("@rua", professor.Rua);
                sql.Parameters.AddWithValue("@numerorua", professor.Numerorua);
                sql.ExecuteNonQuery();
                sql.Dispose();
                con.FecharConexao();
                foreach (var item in professor.Materia)
                {
                    con.AbrirConexao();
                    int id_professor = IdUltimoProfessor();
                    sql = new MySqlCommand(@"INSERT INTO professor_materia(id_professor, id_materia) VALUES(@id_professor, @id_materia); ", con.con);
                    sql.Parameters.AddWithValue("@id_professor", id_professor);
                    sql.Parameters.AddWithValue("@id_materia", item.Cursoid);
                    sql.ExecuteNonQuery();
                    sql.Dispose();
                    con.FecharConexao();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        internal void EditarProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE professor SET id = @id, nome = @nome, salario = @salario" +
                    ", estadocivil = @estadocivil, genero = @genero, datanascimento = @datanascimento" +
                    ", email = @email, telefone = @telefone, cep = @cep, cidade = @cidade, uf = @uf" +
                    ", bairro = @bairro, rua = @rua, numerorua = @numerorua where id = @id ;", con.con);
                sql.Parameters.AddWithValue("@id", professor.Id);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@salario", professor.Salario);
                sql.Parameters.AddWithValue("@estadocivil", professor.EstadoCivil);
                sql.Parameters.AddWithValue("@genero", professor.Genero);
                sql.Parameters.AddWithValue("@datanascimento", professor.Datanascimento.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", professor.Email);
                sql.Parameters.AddWithValue("@telefone", professor.Telefone);
                sql.Parameters.AddWithValue("@cep", professor.Cep);
                sql.Parameters.AddWithValue("@cidade", professor.Cidade);
                sql.Parameters.AddWithValue("@uf", professor.Uf);
                sql.Parameters.AddWithValue("@bairro", professor.Bairro);
                sql.Parameters.AddWithValue("@rua", professor.Rua);
                sql.Parameters.AddWithValue("@numerorua", professor.Numerorua);
                sql.ExecuteNonQuery();
                sql.Dispose();
                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public void ExcluirProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"
                DELETE FROM boletim WHERE id_professor = @id;
                DELETE FROM professor WHERE id = @id;
               ", con.con);
                sql.Parameters.AddWithValue("@id", professor.Id);
                sql.ExecuteNonQuery();
                sql.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public int IdUltimoProfessor()
        {
            sql = new MySqlCommand("SELECT MAX(id) as id FROM professor", con.con);
            var result = sql.ExecuteScalar();
            return Convert.ToInt32(result);
        }
    }
}