﻿using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditarNotas : Form
    {
        private Validar validar = new Validar();
        private BoletimModel model = new BoletimModel();
        private Calculos calcular = new Calculos();
        private Boletim boletim;

        public EditarNotas(Boletim boletim)
        {
            this.boletim = boletim;
            InitializeComponent();
            PopularCampos();
        }

        private void PopularCampos()
        {
            txtRA.Text = boletim.Ra.ToString();
            txtNome.Text = boletim.Nome_aluno;
            txtID.Text = boletim.Id.ToString();
            txtN1.Text = boletim.Nota1.ToString();
            txtN2.Text = boletim.Nota2.ToString();
            txtN3.Text = boletim.Nota3.ToString();
            txtN4.Text = boletim.Nota4.ToString();
            txtMedia.Text = boletim.Media.ToString();
            txtNomeProfessor.Text = boletim.Nome_professor;
            txtMateria.Text = boletim.Nome_materia;
            txtCurso.Text = boletim.Nome_curso;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja editar a nota do aluno?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Editar();
                    MessageBox.Show("Boletim editado com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
        }

        private void Editar()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                double nota1 = Convert.ToDouble(txtN1.Text);
                double nota2 = Convert.ToDouble(txtN2.Text);
                double nota3 = Convert.ToDouble(txtN3.Text);
                double nota4 = Convert.ToDouble(txtN4.Text);
                double media = Convert.ToDouble(txtMedia.Text);
                string situacao = calcular.VerificarSituacao(media);
                Boletim boletim = new Boletim(id, nota1, nota2, nota3, nota4, media, situacao);
                model.EditarBoletim(boletim);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TxtN_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text))
            {
                double nota = Convert.ToDouble(txt.Text);
                if (nota < 0 || nota > 10)
                {
                    MessageBox.Show("Nota Invalida, digite um valor de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Clear();
                    txt.Focus();
                    return;
                }
            }

            if (txtN1.Text != "" && txtN2.Text != "" && txtN3.Text != "" && txtN4.Text != "")
            {
                calcular.CalcularMedia(txtN1, txtN2, txtN3, txtN4, txtMedia);
                btnEditar.Enabled = true;
            }
            else
            {
                txtMedia.Clear();
                btnEditar.Enabled = false;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}