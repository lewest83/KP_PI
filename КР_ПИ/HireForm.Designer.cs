namespace КР_ПИ
{
    partial class HireForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HireForm));
            lblFirst = new Label();
            txtFirst = new TextBox();
            lblLast = new Label();
            txtLast = new TextBox();
            lblDept = new Label();
            cmbDept = new ComboBox();
            lblHire = new Label();
            dateHire = new DateTimePicker();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.ForeColor = SystemColors.ButtonFace;
            lblFirst.Location = new Point(125, 62);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(38, 22);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "Имя";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(125, 88);
            txtFirst.Margin = new Padding(3, 4, 3, 4);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(164, 27);
            txtFirst.TabIndex = 1;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.ForeColor = SystemColors.ButtonFace;
            lblLast.Location = new Point(125, 144);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(71, 22);
            lblLast.TabIndex = 2;
            lblLast.Text = "Фамилия";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(125, 170);
            txtLast.Margin = new Padding(3, 4, 3, 4);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(164, 27);
            txtLast.TabIndex = 3;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.ForeColor = SystemColors.ButtonFace;
            lblDept.Location = new Point(125, 232);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(50, 22);
            lblDept.TabIndex = 4;
            lblDept.Text = "Отдел";
            lblDept.Click += label1_Click;
            // 
            // cmbDept
            // 
            cmbDept.FormattingEnabled = true;
            cmbDept.Location = new Point(125, 258);
            cmbDept.Margin = new Padding(3, 4, 3, 4);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(164, 30);
            cmbDept.TabIndex = 5;
            // 
            // lblHire
            // 
            lblHire.AutoSize = true;
            lblHire.ForeColor = SystemColors.ButtonFace;
            lblHire.Location = new Point(463, 61);
            lblHire.Name = "lblHire";
            lblHire.Size = new Size(94, 22);
            lblHire.TabIndex = 6;
            lblHire.Text = "Дата приёма";
            // 
            // dateHire
            // 
            dateHire.Location = new Point(393, 87);
            dateHire.Margin = new Padding(3, 4, 3, 4);
            dateHire.Name = "dateHire";
            dateHire.Size = new Size(164, 27);
            dateHire.TabIndex = 7;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOk.Location = new Point(481, 353);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(165, 70);
            btnOk.TabIndex = 8;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // HireForm
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(682, 453);
            Controls.Add(btnOk);
            Controls.Add(dateHire);
            Controls.Add(lblHire);
            Controls.Add(cmbDept);
            Controls.Add(lblDept);
            Controls.Add(txtLast);
            Controls.Add(lblLast);
            Controls.Add(txtFirst);
            Controls.Add(lblFirst);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "HireForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Приём сотрудника";
            Load += HireForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirst;
        private TextBox txtFirst;
        private Label lblLast;
        private TextBox txtLast;
        private Label lblDept;
        private ComboBox cmbDept;
        private Label lblHire;
        private DateTimePicker dateHire;
        private Button btnOk;
    }
}