namespace ProjetoSistemaEe.View
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.BtnCadastrarNotas = new System.Windows.Forms.Button();
            this.BtnVisualizaBoletim = new FontAwesome.Sharp.IconButton();
            this.BtnVisualizarProf = new FontAwesome.Sharp.IconButton();
            this.BtnCadastrarProf = new FontAwesome.Sharp.IconButton();
            this.BtnVisualizarAluno = new FontAwesome.Sharp.IconButton();
            this.BtnCadastrarAluno = new FontAwesome.Sharp.IconButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelsuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.panelLateral.SuspendLayout();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.panelLateral.Controls.Add(this.BtnCadastrarNotas);
            this.panelLateral.Controls.Add(this.BtnVisualizaBoletim);
            this.panelLateral.Controls.Add(this.BtnVisualizarProf);
            this.panelLateral.Controls.Add(this.BtnCadastrarProf);
            this.panelLateral.Controls.Add(this.BtnVisualizarAluno);
            this.panelLateral.Controls.Add(this.BtnCadastrarAluno);
            this.panelLateral.Location = new System.Drawing.Point(-1, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(212, 701);
            this.panelLateral.TabIndex = 0;
            // 
            // BtnCadastrarNotas
            // 
            this.BtnCadastrarNotas.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarNotas.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarNotas.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastrarNotas.Image")));
            this.BtnCadastrarNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrarNotas.Location = new System.Drawing.Point(6, 410);
            this.BtnCadastrarNotas.Name = "BtnCadastrarNotas";
            this.BtnCadastrarNotas.Size = new System.Drawing.Size(205, 54);
            this.BtnCadastrarNotas.TabIndex = 11;
            this.BtnCadastrarNotas.Text = "Adicionar Notas";
            this.BtnCadastrarNotas.UseVisualStyleBackColor = true;
            this.BtnCadastrarNotas.Click += new System.EventHandler(this.BtnCadastrarNotas_Click);
            // 
            // BtnVisualizaBoletim
            // 
            this.BtnVisualizaBoletim.FlatAppearance.BorderSize = 0;
            this.BtnVisualizaBoletim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizaBoletim.ForeColor = System.Drawing.Color.White;
            this.BtnVisualizaBoletim.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnVisualizaBoletim.IconColor = System.Drawing.Color.White;
            this.BtnVisualizaBoletim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVisualizaBoletim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisualizaBoletim.Location = new System.Drawing.Point(6, 499);
            this.BtnVisualizaBoletim.Name = "BtnVisualizaBoletim";
            this.BtnVisualizaBoletim.Size = new System.Drawing.Size(205, 54);
            this.BtnVisualizaBoletim.TabIndex = 10;
            this.BtnVisualizaBoletim.Text = "Visualizar Boletim";
            this.BtnVisualizaBoletim.UseVisualStyleBackColor = true;
            this.BtnVisualizaBoletim.Click += new System.EventHandler(this.BtnVisualizaBoletim_Click);
            // 
            // BtnVisualizarProf
            // 
            this.BtnVisualizarProf.FlatAppearance.BorderSize = 0;
            this.BtnVisualizarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizarProf.ForeColor = System.Drawing.Color.White;
            this.BtnVisualizarProf.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnVisualizarProf.IconColor = System.Drawing.Color.White;
            this.BtnVisualizarProf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVisualizarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisualizarProf.Location = new System.Drawing.Point(6, 321);
            this.BtnVisualizarProf.Name = "BtnVisualizarProf";
            this.BtnVisualizarProf.Size = new System.Drawing.Size(205, 54);
            this.BtnVisualizarProf.TabIndex = 8;
            this.BtnVisualizarProf.Text = "Visualizar Professor";
            this.BtnVisualizarProf.UseVisualStyleBackColor = true;
            this.BtnVisualizarProf.Click += new System.EventHandler(this.BtnVisualizarProf_Click);
            // 
            // BtnCadastrarProf
            // 
            this.BtnCadastrarProf.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarProf.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarProf.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.BtnCadastrarProf.IconColor = System.Drawing.Color.White;
            this.BtnCadastrarProf.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCadastrarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrarProf.Location = new System.Drawing.Point(6, 232);
            this.BtnCadastrarProf.Name = "BtnCadastrarProf";
            this.BtnCadastrarProf.Size = new System.Drawing.Size(205, 54);
            this.BtnCadastrarProf.TabIndex = 7;
            this.BtnCadastrarProf.Text = "Cadastrar Professor";
            this.BtnCadastrarProf.UseVisualStyleBackColor = true;
            this.BtnCadastrarProf.Click += new System.EventHandler(this.BtnCadastrarProf_Click);
            // 
            // BtnVisualizarAluno
            // 
            this.BtnVisualizarAluno.FlatAppearance.BorderSize = 0;
            this.BtnVisualizarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizarAluno.ForeColor = System.Drawing.Color.White;
            this.BtnVisualizarAluno.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnVisualizarAluno.IconColor = System.Drawing.Color.White;
            this.BtnVisualizarAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVisualizarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisualizarAluno.Location = new System.Drawing.Point(6, 143);
            this.BtnVisualizarAluno.Name = "BtnVisualizarAluno";
            this.BtnVisualizarAluno.Size = new System.Drawing.Size(205, 54);
            this.BtnVisualizarAluno.TabIndex = 4;
            this.BtnVisualizarAluno.Text = "Visualizar Alunos";
            this.BtnVisualizarAluno.UseVisualStyleBackColor = true;
            this.BtnVisualizarAluno.Click += new System.EventHandler(this.BtnVisualizarAluno_Click);
            // 
            // BtnCadastrarAluno
            // 
            this.BtnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarAluno.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.BtnCadastrarAluno.IconColor = System.Drawing.Color.White;
            this.BtnCadastrarAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrarAluno.Location = new System.Drawing.Point(7, 54);
            this.BtnCadastrarAluno.Name = "BtnCadastrarAluno";
            this.BtnCadastrarAluno.Size = new System.Drawing.Size(202, 54);
            this.BtnCadastrarAluno.TabIndex = 3;
            this.BtnCadastrarAluno.Text = "Cadastrar Aluno";
            this.BtnCadastrarAluno.UseVisualStyleBackColor = true;
            this.BtnCadastrarAluno.Click += new System.EventHandler(this.BtnCadastrarAluno_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPrincipal.BackgroundImage")));
            this.panelPrincipal.Location = new System.Drawing.Point(211, 32);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1039, 669);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackColor = System.Drawing.Color.White;
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelsuperior.Controls.Add(this.btnMinimizar);
            this.panelsuperior.Controls.Add(this.btnFechar);
            this.panelsuperior.Location = new System.Drawing.Point(211, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(1039, 33);
            this.panelsuperior.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 40;
            this.btnMinimizar.Location = new System.Drawing.Point(975, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnFechar.IconColor = System.Drawing.Color.Black;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 40;
            this.btnFechar.Location = new System.Drawing.Point(1009, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 28);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelsuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.panelLateral.ResumeLayout(false);
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelPrincipal;
        private FontAwesome.Sharp.IconButton BtnCadastrarAluno;
        private FontAwesome.Sharp.IconButton BtnCadastrarProf;
        private FontAwesome.Sharp.IconButton BtnVisualizarAluno;
        private FontAwesome.Sharp.IconButton BtnVisualizarProf;
        private FontAwesome.Sharp.IconButton BtnVisualizaBoletim;
        private System.Windows.Forms.Button BtnCadastrarNotas;
        private System.Windows.Forms.Panel panelsuperior;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnFechar;
    }
}