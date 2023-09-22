namespace ProjetoSistemaEe.View
{
    partial class EditGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGrade));
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.TxtN3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.TxtCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtN4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAverage
            // 
            this.TxtAverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAverage.Enabled = false;
            this.TxtAverage.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAverage.Location = new System.Drawing.Point(125, 262);
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
            this.TxtN3.Location = new System.Drawing.Point(124, 134);
            this.TxtN3.MaxLength = 4;
            this.TxtN3.Name = "TxtN3";
            this.TxtN3.Size = new System.Drawing.Size(67, 33);
            this.TxtN3.TabIndex = 3;
            this.TxtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN3.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label5.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(38, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Media :";
            // 
            // TxtN2
            // 
            this.TxtN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN2.Location = new System.Drawing.Point(124, 85);
            this.TxtN2.MaxLength = 4;
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(67, 33);
            this.TxtN2.TabIndex = 2;
            this.TxtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN2.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // TxtCourse
            // 
            this.TxtCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCourse.Enabled = false;
            this.TxtCourse.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCourse.Location = new System.Drawing.Point(166, 139);
            this.TxtCourse.Name = "TxtCourse";
            this.TxtCourse.ReadOnly = true;
            this.TxtCourse.Size = new System.Drawing.Size(413, 29);
            this.TxtCourse.TabIndex = 9;
            this.TxtCourse.TabStop = false;
            this.TxtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label6.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(84, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Curso:";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSubject.Enabled = false;
            this.TxtSubject.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubject.Location = new System.Drawing.Point(166, 186);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.ReadOnly = true;
            this.TxtSubject.Size = new System.Drawing.Size(413, 29);
            this.TxtSubject.TabIndex = 6;
            this.TxtSubject.TabStop = false;
            this.TxtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtName.Enabled = false;
            this.TxtName.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(166, 92);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(413, 29);
            this.TxtName.TabIndex = 5;
            this.TxtName.TabStop = false;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label7.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(116, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "RA:";
            // 
            // txtRA
            // 
            this.txtRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRA.Enabled = false;
            this.txtRA.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(166, 45);
            this.txtRA.Name = "txtRA";
            this.txtRA.ReadOnly = true;
            this.txtRA.Size = new System.Drawing.Size(413, 29);
            this.txtRA.TabIndex = 0;
            this.txtRA.TabStop = false;
            this.txtRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label9.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(86, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1 :";
            // 
            // TxtN1
            // 
            this.TxtN1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN1.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN1.Location = new System.Drawing.Point(124, 36);
            this.TxtN1.MaxLength = 4;
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(67, 33);
            this.TxtN1.TabIndex = 1;
            this.TxtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN1.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(38, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 4 :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3 :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label10.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(67, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Matéria:";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.BackgroundImage = global::ProjetoSistemaEe.RecursosVisuais.botaoroxo;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnEdit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEdit.IconSize = 30;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(386, 591);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(130, 35);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
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
            this.panel2.Location = new System.Drawing.Point(114, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 364);
            this.panel2.TabIndex = 8;
            // 
            // TxtN4
            // 
            this.TxtN4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN4.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN4.Location = new System.Drawing.Point(124, 183);
            this.TxtN4.MaxLength = 4;
            this.TxtN4.Name = "TxtN4";
            this.TxtN4.Size = new System.Drawing.Size(67, 33);
            this.TxtN4.TabIndex = 4;
            this.TxtN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN4.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            this.TxtN4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label4.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(38, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 2 :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.TxtCourse);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TxtSubject);
            this.panel3.Controls.Add(this.TxtName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtRA);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(334, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 364);
            this.panel3.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(5, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 33);
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 669);
            this.panel1.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImage = global::ProjetoSistemaEe.RecursosVisuais.botaoroxo;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnDelete.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDelete.IconSize = 35;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(522, 591);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 35);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "     Deletar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Controls.Add(this.BtnClose);
            this.panel4.Controls.Add(this.BtnMinimize);
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1037, 35);
            this.panel4.TabIndex = 10;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.BtnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 40;
            this.BtnClose.Location = new System.Drawing.Point(1008, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 28);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            // EditGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarNotas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.TextBox TxtN3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.TextBox TxtCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtN4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private System.Windows.Forms.TextBox txtID;
        private FontAwesome.Sharp.IconButton BtnDelete;
    }
}