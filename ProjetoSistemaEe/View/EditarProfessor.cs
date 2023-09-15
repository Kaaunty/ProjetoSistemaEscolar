﻿using MySqlX.XDevAPI.Relational;
using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditarProfessor : Form
    {
        private ProfessorModel professormodel = new ProfessorModel();
        private MateriaModel materiamodel = new MateriaModel();
        private Validar validar = new Validar();
        private Professor professor;

        public EditarProfessor(Professor professor)
        {
            this.professor = professor;
            InitializeComponent();
            gridMaterias.AutoGenerateColumns = false;
            gridMaterias.DataSource = materiamodel.ListarMateria();
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            Validar.FormatarData(dtProfessor, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            PopularCampos();
            SelecionarMaterias();
        }

        private void PopularCampos()
        {
            txtID.Text = professor.Id.ToString();
            txtNome.Text = professor.Nome;
            cbEstadoCivil.Text = professor.Estadocivil;
            txtSalario.Text = professor.Salario;
            cbGenero.Text = professor.Genero;
            dtProfessor.Text = professor.Datanascimento.ToString();
            txtEmail.Text = professor.Email;
            txtTelefone.Text = professor.Telefone;
            txtCEP.Text = professor.Cep;
            txtCidade.Text = professor.Cidade;
            txtEstado.Text = professor.Uf;
            txtBairro.Text = professor.Bairro;
            txtRua.Text = professor.Rua;
            txtNum.Text = professor.Numerorua;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this) && ValidarGridSelecionado())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o professor?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Editar();
                        MessageBox.Show("Professor editado com sucesso!");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar professor: " + ex.Message);
                }
            }
        }

        private void Editar()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string nome = txtNome.Text;
                string estadocivil = cbEstadoCivil.Text;
                string genero = cbGenero.Text;
                DateTime datanascimento = dtProfessor.Value;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string cep = txtCEP.Text;
                string cidade = txtCidade.Text;
                string uf = txtEstado.Text;
                string bairro = txtBairro.Text;
                string rua = txtRua.Text;
                string numerorua = txtNum.Text;
                string salario = txtSalario.Text;
                List<Materia> materias = ReceberMateriasSelecionadas();

                Professor professor = new Professor(id, nome, materias, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua);

                professormodel.Editar(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Materia> ReceberMateriasSelecionadas()
        {
            List<Materia> materias = new List<Materia>();
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int materiaid = Convert.ToInt32(row.Cells[3].Value);
                    string nome = row.Cells[1].Value.ToString();
                    Materia materia = new Materia(materiaid, nome);
                    materias.Add(materia);
                }
            }
            return materias;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o professor?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Excluir();
                MessageBox.Show("Professor excluido com sucesso!");
                Close();
            }
        }

        private void Excluir()
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    professor.Id = Convert.ToInt32(txtID.Text);
                    professormodel.Excluir(professor);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void SelecionarMaterias()
        {
            foreach (Materia item in professor.Materia)
            {
                foreach (DataGridViewRow row in gridMaterias.Rows)
                {
                    if (item.Nome == row.Cells[1].Value.ToString())
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }
        }

        #region Validações

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            validar.ValidarSalario(txtSalario);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaLetra(e);
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            validar.VerificaCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.BloqueiaEspaco(e);
        }

        public bool ValidarGridSelecionado()
        {
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    return true;
                }
            }
            MessageBox.Show("Selecione pelo menos uma matéria!");
            return false;
        }

        #endregion Validações

        #region Botões Menu

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Botões Menu
    }
}