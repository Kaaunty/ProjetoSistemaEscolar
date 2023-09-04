﻿using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditarProfessor : Form
    {
        private MateriaModel materiaM = new MateriaModel();
        private ProfessorModel professormodel = new ProfessorModel();
        private Validar validar = new Validar();
        private VisualizarProfessor instanciaDoForm2; //crio um objeto do tipo FORM 1, que será usado dentro da classe
        private char[] delimitarchars = { '-', ',' };

        public EditarProfessor(VisualizarProfessor InstanciaVisualizar)
        {
            InitializeComponent();
            CarregarComboBox();
            instanciaDoForm2 = InstanciaVisualizar; //passo o valor do form1 para o objeto criado
            txtID.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[1].Value.ToString();
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (instanciaDoForm2.gridProfessor.CurrentRow.Cells[1].Value.ToString().Contains(row.Cells[1].Value.ToString()))
                {
                    row.Cells[0].Value = true;
                }
            }
            txtSalario.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[3].Value.ToString();
            cbEstadoCivil.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[4].Value.ToString();
            cbGenero.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[5].Value.ToString();
            dtProfessor.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[8].Value.ToString();
            txtCEP.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[9].Value.ToString();
            string endereco = instanciaDoForm2.gridProfessor.CurrentRow.Cells[11].Value.ToString();
            string[] enderecoSeparado = endereco.Split(delimitarchars);
            txtCidade.Text = enderecoSeparado[0];
            txtEstado.Text = enderecoSeparado[1];
            txtBairro.Text = enderecoSeparado[2];
            txtRua.Text = enderecoSeparado[3];
            txtNum.Text = enderecoSeparado[4];
        }

        private void CarregarComboBox()
        {
            gridMaterias.DataSource = materiaM.ListarMateria();
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            Validar.FormatarData(dtProfessor, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o professor?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Professor professores = new Professor();
                        Editar(professores);
                        MessageBox.Show("Professor editado com sucesso!");
                        FormAbrir();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar professor: " + ex.Message);
                }
            }
        }

        private void Editar(Professor professor)
        {
            try
            {
                professor.Id = Convert.ToInt32(txtID.Text);
                professor.Nome = txtNome.Text;
                professor.ListaDemateria = null;
                professor.EstadoCivil = cbEstadoCivil.Text;
                professor.Genero = cbGenero.Text;
                professor.Salario = txtSalario.Text;
                professor.Datanascimento = Convert.ToDateTime(dtProfessor.Text);
                professor.Email = txtEmail.Text;
                professor.Telefone = txtTelefone.Text;
                professor.Cep = txtCEP.Text;
                professor.Cidade = txtCidade.Text;
                professor.Uf = txtEstado.Text;
                professor.Bairro = txtBairro.Text;
                professor.Rua = txtRua.Text;
                professor.Numerorua = txtNum.Text;
                professormodel.Editar(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o professor?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Professor professores = new Professor();
                Excluir(professores);
                MessageBox.Show("Professor excluido com sucesso!");
                FormAbrir();
            }
        }

        private void Excluir(Professor professor)
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

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            double salario;
            if (Double.TryParse(txtSalario.Text, out salario))
            {
                txtSalario.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", salario);

                if (salario < 2000)
                {
                    MessageBox.Show("Salário Inválido (Menor que R$ 2.000)");
                    txtSalario.Text = "";
                    txtSalario.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite um valor numérico válido.");
                txtSalario.Text = "";
                txtSalario.Focus();
            }
        }

        private void FormAbrir()
        {
            VisualizarProfessor formB = new VisualizarProfessor();
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(formB);
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
            if (!string.IsNullOrEmpty(txtCEP.Text) && txtCEP.MaskCompleted)
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());
                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("CEP não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCEP.Clear();
                        txtCEP.Focus();
                    }
                }
            }
            txtNum.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormAbrir();
        }

        private void AddOnList()
        {
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    if (!ListaMaterias.Items.Contains(row.Cells[2].Value))
                    {
                        ListaMaterias.Items.Add(row.Cells[2].Value);
                    }
                }
            }
        }

        private void RemoveOnList()
        {
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    if (ListaMaterias.Items.Contains(row.Cells[2].Value))
                    {
                        ListaMaterias.Items.Remove(row.Cells[2].Value);
                    }
                }
            }
        }

        private void gridMaterias_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            AddOnList();
            RemoveOnList();
        }

        private void gridMaterias_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            AddOnList();
            RemoveOnList();
        }

        private void gridMaterias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AddOnList();
            RemoveOnList();
        }
    }
}