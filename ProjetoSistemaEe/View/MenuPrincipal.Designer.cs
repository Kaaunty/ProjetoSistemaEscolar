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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtntranscriptAdd = new System.Windows.Forms.Button();
            this.BtntranscriptView = new FontAwesome.Sharp.IconButton();
            this.BtnTeacherView = new FontAwesome.Sharp.IconButton();
            this.BtnTeacherRegister = new FontAwesome.Sharp.IconButton();
            this.BtnStudentRegister = new FontAwesome.Sharp.IconButton();
            this.BtnStudentView = new FontAwesome.Sharp.IconButton();
            this.panelsuperior = new System.Windows.Forms.Panel();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoSistemaEe.RecursosVisuais.BackgroundMenuPrincipal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.BtntranscriptAdd);
            this.panel1.Controls.Add(this.BtntranscriptView);
            this.panel1.Controls.Add(this.BtnTeacherView);
            this.panel1.Controls.Add(this.BtnTeacherRegister);
            this.panel1.Controls.Add(this.BtnStudentRegister);
            this.panel1.Controls.Add(this.BtnStudentView);
            this.panel1.Controls.Add(this.panelsuperior);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 700);
            this.panel1.TabIndex = 0;
            // 
            // BtntranscriptAdd
            // 
            this.BtntranscriptAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtntranscriptAdd.FlatAppearance.BorderSize = 0;
            this.BtntranscriptAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtntranscriptAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtntranscriptAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtntranscriptAdd.Image")));
            this.BtntranscriptAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtntranscriptAdd.Location = new System.Drawing.Point(721, 275);
            this.BtntranscriptAdd.Name = "BtntranscriptAdd";
            this.BtntranscriptAdd.Size = new System.Drawing.Size(150, 150);
            this.BtntranscriptAdd.TabIndex = 13;
            this.BtntranscriptAdd.Text = "Adicionar Notas";
            this.BtntranscriptAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtntranscriptAdd.UseVisualStyleBackColor = false;
            this.BtntranscriptAdd.Click += new System.EventHandler(this.BtntranscriptAdd_Click);
            // 
            // BtntranscriptView
            // 
            this.BtntranscriptView.BackColor = System.Drawing.Color.Transparent;
            this.BtntranscriptView.FlatAppearance.BorderSize = 0;
            this.BtntranscriptView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtntranscriptView.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtntranscriptView.ForeColor = System.Drawing.Color.Black;
            this.BtntranscriptView.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtntranscriptView.IconColor = System.Drawing.Color.Black;
            this.BtntranscriptView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtntranscriptView.IconSize = 180;
            this.BtntranscriptView.Location = new System.Drawing.Point(721, 431);
            this.BtntranscriptView.Name = "BtntranscriptView";
            this.BtntranscriptView.Size = new System.Drawing.Size(150, 150);
            this.BtntranscriptView.TabIndex = 12;
            this.BtntranscriptView.TabStop = false;
            this.BtntranscriptView.Text = "Visualizar Boletim";
            this.BtntranscriptView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtntranscriptView.UseVisualStyleBackColor = false;
            this.BtntranscriptView.Click += new System.EventHandler(this.BtntranscriptView_Click);
            // 
            // BtnTeacherView
            // 
            this.BtnTeacherView.BackColor = System.Drawing.Color.Transparent;
            this.BtnTeacherView.FlatAppearance.BorderSize = 0;
            this.BtnTeacherView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacherView.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeacherView.ForeColor = System.Drawing.Color.Black;
            this.BtnTeacherView.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnTeacherView.IconColor = System.Drawing.Color.Black;
            this.BtnTeacherView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTeacherView.IconSize = 180;
            this.BtnTeacherView.Location = new System.Drawing.Point(550, 430);
            this.BtnTeacherView.Name = "BtnTeacherView";
            this.BtnTeacherView.Size = new System.Drawing.Size(150, 150);
            this.BtnTeacherView.TabIndex = 11;
            this.BtnTeacherView.TabStop = false;
            this.BtnTeacherView.Text = "Visualizar Professor";
            this.BtnTeacherView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTeacherView.UseVisualStyleBackColor = false;
            this.BtnTeacherView.Click += new System.EventHandler(this.BtnTeacherView_Click);
            // 
            // BtnTeacherRegister
            // 
            this.BtnTeacherRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnTeacherRegister.FlatAppearance.BorderSize = 0;
            this.BtnTeacherRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacherRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeacherRegister.ForeColor = System.Drawing.Color.Black;
            this.BtnTeacherRegister.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.BtnTeacherRegister.IconColor = System.Drawing.Color.Black;
            this.BtnTeacherRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTeacherRegister.IconSize = 180;
            this.BtnTeacherRegister.Location = new System.Drawing.Point(550, 275);
            this.BtnTeacherRegister.Name = "BtnTeacherRegister";
            this.BtnTeacherRegister.Size = new System.Drawing.Size(150, 150);
            this.BtnTeacherRegister.TabIndex = 9;
            this.BtnTeacherRegister.TabStop = false;
            this.BtnTeacherRegister.Text = "Cadastrar Professor";
            this.BtnTeacherRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTeacherRegister.UseVisualStyleBackColor = false;
            this.BtnTeacherRegister.Click += new System.EventHandler(this.BtnTeacherRegister_Click);
            // 
            // BtnStudentRegister
            // 
            this.BtnStudentRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnStudentRegister.FlatAppearance.BorderSize = 0;
            this.BtnStudentRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentRegister.ForeColor = System.Drawing.Color.Black;
            this.BtnStudentRegister.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.BtnStudentRegister.IconColor = System.Drawing.Color.Black;
            this.BtnStudentRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStudentRegister.IconSize = 180;
            this.BtnStudentRegister.Location = new System.Drawing.Point(379, 275);
            this.BtnStudentRegister.Name = "BtnStudentRegister";
            this.BtnStudentRegister.Size = new System.Drawing.Size(150, 150);
            this.BtnStudentRegister.TabIndex = 6;
            this.BtnStudentRegister.TabStop = false;
            this.BtnStudentRegister.Text = "Cadastrar Aluno";
            this.BtnStudentRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStudentRegister.UseVisualStyleBackColor = false;
            this.BtnStudentRegister.Click += new System.EventHandler(this.BtnStudentRegister_Click);
            // 
            // BtnStudentView
            // 
            this.BtnStudentView.BackColor = System.Drawing.Color.Transparent;
            this.BtnStudentView.FlatAppearance.BorderSize = 0;
            this.BtnStudentView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentView.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentView.ForeColor = System.Drawing.Color.Black;
            this.BtnStudentView.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnStudentView.IconColor = System.Drawing.Color.Black;
            this.BtnStudentView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStudentView.IconSize = 180;
            this.BtnStudentView.Location = new System.Drawing.Point(379, 431);
            this.BtnStudentView.Name = "BtnStudentView";
            this.BtnStudentView.Size = new System.Drawing.Size(150, 150);
            this.BtnStudentView.TabIndex = 5;
            this.BtnStudentView.TabStop = false;
            this.BtnStudentView.Text = "Visualizar Aluno";
            this.BtnStudentView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStudentView.UseVisualStyleBackColor = false;
            this.BtnStudentView.Click += new System.EventHandler(this.BtnStudentView_Click);
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelsuperior.Controls.Add(this.BtnMinimize);
            this.panelsuperior.Controls.Add(this.BtnClose);
            this.panelsuperior.Location = new System.Drawing.Point(-1, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(1250, 35);
            this.panelsuperior.TabIndex = 4;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BtnMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 40;
            this.BtnMinimize.Location = new System.Drawing.Point(1185, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(28, 28);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.BtnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 40;
            this.BtnClose.Location = new System.Drawing.Point(1219, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 28);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.panel1.ResumeLayout(false);
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelsuperior;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnStudentView;
        private FontAwesome.Sharp.IconButton BtnTeacherRegister;
        private FontAwesome.Sharp.IconButton BtnStudentRegister;
        private FontAwesome.Sharp.IconButton BtnTeacherView;
        private FontAwesome.Sharp.IconButton BtntranscriptView;
        private System.Windows.Forms.Button BtntranscriptAdd;
    }
}