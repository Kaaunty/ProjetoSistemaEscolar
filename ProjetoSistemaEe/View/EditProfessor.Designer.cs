namespace ProjetoSistemaEe.View
{
    partial class EditProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfessor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectsGrid = new System.Windows.Forms.DataGridView();
            this.CursoCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nome_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.ListaMaterias = new System.Windows.Forms.ListBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CbMartialStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DtProfessor = new System.Windows.Forms.DateTimePicker();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.TxtDistrict = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.SubjectsGrid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ListaMaterias);
            this.panel1.Controls.Add(this.TxtSalary);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.CbGender);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.CbMartialStatus);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TxtNum);
            this.panel1.Controls.Add(this.TxtStreet);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.DtProfessor);
            this.panel1.Controls.Add(this.TxtPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtZipCode);
            this.panel1.Controls.Add(this.TxtDistrict);
            this.panel1.Controls.Add(this.TxtCity);
            this.panel1.Controls.Add(this.TxtState);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 669);
            this.panel1.TabIndex = 2;
            // 
            // SubjectsGrid
            // 
            this.SubjectsGrid.AllowUserToAddRows = false;
            this.SubjectsGrid.AllowUserToDeleteRows = false;
            this.SubjectsGrid.AllowUserToResizeColumns = false;
            this.SubjectsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.SubjectsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubjectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SubjectsGrid.BackgroundColor = System.Drawing.Color.White;
            this.SubjectsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(37)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CursoCheckbox,
            this.nome_materia,
            this.curso,
            this.idMateria,
            this.idCurso});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubjectsGrid.Location = new System.Drawing.Point(247, 251);
            this.SubjectsGrid.Name = "SubjectsGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SubjectsGrid.RowHeadersVisible = false;
            this.SubjectsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SubjectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubjectsGrid.Size = new System.Drawing.Size(276, 157);
            this.SubjectsGrid.TabIndex = 2;
            // 
            // CursoCheckbox
            // 
            this.CursoCheckbox.HeaderText = "Escolher";
            this.CursoCheckbox.Name = "CursoCheckbox";
            this.CursoCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CursoCheckbox.Width = 54;
            // 
            // nome_materia
            // 
            this.nome_materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome_materia.DataPropertyName = "SubjectName";
            this.nome_materia.HeaderText = "Materia";
            this.nome_materia.Name = "nome_materia";
            this.nome_materia.ReadOnly = true;
            this.nome_materia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome_materia.Width = 67;
            // 
            // curso
            // 
            this.curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.curso.DataPropertyName = "Course";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.curso.Width = 59;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "SubjectId";
            this.idMateria.HeaderText = "IDMateria";
            this.idMateria.Name = "idMateria";
            this.idMateria.Visible = false;
            this.idMateria.Width = 78;
            // 
            // idCurso
            // 
            this.idCurso.DataPropertyName = "idCurso";
            this.idCurso.HeaderText = "CursoID";
            this.idCurso.Name = "idCurso";
            this.idCurso.Visible = false;
            this.idCurso.Width = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 35);
            this.panel2.TabIndex = 82;
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
            // ListaMaterias
            // 
            this.ListaMaterias.FormattingEnabled = true;
            this.ListaMaterias.Location = new System.Drawing.Point(81, 257);
            this.ListaMaterias.Name = "ListaMaterias";
            this.ListaMaterias.Size = new System.Drawing.Size(150, 108);
            this.ListaMaterias.TabIndex = 81;
            this.ListaMaterias.Visible = false;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalary.Location = new System.Drawing.Point(317, 427);
            this.TxtSalary.MaxLength = 20;
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(206, 29);
            this.TxtSalary.TabIndex = 79;
            this.TxtSalary.Text = "Salario";
            this.TxtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            this.TxtSalary.Leave += new System.EventHandler(this.TxtSalary_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(587, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 26);
            this.label15.TabIndex = 78;
            this.label15.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(657, 471);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 29);
            this.txtEmail.TabIndex = 77;
            this.txtEmail.Text = "Email:";
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(239, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 26);
            this.label16.TabIndex = 76;
            this.label16.Text = "Salario";
            // 
            // CbGender
            // 
            this.CbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGender.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.CbGender.Location = new System.Drawing.Point(657, 517);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(206, 30);
            this.CbGender.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(569, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 26);
            this.label13.TabIndex = 74;
            this.label13.Text = "Gênero:";
            // 
            // CbMartialStatus
            // 
            this.CbMartialStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMartialStatus.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbMartialStatus.FormattingEnabled = true;
            this.CbMartialStatus.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Separado",
            "Divorciado",
            "Viúvo"});
            this.CbMartialStatus.Location = new System.Drawing.Point(317, 470);
            this.CbMartialStatus.Name = "CbMartialStatus";
            this.CbMartialStatus.Size = new System.Drawing.Size(206, 30);
            this.CbMartialStatus.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(868, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 26);
            this.label12.TabIndex = 72;
            this.label12.Text = "N°:";
            // 
            // TxtNum
            // 
            this.TxtNum.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum.Location = new System.Drawing.Point(910, 294);
            this.TxtNum.MaxLength = 4;
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(47, 29);
            this.TxtNum.TabIndex = 71;
            this.TxtNum.Text = "0000";
            this.TxtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // TxtStreet
            // 
            this.TxtStreet.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStreet.Location = new System.Drawing.Point(657, 294);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.ReadOnly = true;
            this.TxtStreet.Size = new System.Drawing.Size(206, 29);
            this.TxtStreet.TabIndex = 70;
            this.TxtStreet.Text = "Rua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(581, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 26);
            this.label11.TabIndex = 69;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(599, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 26);
            this.label10.TabIndex = 68;
            this.label10.Text = "Rua:";
            // 
            // DtProfessor
            // 
            this.DtProfessor.CalendarFont = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtProfessor.CalendarForeColor = System.Drawing.Color.Coral;
            this.DtProfessor.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.DtProfessor.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.DtProfessor.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.DtProfessor.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.DtProfessor.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtProfessor.CustomFormat = "dd/MM/yyyy";
            this.DtProfessor.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtProfessor.Location = new System.Drawing.Point(317, 518);
            this.DtProfessor.Name = "DtProfessor";
            this.DtProfessor.Size = new System.Drawing.Size(206, 29);
            this.DtProfessor.TabIndex = 67;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(657, 427);
            this.TxtPhone.Mask = "(00)00000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(206, 29);
            this.TxtPhone.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 65;
            this.label5.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 64;
            this.label3.Text = "Estado Civil:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(597, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 26);
            this.label8.TabIndex = 63;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 62;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 61;
            this.label6.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 59;
            this.label1.Text = "Data de Nascimento:";
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZipCode.Location = new System.Drawing.Point(657, 204);
            this.TxtZipCode.Mask = "00000-000";
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(206, 29);
            this.TxtZipCode.TabIndex = 58;
            this.TxtZipCode.TextChanged += new System.EventHandler(this.TxtZipCode_TextChanged);
            // 
            // TxtDistrict
            // 
            this.TxtDistrict.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDistrict.Location = new System.Drawing.Point(657, 379);
            this.TxtDistrict.Name = "TxtDistrict";
            this.TxtDistrict.ReadOnly = true;
            this.TxtDistrict.Size = new System.Drawing.Size(206, 29);
            this.TxtDistrict.TabIndex = 57;
            this.TxtDistrict.Text = "Bairro";
            // 
            // TxtCity
            // 
            this.TxtCity.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCity.Location = new System.Drawing.Point(657, 332);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.ReadOnly = true;
            this.TxtCity.Size = new System.Drawing.Size(206, 29);
            this.TxtCity.TabIndex = 56;
            this.TxtCity.Text = "Cidade";
            // 
            // TxtState
            // 
            this.TxtState.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtState.Location = new System.Drawing.Point(657, 250);
            this.TxtState.Name = "TxtState";
            this.TxtState.ReadOnly = true;
            this.TxtState.Size = new System.Drawing.Size(206, 29);
            this.TxtState.TabIndex = 55;
            this.TxtState.Text = "Estado";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(317, 204);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(206, 29);
            this.TxtName.TabIndex = 54;
            this.TxtName.Text = "Nome";
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(523, 159);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(47, 29);
            this.txtID.TabIndex = 51;
            this.txtID.TabStop = false;
            this.txtID.Text = "000";
            this.txtID.Visible = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.BackgroundImage = global::ProjetoSistemaEe.RecursosVisuais.botaoroxo;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnEdit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEdit.IconSize = 35;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(386, 574);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(130, 35);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
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
            this.BtnDelete.Location = new System.Drawing.Point(522, 574);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 35);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "     Deletar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // EditProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProfessor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProfessor";
            this.Load += new System.EventHandler(this.EditProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnEdit;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListBox ListaMaterias;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CbGender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CbMartialStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DtProfessor;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtZipCode;
        private System.Windows.Forms.TextBox TxtDistrict;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private System.Windows.Forms.DataGridView SubjectsGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CursoCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
    }
}