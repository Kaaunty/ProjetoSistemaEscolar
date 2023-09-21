namespace ProjetoSistemaEe.View
{
    partial class RegisterGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterGrades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPreviousMenu = new FontAwesome.Sharp.IconButton();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CbSubject = new System.Windows.Forms.ComboBox();
            this.CbProfessor = new System.Windows.Forms.ComboBox();
            this.CbCourse = new System.Windows.Forms.ComboBox();
            this.CbStudent = new System.Windows.Forms.ComboBox();
            this.TxtN4 = new System.Windows.Forms.TextBox();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.TxtN3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 669);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(385, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "iguais ao do curso do aluno";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(116, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(807, 28);
            this.label6.TabIndex = 52;
            this.label6.Text = "Para adicionar uma nota, é preciso selecionar um professor que contenha materias " +
    "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.BtnPreviousMenu);
            this.panel3.Controls.Add(this.BtnMinimize);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 35);
            this.panel3.TabIndex = 7;
            // 
            // BtnPreviousMenu
            // 
            this.BtnPreviousMenu.FlatAppearance.BorderSize = 0;
            this.BtnPreviousMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreviousMenu.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.BtnPreviousMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPreviousMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPreviousMenu.IconSize = 40;
            this.BtnPreviousMenu.Location = new System.Drawing.Point(1007, 4);
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
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.CbSubject);
            this.panel2.Controls.Add(this.CbProfessor);
            this.panel2.Controls.Add(this.CbCourse);
            this.panel2.Controls.Add(this.CbStudent);
            this.panel2.Controls.Add(this.TxtN4);
            this.panel2.Controls.Add(this.TxtAverage);
            this.panel2.Controls.Add(this.TxtN3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TxtN2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtN1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(195, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 364);
            this.panel2.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label14.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(25, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 28);
            this.label14.TabIndex = 51;
            this.label14.Text = "Materia:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.BackgroundImage = global::ProjetoSistemaEe.RecursosVisuais.botaoroxo;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnAdd.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdd.IconSize = 30;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(267, 307);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(130, 35);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "     Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label13.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(10, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 28);
            this.label13.TabIndex = 50;
            this.label13.Text = "Professor:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label12.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(46, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 28);
            this.label12.TabIndex = 49;
            this.label12.Text = "Curso:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label11.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(46, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 28);
            this.label11.TabIndex = 48;
            this.label11.Text = "Aluno:";
            // 
            // CbSubject
            // 
            this.CbSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSubject.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSubject.FormattingEnabled = true;
            this.CbSubject.Items.AddRange(new object[] {
            "Matematica",
            "Literatura"});
            this.CbSubject.Location = new System.Drawing.Point(128, 240);
            this.CbSubject.Name = "CbSubject";
            this.CbSubject.Size = new System.Drawing.Size(292, 30);
            this.CbSubject.TabIndex = 47;
            // 
            // CbProfessor
            // 
            this.CbProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProfessor.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProfessor.FormattingEnabled = true;
            this.CbProfessor.Items.AddRange(new object[] {
            "Matematica",
            "Literatura"});
            this.CbProfessor.Location = new System.Drawing.Point(128, 191);
            this.CbProfessor.Name = "CbProfessor";
            this.CbProfessor.Size = new System.Drawing.Size(292, 30);
            this.CbProfessor.TabIndex = 46;
            this.CbProfessor.SelectedIndexChanged += new System.EventHandler(this.cbProfessor_SelectedIndexChanged);
            // 
            // CbCourse
            // 
            this.CbCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCourse.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCourse.FormattingEnabled = true;
            this.CbCourse.Items.AddRange(new object[] {
            "Matematica",
            "Literatura"});
            this.CbCourse.Location = new System.Drawing.Point(128, 95);
            this.CbCourse.Name = "CbCourse";
            this.CbCourse.Size = new System.Drawing.Size(292, 30);
            this.CbCourse.TabIndex = 45;
            this.CbCourse.TextChanged += new System.EventHandler(this.cbCurso_TextChanged);
            // 
            // CbStudent
            // 
            this.CbStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStudent.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbStudent.FormattingEnabled = true;
            this.CbStudent.Items.AddRange(new object[] {
            "Matematica",
            "Literatura"});
            this.CbStudent.Location = new System.Drawing.Point(128, 145);
            this.CbStudent.Name = "CbStudent";
            this.CbStudent.Size = new System.Drawing.Size(292, 30);
            this.CbStudent.TabIndex = 44;
            // 
            // TxtN4
            // 
            this.TxtN4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN4.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN4.Location = new System.Drawing.Point(556, 202);
            this.TxtN4.MaxLength = 4;
            this.TxtN4.Name = "TxtN4";
            this.TxtN4.Size = new System.Drawing.Size(67, 33);
            this.TxtN4.TabIndex = 4;
            this.TxtN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN4.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtAverage
            // 
            this.TxtAverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAverage.Enabled = false;
            this.TxtAverage.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAverage.Location = new System.Drawing.Point(557, 275);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ReadOnly = true;
            this.TxtAverage.Size = new System.Drawing.Size(67, 33);
            this.TxtAverage.TabIndex = 5;
            this.TxtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtN3
            // 
            this.TxtN3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN3.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN3.Location = new System.Drawing.Point(556, 153);
            this.TxtN3.MaxLength = 4;
            this.TxtN3.Name = "TxtN3";
            this.TxtN3.Size = new System.Drawing.Size(67, 33);
            this.TxtN3.TabIndex = 3;
            this.TxtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN3.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label5.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(470, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Media :";
            // 
            // TxtN2
            // 
            this.TxtN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN2.Location = new System.Drawing.Point(557, 107);
            this.TxtN2.MaxLength = 4;
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(67, 33);
            this.TxtN2.TabIndex = 2;
            this.TxtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN2.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(471, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1 :";
            // 
            // TxtN1
            // 
            this.TxtN1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN1.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN1.Location = new System.Drawing.Point(556, 57);
            this.TxtN1.MaxLength = 4;
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(67, 33);
            this.TxtN1.TabIndex = 1;
            this.TxtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN1.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(467, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 4 :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label4.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(467, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 2 :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(467, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3 :";
            // 
            // RegisterGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterGrades";
            this.Load += new System.EventHandler(this.RegisterGrades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtN4;
        private System.Windows.Forms.TextBox TxtN3;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.ComboBox CbSubject;
        private System.Windows.Forms.ComboBox CbProfessor;
        private System.Windows.Forms.ComboBox CbCourse;
        private System.Windows.Forms.ComboBox CbStudent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BtnPreviousMenu;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}