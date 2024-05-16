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
            label1 = new Label();
            BtnPDF = new Button();
            LstBxData = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Registro de datos";
            // 
            // BtnPDF
            // 
            BtnPDF.Location = new Point(884, 541);
            BtnPDF.Name = "BtnPDF";
            BtnPDF.Size = new Size(99, 37);
            BtnPDF.TabIndex = 1;
            BtnPDF.Text = "Export of PDF";
            BtnPDF.UseVisualStyleBackColor = true;
            // 
            // LstBxData
            // 
            LstBxData.FormattingEnabled = true;
            LstBxData.ItemHeight = 15;
            LstBxData.Location = new Point(659, 12);
            LstBxData.Name = "LstBxData";
            LstBxData.Size = new Size(324, 469);
            LstBxData.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 590);
            Controls.Add(LstBxData);
            Controls.Add(BtnPDF);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnPDF;
        private ListBox LstBxData;
    }
}
