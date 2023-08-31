namespace ProjetoSistemaEe.View
{
    partial class CadastroProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProfessor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtProfessor = new System.Windows.Forms.DateTimePicker();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.cbMateria);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.cbCurso);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cbGenero);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbEstadoCivil);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.txtRua);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtProfessor);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCEP);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 669);
            this.panel1.TabIndex = 1;
            // 
            // cbMateria
            // 
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Items.AddRange(new object[] {
            "Matematica",
            "Literatura"});
            this.cbMateria.Location = new System.Drawing.Point(301, 349);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(206, 30);
            this.cbMateria.TabIndex = 48;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(301, 297);
            this.txtSalario.MaxLength = 20;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(206, 29);
            this.txtSalario.TabIndex = 47;
            this.txtSalario.Text = "Salario";
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            this.txtSalario.Leave += new System.EventHandler(this.txtSalario_Leave);
            // 
            // cbCurso
            // 
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Items.AddRange(new object[] {
            "Matematica",
            "Literatura"});
            this.cbCurso.Location = new System.Drawing.Point(301, 252);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(206, 30);
            this.cbCurso.TabIndex = 43;
            this.cbCurso.TextChanged += new System.EventHandler(this.cbCurso_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::ProjetoSistemaEe.RecursosVisuais.botaoroxo;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSalvar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 35;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(454, 612);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 35);
            this.btnSalvar.TabIndex = 41;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(571, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 26);
            this.label15.TabIndex = 40;
            this.label15.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(641, 488);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 29);
            this.txtEmail.TabIndex = 39;
            this.txtEmail.Text = "Email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(223, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 26);
            this.label16.TabIndex = 35;
            this.label16.Text = "Salario";
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbGenero.Location = new System.Drawing.Point(301, 438);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(206, 30);
            this.cbGenero.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(213, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 26);
            this.label13.TabIndex = 30;
            this.label13.Text = "Gênero:";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Separado",
            "Divorciado",
            "Viúvo"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(301, 398);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(206, 30);
            this.cbEstadoCivil.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(852, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 26);
            this.label12.TabIndex = 28;
            this.label12.Text = "N°:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(894, 296);
            this.txtNum.MaxLength = 4;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(47, 29);
            this.txtNum.TabIndex = 27;
            this.txtNum.Text = "0000";
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(641, 296);
            this.txtRua.Name = "txtRua";
            this.txtRua.ReadOnly = true;
            this.txtRua.Size = new System.Drawing.Size(206, 29);
            this.txtRua.TabIndex = 26;
            this.txtRua.Text = "Rua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(565, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(583, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rua:";
            // 
            // dtProfessor
            // 
            this.dtProfessor.CalendarFont = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProfessor.CalendarForeColor = System.Drawing.Color.Coral;
            this.dtProfessor.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dtProfessor.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.dtProfessor.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtProfessor.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dtProfessor.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtProfessor.CustomFormat = "dd/MM/yyyy";
            this.dtProfessor.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProfessor.Location = new System.Drawing.Point(301, 486);
            this.dtProfessor.Name = "dtProfessor";
            this.dtProfessor.Size = new System.Drawing.Size(206, 29);
            this.dtProfessor.TabIndex = 23;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(641, 439);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(206, 29);
            this.txtTelefone.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado Civil:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Materia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(581, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(555, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(555, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data de Nascimento:";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(641, 206);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(206, 29);
            this.txtCEP.TabIndex = 10;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(641, 395);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(206, 29);
            this.txtBairro.TabIndex = 8;
            this.txtBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(641, 348);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(206, 29);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(641, 252);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(206, 29);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.Text = "Estado";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(301, 206);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 29);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroProfessor";
            this.Text = "CadastroProfessor";
            this.Load += new System.EventHandler(this.CadastroProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCurso;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtProfessor;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cbMateria;
    }
}