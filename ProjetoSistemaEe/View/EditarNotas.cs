using ProjetoSistemaEe.Entidades;
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
        private Calcular calcular = new Calcular();
        private VisualizarBoletim instanciaDoForm1; //crio um objeto do tipo FORM 1, que será usado dentro da classe

        public EditarNotas(VisualizarBoletim InstanciaVisualizar)
        {
            InitializeComponent();
            instanciaDoForm1 = InstanciaVisualizar; //passo o valor do form1 para o objeto criado
            txtRA.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[1].Value.ToString();
            txtCurso.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[2].Value.ToString();
            txtMateria.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[3].Value.ToString();
            txtNomeProfessor.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[4].Value.ToString();
            txtN1.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[5].Value.ToString();
            txtN2.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[6].Value.ToString();
            txtN3.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[7].Value.ToString();
            txtN4.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[8].Value.ToString();
            txtMedia.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja editar a nota do aluno?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Boletim boletim = new Boletim();
                    Editar(boletim);
                    MessageBox.Show("Boletim editado com sucesso!");
                    FormAbrir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
        }

        private void Editar(Boletim boletim)
        {
            try
            {
                boletim.Id = Convert.ToInt32(instanciaDoForm1.gridBoletim.CurrentRow.Cells[0].Value.ToString());
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

        private void FormAbrir()
        {
            VisualizarBoletim formB = new VisualizarBoletim();
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(formB);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormAbrir();
        }
    }
}