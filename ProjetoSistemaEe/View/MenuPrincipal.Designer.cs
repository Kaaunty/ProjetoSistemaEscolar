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
            this.btnCadastrarNotas = new System.Windows.Forms.Button();
            this.btnVisualizaBoletim = new FontAwesome.Sharp.IconButton();
            this.btnVisualizarProf = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarProf = new FontAwesome.Sharp.IconButton();
            this.btnVisualizarAluno = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarAluno = new FontAwesome.Sharp.IconButton();
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
            this.panelLateral.Controls.Add(this.btnCadastrarNotas);
            this.panelLateral.Controls.Add(this.btnVisualizaBoletim);
            this.panelLateral.Controls.Add(this.btnVisualizarProf);
            this.panelLateral.Controls.Add(this.btnCadastrarProf);
            this.panelLateral.Controls.Add(this.btnVisualizarAluno);
            this.panelLateral.Controls.Add(this.btnCadastrarAluno);
            this.panelLateral.Location = new System.Drawing.Point(-1, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(212, 701);
            this.panelLateral.TabIndex = 0;
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
            // btnVisualizaBoletim
            // 
            this.btnVisualizaBoletim.FlatAppearance.BorderSize = 0;
            this.btnVisualizaBoletim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizaBoletim.ForeColor = System.Drawing.Color.White;
            this.btnVisualizaBoletim.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnVisualizaBoletim.IconColor = System.Drawing.Color.White;
            this.btnVisualizaBoletim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVisualizaBoletim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizaBoletim.Location = new System.Drawing.Point(6, 499);
            this.btnVisualizaBoletim.Name = "btnVisualizaBoletim";
            this.btnVisualizaBoletim.Size = new System.Drawing.Size(205, 54);
            this.btnVisualizaBoletim.TabIndex = 10;
            this.btnVisualizaBoletim.Text = "Visualizar Boletim";
            this.btnVisualizaBoletim.UseVisualStyleBackColor = true;
            this.btnVisualizaBoletim.Click += new System.EventHandler(this.btnVisualizaBoletim_Click);
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
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
        private FontAwesome.Sharp.IconButton btnCadastrarAluno;
        private FontAwesome.Sharp.IconButton btnCadastrarProf;
        private FontAwesome.Sharp.IconButton btnVisualizarAluno;
        private FontAwesome.Sharp.IconButton btnVisualizarProf;
        private FontAwesome.Sharp.IconButton btnVisualizaBoletim;
        private System.Windows.Forms.Button btnCadastrarNotas;
        private System.Windows.Forms.Panel panelsuperior;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnFechar;
    }
}