﻿namespace ProjetoSistemaEe.View
{
    partial class StudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPreviousMenu = new FontAwesome.Sharp.IconButton();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.ra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerorua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StudentGrid);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 669);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.BtnPreviousMenu);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 35);
            this.panel2.TabIndex = 7;
            // 
            // BtnPreviousMenu
            // 
            this.BtnPreviousMenu.FlatAppearance.BorderSize = 0;
            this.BtnPreviousMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreviousMenu.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.BtnPreviousMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPreviousMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPreviousMenu.IconSize = 40;
            this.BtnPreviousMenu.Location = new System.Drawing.Point(1010, 4);
            this.BtnPreviousMenu.Name = "BtnPreviousMenu";
            this.BtnPreviousMenu.Size = new System.Drawing.Size(28, 28);
            this.BtnPreviousMenu.TabIndex = 2;
            this.BtnPreviousMenu.UseVisualStyleBackColor = true;
            this.BtnPreviousMenu.Click += new System.EventHandler(this.BtnPreviousMenu_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BtnMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 40;
            this.BtnMinimize.Location = new System.Drawing.Point(974, 4);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(28, 28);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(235, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clique duas vezes em um estudante na tabela para editar ou deletar:";
            // 
            // StudentGrid
            // 
            this.StudentGrid.AllowUserToAddRows = false;
            this.StudentGrid.AllowUserToDeleteRows = false;
            this.StudentGrid.AllowUserToResizeColumns = false;
            this.StudentGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.StudentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StudentGrid.BackgroundColor = System.Drawing.Color.White;
            this.StudentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ra,
            this.nome,
            this.curso,
            this.periodo,
            this.estadocivil,
            this.genero,
            this.datanascimento,
            this.email,
            this.turno,
            this.Telefone,
            this.cep,
            this.cidade,
            this.uf,
            this.bairro,
            this.rua,
            this.numerorua});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentGrid.EnableHeadersVisualStyles = false;
            this.StudentGrid.Location = new System.Drawing.Point(12, 240);
            this.StudentGrid.MultiSelect = false;
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.ReadOnly = true;
            this.StudentGrid.RowHeadersVisible = false;
            this.StudentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StudentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGrid.Size = new System.Drawing.Size(1016, 420);
            this.StudentGrid.TabIndex = 0;
            this.StudentGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGrid_CellDoubleClick);
            // 
            // ra
            // 
            this.ra.DataPropertyName = "ra";
            this.ra.HeaderText = "RA";
            this.ra.Name = "ra";
            this.ra.ReadOnly = true;
            this.ra.Width = 47;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "name";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 65;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "Course";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 63;
            // 
            // periodo
            // 
            this.periodo.DataPropertyName = "period";
            this.periodo.HeaderText = "Periodo";
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            this.periodo.Width = 73;
            // 
            // estadocivil
            // 
            this.estadocivil.DataPropertyName = "maritalStatus";
            this.estadocivil.HeaderText = "Estado Civil";
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.ReadOnly = true;
            this.estadocivil.Width = 86;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "gender";
            this.genero.HeaderText = "Gênero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 70;
            // 
            // datanascimento
            // 
            this.datanascimento.DataPropertyName = "birthDate";
            this.datanascimento.HeaderText = "Data de Nascimento";
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.ReadOnly = true;
            this.datanascimento.Width = 127;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 61;
            // 
            // turno
            // 
            this.turno.DataPropertyName = "shift";
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 63;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "phone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 76;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "zipCode";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Width = 53;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "city";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 69;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "state";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Width = 46;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "district";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 63;
            // 
            // rua
            // 
            this.rua.DataPropertyName = "street";
            this.rua.HeaderText = "Rua";
            this.rua.Name = "rua";
            this.rua.ReadOnly = true;
            this.rua.Width = 52;
            // 
            // numerorua
            // 
            this.numerorua.DataPropertyName = "streetNumber";
            this.numerorua.HeaderText = "Numero";
            this.numerorua.Name = "numerorua";
            this.numerorua.ReadOnly = true;
            this.numerorua.Width = 76;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarAluno";
            this.Load += new System.EventHandler(this.StudentView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnPreviousMenu;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerorua;
    }
}