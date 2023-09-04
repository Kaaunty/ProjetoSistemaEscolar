namespace ProjetoSistemaEe.View
{
    partial class VisualizarProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarProfessor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridProfessor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtprof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.gridProfessor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 669);
            this.panel1.TabIndex = 1;
            // 
            // gridProfessor
            // 
            this.gridProfessor.AllowUserToAddRows = false;
            this.gridProfessor.AllowUserToDeleteRows = false;
            this.gridProfessor.AllowUserToResizeColumns = false;
            this.gridProfessor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.gridProfessor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProfessor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridProfessor.BackgroundColor = System.Drawing.Color.White;
            this.gridProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProfessor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.materia,
            this.salario,
            this.estadocivil,
            this.genero,
            this.dtprof,
            this.email,
            this.telefone,
            this.cep,
            this.endereco_completo,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProfessor.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridProfessor.EnableHeadersVisualStyles = false;
            this.gridProfessor.Location = new System.Drawing.Point(11, 237);
            this.gridProfessor.MultiSelect = false;
            this.gridProfessor.Name = "gridProfessor";
            this.gridProfessor.ReadOnly = true;
            this.gridProfessor.RowHeadersVisible = false;
            this.gridProfessor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProfessor.Size = new System.Drawing.Size(1016, 420);
            this.gridProfessor.TabIndex = 1;
            this.gridProfessor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfessor_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(217, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Clique duas vezes em um professor na tabela para editar ou deletar:";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 65;
            // 
            // materia
            // 
            this.materia.DataPropertyName = "nome_materia";
            this.materia.HeaderText = "Materia";
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            this.materia.Width = 72;
            // 
            // salario
            // 
            this.salario.DataPropertyName = "salario";
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            this.salario.Width = 67;
            // 
            // estadocivil
            // 
            this.estadocivil.DataPropertyName = "estadocivil";
            this.estadocivil.HeaderText = "Estado Civil";
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.ReadOnly = true;
            this.estadocivil.Width = 93;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 70;
            // 
            // dtprof
            // 
            this.dtprof.DataPropertyName = "datanascimento";
            this.dtprof.HeaderText = "Data De Nascimento";
            this.dtprof.Name = "dtprof";
            this.dtprof.ReadOnly = true;
            this.dtprof.Width = 128;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 61;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 76;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Width = 53;
            // 
            // endereco_completo
            // 
            this.endereco_completo.DataPropertyName = "endereco_completo";
            this.endereco_completo.HeaderText = "Endereço";
            this.endereco_completo.Name = "endereco_completo";
            this.endereco_completo.ReadOnly = true;
            this.endereco_completo.Width = 81;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_materia";
            this.Column1.HeaderText = "id_materia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 87;
            // 
            // VisualizarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizarProfessor";
            this.Text = "VisualizarProfessor";
            this.Load += new System.EventHandler(this.VisualizarProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView gridProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtprof;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}