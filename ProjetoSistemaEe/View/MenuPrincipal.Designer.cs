﻿namespace ProjetoSistemaEe.View
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelLaterar = new System.Windows.Forms.Panel();
            this.btnCadastrarNotas = new System.Windows.Forms.Button();
            this.btnVisualizarNotas = new FontAwesome.Sharp.IconButton();
            this.btnVisualizarProf = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarProf = new FontAwesome.Sharp.IconButton();
            this.btnVisualizarAluno = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarAluno = new FontAwesome.Sharp.IconButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLaterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLaterar
            // 
            this.panelLaterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.panelLaterar.Controls.Add(this.btnCadastrarNotas);
            this.panelLaterar.Controls.Add(this.btnVisualizarNotas);
            this.panelLaterar.Controls.Add(this.btnVisualizarProf);
            this.panelLaterar.Controls.Add(this.btnCadastrarProf);
            this.panelLaterar.Controls.Add(this.btnVisualizarAluno);
            this.panelLaterar.Controls.Add(this.btnCadastrarAluno);
            this.panelLaterar.Location = new System.Drawing.Point(-1, 0);
            this.panelLaterar.Name = "panelLaterar";
            this.panelLaterar.Size = new System.Drawing.Size(212, 701);
            this.panelLaterar.TabIndex = 0;
            // 
            // btnCadastrarNotas
            // 
            this.btnCadastrarNotas.FlatAppearance.BorderSize = 0;
            this.btnCadastrarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNotas.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarNotas.Image")));
            this.btnCadastrarNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarNotas.Location = new System.Drawing.Point(6, 410);
            this.btnCadastrarNotas.Name = "btnCadastrarNotas";
            this.btnCadastrarNotas.Size = new System.Drawing.Size(205, 54);
            this.btnCadastrarNotas.TabIndex = 11;
            this.btnCadastrarNotas.Text = "Adicionar Notas";
            this.btnCadastrarNotas.UseVisualStyleBackColor = true;
            this.btnCadastrarNotas.Click += new System.EventHandler(this.btnCadastrarNotas_Click);
            // 
            // btnVisualizarNotas
            // 
            this.btnVisualizarNotas.FlatAppearance.BorderSize = 0;
            this.btnVisualizarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarNotas.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarNotas.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnVisualizarNotas.IconColor = System.Drawing.Color.White;
            this.btnVisualizarNotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVisualizarNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarNotas.Location = new System.Drawing.Point(6, 499);
            this.btnVisualizarNotas.Name = "btnVisualizarNotas";
            this.btnVisualizarNotas.Size = new System.Drawing.Size(205, 54);
            this.btnVisualizarNotas.TabIndex = 10;
            this.btnVisualizarNotas.Text = "Adicionar Notas";
            this.btnVisualizarNotas.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarProf
            // 
            this.btnVisualizarProf.FlatAppearance.BorderSize = 0;
            this.btnVisualizarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarProf.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarProf.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnVisualizarProf.IconColor = System.Drawing.Color.White;
            this.btnVisualizarProf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVisualizarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarProf.Location = new System.Drawing.Point(6, 321);
            this.btnVisualizarProf.Name = "btnVisualizarProf";
            this.btnVisualizarProf.Size = new System.Drawing.Size(205, 54);
            this.btnVisualizarProf.TabIndex = 8;
            this.btnVisualizarProf.Text = "Visualizar Professor";
            this.btnVisualizarProf.UseVisualStyleBackColor = true;
            this.btnVisualizarProf.Click += new System.EventHandler(this.btnVisualizarProf_Click);
            // 
            // btnCadastrarProf
            // 
            this.btnCadastrarProf.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProf.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProf.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.btnCadastrarProf.IconColor = System.Drawing.Color.White;
            this.btnCadastrarProf.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCadastrarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProf.Location = new System.Drawing.Point(6, 232);
            this.btnCadastrarProf.Name = "btnCadastrarProf";
            this.btnCadastrarProf.Size = new System.Drawing.Size(205, 54);
            this.btnCadastrarProf.TabIndex = 7;
            this.btnCadastrarProf.Text = "Cadastrar Professor";
            this.btnCadastrarProf.UseVisualStyleBackColor = true;
            this.btnCadastrarProf.Click += new System.EventHandler(this.btnCadastrarProf_Click);
            // 
            // btnVisualizarAluno
            // 
            this.btnVisualizarAluno.FlatAppearance.BorderSize = 0;
            this.btnVisualizarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarAluno.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarAluno.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnVisualizarAluno.IconColor = System.Drawing.Color.White;
            this.btnVisualizarAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVisualizarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarAluno.Location = new System.Drawing.Point(6, 143);
            this.btnVisualizarAluno.Name = "btnVisualizarAluno";
            this.btnVisualizarAluno.Size = new System.Drawing.Size(205, 54);
            this.btnVisualizarAluno.TabIndex = 4;
            this.btnVisualizarAluno.Text = "Visualizar Alunos";
            this.btnVisualizarAluno.UseVisualStyleBackColor = true;
            this.btnVisualizarAluno.Click += new System.EventHandler(this.btnVisualizarAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAluno.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnCadastrarAluno.IconColor = System.Drawing.Color.White;
            this.btnCadastrarAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(7, 54);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(202, 54);
            this.btnCadastrarAluno.TabIndex = 3;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = global::ProjetoSistemaEe.RecursosVisuais.Background_Menu;
            this.panelPrincipal.Location = new System.Drawing.Point(210, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1040, 700);
            this.panelPrincipal.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelLaterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.panelLaterar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLaterar;
        private System.Windows.Forms.Panel panelPrincipal;
        private FontAwesome.Sharp.IconButton btnCadastrarAluno;
        private FontAwesome.Sharp.IconButton btnCadastrarProf;
        private FontAwesome.Sharp.IconButton btnVisualizarAluno;
        private FontAwesome.Sharp.IconButton btnVisualizarProf;
        private FontAwesome.Sharp.IconButton btnVisualizarNotas;
        private System.Windows.Forms.Button btnCadastrarNotas;
    }
}