namespace КР_ПИ
{
    partial class HRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRForm));
            lstEmployees = new ListBox();
            btnHire = new Button();
            btnFire = new Button();
            btnReport = new Button();
            SuspendLayout();
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 22;
            lstEmployees.Location = new Point(50, 57);
            lstEmployees.Margin = new Padding(3, 4, 3, 4);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(575, 290);
            lstEmployees.TabIndex = 0;
            // 
            // btnHire
            // 
            btnHire.Location = new Point(124, 355);
            btnHire.Margin = new Padding(3, 4, 3, 4);
            btnHire.Name = "btnHire";
            btnHire.Size = new Size(127, 45);
            btnHire.TabIndex = 1;
            btnHire.Text = "Принять";
            btnHire.UseVisualStyleBackColor = true;
            btnHire.Click += btnHire_Click;
            // 
            // btnFire
            // 
            btnFire.Location = new Point(272, 355);
            btnFire.Margin = new Padding(3, 4, 3, 4);
            btnFire.Name = "btnFire";
            btnFire.Size = new Size(127, 45);
            btnFire.TabIndex = 2;
            btnFire.Text = "Уволить";
            btnFire.UseVisualStyleBackColor = true;
            btnFire.Click += btnFire_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(418, 355);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(127, 45);
            btnReport.TabIndex = 3;
            btnReport.Text = "Отчёт";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // HRForm
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(682, 453);
            Controls.Add(btnReport);
            Controls.Add(btnFire);
            Controls.Add(btnHire);
            Controls.Add(lstEmployees);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "HRForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кадровик";
            Load += HRForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstEmployees;
        private Button btnHire;
        private Button btnFire;
        private Button btnReport;
    }
}