namespace GenixaPDFtoPNG.Pages
{
    partial class Main
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
            btnOpen = new Button();
            txtPdfPath = new TextBox();
            btnConvert = new Button();
            btnExit = new Button();
            lblHeader = new Label();
            progressBar1 = new ProgressBar();
            lblProgress = new Label();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(363, 70);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "&Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += button1_Click;
            // 
            // txtPdfPath
            // 
            txtPdfPath.Location = new Point(12, 71);
            txtPdfPath.Name = "txtPdfPath";
            txtPdfPath.Size = new Size(327, 23);
            txtPdfPath.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(282, 144);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "&Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(363, 144);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button2_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F);
            lblHeader.ForeColor = SystemColors.ControlDarkDark;
            lblHeader.Location = new Point(12, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(241, 30);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Select a PDF to Convert";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 110);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(327, 23);
            progressBar1.TabIndex = 5;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(363, 118);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 15);
            lblProgress.TabIndex = 6;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 175);
            Controls.Add(lblProgress);
            Controls.Add(progressBar1);
            Controls.Add(lblHeader);
            Controls.Add(btnExit);
            Controls.Add(btnConvert);
            Controls.Add(txtPdfPath);
            Controls.Add(btnOpen);
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private TextBox txtPdfPath;
        private Button btnConvert;
        private Button btnExit;
        private Label lblHeader;
        private ProgressBar progressBar1;
        private Label lblProgress;
    }
}