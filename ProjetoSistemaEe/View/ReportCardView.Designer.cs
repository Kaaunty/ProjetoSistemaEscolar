namespace ProjetoSistemaEe.View
{
    partial class ReportCardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCardView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CbSubject = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CbCourse = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPreviousMenu = new FontAwesome.Sharp.IconButton();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.ReportCardGrid = new System.Windows.Forms.DataGridView();
            this.ra_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportCardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.TxtSearchName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.CbSubject);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.CbCourse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ReportCardGrid);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 669);
            this.panel1.TabIndex = 1;
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSearchName.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchName.Location = new System.Drawing.Point(115, 247);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Size = new System.Drawing.Size(292, 33);
            this.TxtSearchName.TabIndex = 55;
            this.TxtSearchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchName.TextChanged += new System.EventHandler(this.TxtSearchName_TextChanged);
            this.TxtSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchName_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(37, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "Aluno:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.label14.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(16, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 28);
            this.label14.TabIndex = 53;
            this.label14.Text = "Materia:";
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
            this.CbSubject.Location = new System.Drawing.Point(115, 209);
            this.CbSubject.Name = "CbSubject";
            this.CbSubject.Size = new System.Drawing.Size(292, 30);
            this.CbSubject.TabIndex = 52;
            this.CbSubject.SelectedValueChanged += new System.EventHandler(this.CbSubject_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.label12.Font = new System.Drawing.Font("Manrope", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(33, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 28);
            this.label12.TabIndex = 51;
            this.label12.Text = "Curso:";
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
            this.CbCourse.Location = new System.Drawing.Point(115, 166);
            this.CbCourse.Name = "CbCourse";
            this.CbCourse.Size = new System.Drawing.Size(292, 30);
            this.CbCourse.TabIndex = 50;
            this.CbCourse.SelectedValueChanged += new System.EventHandler(this.CbCourse_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 161);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.BtnPreviousMenu.Location = new System.Drawing.Point(1006, 4);
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
            // ReportCardGrid
            // 
            this.ReportCardGrid.AllowUserToAddRows = false;
            this.ReportCardGrid.AllowUserToDeleteRows = false;
            this.ReportCardGrid.AllowUserToResizeColumns = false;
            this.ReportCardGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.ReportCardGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReportCardGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ReportCardGrid.BackgroundColor = System.Drawing.Color.White;
            this.ReportCardGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportCardGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReportCardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportCardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ra_aluno,
            this.nome_aluno,
            this.curso,
            this.materia,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.media,
            this.situacao});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportCardGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.ReportCardGrid.EnableHeadersVisualStyles = false;
            this.ReportCardGrid.Location = new System.Drawing.Point(11, 318);
            this.ReportCardGrid.MultiSelect = false;
            this.ReportCardGrid.Name = "ReportCardGrid";
            this.ReportCardGrid.ReadOnly = true;
            this.ReportCardGrid.RowHeadersVisible = false;
            this.ReportCardGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReportCardGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportCardGrid.Size = new System.Drawing.Size(1016, 339);
            this.ReportCardGrid.TabIndex = 1;
            this.ReportCardGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ReportCardGrid_CellFormatting);
            this.ReportCardGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ReportCardGrid_CellMouseDoubleClick);
            // 
            // ra_aluno
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.ra_aluno.DefaultCellStyle = dataGridViewCellStyle3;
            this.ra_aluno.HeaderText = "RA";
            this.ra_aluno.MinimumWidth = 80;
            this.ra_aluno.Name = "ra_aluno";
            this.ra_aluno.ReadOnly = true;
            this.ra_aluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ra_aluno.Width = 80;
            // 
            // nome_aluno
            // 
            this.nome_aluno.DataPropertyName = "Student";
            this.nome_aluno.HeaderText = "Aluno";
            this.nome_aluno.Name = "nome_aluno";
            this.nome_aluno.ReadOnly = true;
            this.nome_aluno.Width = 64;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "Course";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 63;
            // 
            // materia
            // 
            this.materia.DataPropertyName = "Subject";
            this.materia.HeaderText = "Materia";
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            this.materia.Width = 72;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "grade1";
            this.Column1.HeaderText = "Nota 1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "grade2";
            this.Column2.HeaderText = "Nota 2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 67;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "grade3";
            this.Column3.HeaderText = "Nota 3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 67;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "grade4";
            this.Column4.HeaderText = "Nota 4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 67;
            // 
            // media
            // 
            this.media.DataPropertyName = "average";
            this.media.HeaderText = "Media";
            this.media.Name = "media";
            this.media.ReadOnly = true;
            this.media.Width = 65;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situation";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 77;
            // 
            // ReportCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportCardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarBoletim";
            this.Load += new System.EventHandler(this.ReportCardView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportCardGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView ReportCardGrid;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnPreviousMenu;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CbCourse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ra_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}