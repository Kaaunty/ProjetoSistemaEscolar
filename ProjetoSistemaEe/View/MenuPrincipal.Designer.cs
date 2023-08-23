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
            this.panelLaterar = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCadastrarProf = new System.Windows.Forms.Button();
            this.btnCadastrarNotas = new System.Windows.Forms.Button();
            this.panelLaterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLaterar
            // 
            this.panelLaterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.panelLaterar.Controls.Add(this.btnCadastrarNotas);
            this.panelLaterar.Controls.Add(this.btnCadastrarProf);
            this.panelLaterar.Controls.Add(this.btnCadastrar);
            this.panelLaterar.Location = new System.Drawing.Point(-1, 0);
            this.panelLaterar.Name = "panelLaterar";
            this.panelLaterar.Size = new System.Drawing.Size(212, 701);
            this.panelLaterar.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(210, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1040, 700);
            this.panelPrincipal.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 60);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(205, 54);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Alunos";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCadastrarProf
            // 
            this.btnCadastrarProf.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadastrarProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProf.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProf.Location = new System.Drawing.Point(4, 323);
            this.btnCadastrarProf.Name = "btnCadastrarProf";
            this.btnCadastrarProf.Size = new System.Drawing.Size(205, 54);
            this.btnCadastrarProf.TabIndex = 1;
            this.btnCadastrarProf.Text = "Cadastrar Professor";
            this.btnCadastrarProf.UseVisualStyleBackColor = true;
            this.btnCadastrarProf.Click += new System.EventHandler(this.btnCadastrarProf_Click);
            // 
            // btnCadastrarNotas
            // 
            this.btnCadastrarNotas.FlatAppearance.BorderSize = 0;
            this.btnCadastrarNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadastrarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNotas.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarNotas.Location = new System.Drawing.Point(4, 432);
            this.btnCadastrarNotas.Name = "btnCadastrarNotas";
            this.btnCadastrarNotas.Size = new System.Drawing.Size(205, 54);
            this.btnCadastrarNotas.TabIndex = 2;
            this.btnCadastrarNotas.Text = "Adicionar Notas";
            this.btnCadastrarNotas.UseVisualStyleBackColor = true;
            this.btnCadastrarNotas.Click += new System.EventHandler(this.btnCadastrarNotas_Click);
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
            this.Text = "MenuPrincipal";
            this.panelLaterar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLaterar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCadastrarProf;
        private System.Windows.Forms.Button btnCadastrarNotas;
    }
}