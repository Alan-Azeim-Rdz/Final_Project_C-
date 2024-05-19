namespace Final_Project_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnPDF = new Button();
            LstBxData = new ListBox();
            TxtName = new TextBox();
            lblName = new Label();
            LblBrithdayDate = new Label();
            TxtLastNamePaternal = new TextBox();
            LblLastNamePaternal = new Label();
            BtnDataSave = new Button();
            DataTimeBrithdayDate = new DateTimePicker();
            TxtCurp = new TextBox();
            LblCurp = new Label();
            BtnGenerateCurp = new Button();
            BtnWriteCurp = new Button();
            LblLastNameMother = new Label();
            TxtLastNameMother = new TextBox();
            SuspendLayout();
            // 
            // BtnPDF
            // 
            BtnPDF.BackColor = Color.Red;
            BtnPDF.Font = new Font("Sitka Subheading Semibold", 10F);
            BtnPDF.Location = new Point(857, 604);
            BtnPDF.Name = "BtnPDF";
            BtnPDF.Size = new Size(126, 51);
            BtnPDF.TabIndex = 1;
            BtnPDF.Text = "Export of PDF";
            BtnPDF.UseVisualStyleBackColor = false;
            // 
            // LstBxData
            // 
            LstBxData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LstBxData.FormattingEnabled = true;
            LstBxData.ItemHeight = 17;
            LstBxData.Location = new Point(659, 14);
            LstBxData.Name = "LstBxData";
            LstBxData.Size = new Size(324, 531);
            LstBxData.TabIndex = 2;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI", 12F);
            TxtName.Location = new Point(116, 58);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(221, 29);
            TxtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(25, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 19);
            lblName.TabIndex = 4;
            lblName.Text = "Name(s)";
            // 
            // LblBrithdayDate
            // 
            LblBrithdayDate.AutoSize = true;
            LblBrithdayDate.Font = new Font("Segoe UI", 10F);
            LblBrithdayDate.Location = new Point(25, 210);
            LblBrithdayDate.Name = "LblBrithdayDate";
            LblBrithdayDate.Size = new Size(85, 19);
            LblBrithdayDate.TabIndex = 6;
            LblBrithdayDate.Text = "Britday Date";
            // 
            // TxtLastNamePaternal
            // 
            TxtLastNamePaternal.Font = new Font("Segoe UI", 12F);
            TxtLastNamePaternal.Location = new Point(147, 109);
            TxtLastNamePaternal.Name = "TxtLastNamePaternal";
            TxtLastNamePaternal.Size = new Size(221, 29);
            TxtLastNamePaternal.TabIndex = 5;
            // 
            // LblLastNamePaternal
            // 
            LblLastNamePaternal.AutoSize = true;
            LblLastNamePaternal.Font = new Font("Segoe UI", 10F);
            LblLastNamePaternal.Location = new Point(25, 115);
            LblLastNamePaternal.Name = "LblLastNamePaternal";
            LblLastNamePaternal.Size = new Size(116, 19);
            LblLastNamePaternal.TabIndex = 6;
            LblLastNamePaternal.Text = "paternal surname";
            // 
            // BtnDataSave
            // 
            BtnDataSave.BackColor = Color.Cyan;
            BtnDataSave.Font = new Font("Sitka Subheading Semibold", 10F);
            BtnDataSave.Location = new Point(432, 217);
            BtnDataSave.Name = "BtnDataSave";
            BtnDataSave.Size = new Size(126, 51);
            BtnDataSave.TabIndex = 7;
            BtnDataSave.Text = "Save to Data";
            BtnDataSave.UseVisualStyleBackColor = false;
            BtnDataSave.Click += BtnDataSave_Click;
            // 
            // DataTimeBrithdayDate
            // 
            DataTimeBrithdayDate.Font = new Font("Segoe UI", 12F);
            DataTimeBrithdayDate.Format = DateTimePickerFormat.Short;
            DataTimeBrithdayDate.Location = new Point(116, 204);
            DataTimeBrithdayDate.Name = "DataTimeBrithdayDate";
            DataTimeBrithdayDate.Size = new Size(126, 29);
            DataTimeBrithdayDate.TabIndex = 8;
            // 
            // TxtCurp
            // 
            TxtCurp.CharacterCasing = CharacterCasing.Lower;
            TxtCurp.Font = new Font("Segoe UI", 12F);
            TxtCurp.Location = new Point(112, 306);
            TxtCurp.Name = "TxtCurp";
            TxtCurp.Size = new Size(221, 29);
            TxtCurp.TabIndex = 9;
            // 
            // LblCurp
            // 
            LblCurp.AutoSize = true;
            LblCurp.Font = new Font("Segoe UI", 10F);
            LblCurp.Location = new Point(21, 312);
            LblCurp.Name = "LblCurp";
            LblCurp.Size = new Size(44, 19);
            LblCurp.TabIndex = 10;
            LblCurp.Text = "CURP";
            // 
            // BtnGenerateCurp
            // 
            BtnGenerateCurp.BackColor = SystemColors.ControlLightLight;
            BtnGenerateCurp.ForeColor = Color.Red;
            BtnGenerateCurp.Location = new Point(467, 312);
            BtnGenerateCurp.Name = "BtnGenerateCurp";
            BtnGenerateCurp.Size = new Size(108, 26);
            BtnGenerateCurp.TabIndex = 11;
            BtnGenerateCurp.Text = "Generate Curp";
            BtnGenerateCurp.UseVisualStyleBackColor = false;
            BtnGenerateCurp.Click += BtnGenerateCurp_Click;
            // 
            // BtnWriteCurp
            // 
            BtnWriteCurp.BackColor = Color.White;
            BtnWriteCurp.ForeColor = Color.FromArgb(128, 128, 255);
            BtnWriteCurp.Location = new Point(346, 312);
            BtnWriteCurp.Name = "BtnWriteCurp";
            BtnWriteCurp.Size = new Size(115, 26);
            BtnWriteCurp.TabIndex = 12;
            BtnWriteCurp.Text = "write the CURP";
            BtnWriteCurp.UseVisualStyleBackColor = false;
            BtnWriteCurp.Click += button2_Click;
            // 
            // LblLastNameMother
            // 
            LblLastNameMother.AutoSize = true;
            LblLastNameMother.Font = new Font("Segoe UI", 10F);
            LblLastNameMother.Location = new Point(25, 166);
            LblLastNameMother.Name = "LblLastNameMother";
            LblLastNameMother.Size = new Size(120, 19);
            LblLastNameMother.TabIndex = 14;
            LblLastNameMother.Text = "mother's surname";
            // 
            // TxtLastNameMother
            // 
            TxtLastNameMother.Font = new Font("Segoe UI", 12F);
            TxtLastNameMother.Location = new Point(147, 160);
            TxtLastNameMother.Name = "TxtLastNameMother";
            TxtLastNameMother.Size = new Size(221, 29);
            TxtLastNameMother.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 669);
            Controls.Add(LblLastNameMother);
            Controls.Add(TxtLastNameMother);
            Controls.Add(BtnWriteCurp);
            Controls.Add(BtnGenerateCurp);
            Controls.Add(LblCurp);
            Controls.Add(TxtCurp);
            Controls.Add(DataTimeBrithdayDate);
            Controls.Add(BtnDataSave);
            Controls.Add(LblLastNamePaternal);
            Controls.Add(LblBrithdayDate);
            Controls.Add(TxtLastNamePaternal);
            Controls.Add(lblName);
            Controls.Add(TxtName);
            Controls.Add(LstBxData);
            Controls.Add(BtnPDF);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnPDF;
        private ListBox LstBxData;
        private TextBox TxtName;
        private Label lblName;
        private Label LblBrithdayDate;
        private TextBox TxtLastNamePaternal;
        private Label LblLastNamePaternal;
        private Button BtnDataSave;
        private DateTimePicker DataTimeBrithdayDate;
        private TextBox TxtCurp;
        private Label LblCurp;
        private Button BtnGenerateCurp;
        private Button BtnWriteCurp;
        private Label LblLastNameMother;
        private TextBox TxtLastNameMother;
    }
}
