﻿using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class CadastrarNotas : Form
    {
        private BoletimModel model = new BoletimModel();
        private Validar validar = new Validar();

        public CadastrarNotas()
        {
            InitializeComponent();
        }

        private void CadastrarNotas_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarGrid();
        }

        private void HabilitarCampos()
        {
            txtN1.Enabled = true;
            txtN2.Enabled = true;
            txtN3.Enabled = true;
            txtN4.Enabled = true;
        }

        private void LimparCampos()
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtMedia.Clear();
            txtNome.Clear();
            txtMateria.Clear();
            txtCurso.Clear();
            txtRA.Clear();
            txtNomeProfessor.Clear();
        }

        private void DesabilitarCampos()
        {
            txtN1.Enabled = false;
            txtN2.Enabled = false;
            txtN3.Enabled = false;
            txtN4.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja adicionar a nota ao aluno?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Boletim boletim = new Boletim();
                    Adicionar(boletim);
                    MessageBox.Show("Boletim cadastrado com sucesso!");
                    LimparCampos();
                    DesabilitarCampos();
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
        }

        private void Adicionar(Boletim boletim)
        {
            try
            {
                boletim.IdDisciplina = gridAlunoProfessor.CurrentRow.Cells[2].Value.ToString();
                boletim.IdAluno = Convert.ToInt32(gridAlunoProfessor.CurrentRow.Cells[0].Value.ToString());
                boletim.Idprofessor = Convert.ToInt32(gridAlunoProfessor.CurrentRow.Cells[3].Value.ToString());
                boletim.Nota1 = Convert.ToDouble(txtN1.Text);
                boletim.Nota2 = Convert.ToDouble(txtN2.Text);
                boletim.Nota3 = Convert.ToDouble(txtN3.Text);
                boletim.Nota4 = Convert.ToDouble(txtN4.Text);
                boletim.Media = Convert.ToDouble(txtMedia.Text);
                if (boletim.Media >= 7)
                {
                    boletim.Situacao = "Aprovado";
                }
                else
                {
                    boletim.Situacao = "Reprovado";
                }
                model.CadastrarBoletim(boletim);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Calcular()
        {
            {
                {
                    try
                    {
                        double nota1, nota2, nota3, nota4, media;

                        if (!double.TryParse(txtN1.Text, out nota1) || nota1 < 0 || nota1 > 10)
                        {
                            txtN1.Focus();
                            txtN1.Clear();
                            return;
                        }
                        if (!double.TryParse(txtN2.Text, out nota2) || nota2 < 0 || nota2 > 10)
                        {
                            txtN2.Focus();
                            txtN2.Clear();
                            return;
                        }
                        if (!double.TryParse(txtN3.Text, out nota3) || nota3 < 0 || nota3 > 10)
                        {
                            txtN3.Focus();
                            txtN3.Clear();
                            return;
                        }
                        if (!double.TryParse(txtN4.Text, out nota4) || nota4 < 0 || nota4 > 10)
                        {
                            txtN4.Focus();
                            txtN4.Clear();
                            return;
                        }

                        media = (nota1 + nota2 + nota3 + nota4) / 4;
                        txtMedia.Text = media.ToString("N2");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nota Invalida, digite um valor de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtN_TextChanged(object sender, EventArgs e)
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
                Calcular();
                btnAdicionar.Enabled = true;
            }
            else
            {
                txtMedia.Clear();
                btnAdicionar.Enabled = false;
            }
        }

        #region Grid

        private void CarregarGrid()
        {
            gridAlunoProfessor.DataSource = model.ListarAlunoPorMateria();
            gridAlunoProfessor.Columns[0].HeaderText = "RA Aluno";
            gridAlunoProfessor.Columns[1].HeaderText = "Nome do Aluno";
            gridAlunoProfessor.Columns[2].HeaderText = "Curso do Aluno";
            gridAlunoProfessor.Columns[4].HeaderText = "Nome do Professor";
            gridAlunoProfessor.Columns[6].HeaderText = "Materia";
            gridAlunoProfessor.Columns[3].Visible = false;
            gridAlunoProfessor.Columns[5].Visible = false;
        }

        private void gridAlunoProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRA.Text = gridAlunoProfessor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridAlunoProfessor.CurrentRow.Cells[1].Value.ToString();
            txtCurso.Text = gridAlunoProfessor.CurrentRow.Cells[2].Value.ToString();
            txtNomeProfessor.Text = gridAlunoProfessor.CurrentRow.Cells[4].Value.ToString();
            txtMateria.Text = gridAlunoProfessor.CurrentRow.Cells[6].Value.ToString();
            HabilitarCampos();
            txtN1.Focus();
        }

        #endregion Grid

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }
    }
}