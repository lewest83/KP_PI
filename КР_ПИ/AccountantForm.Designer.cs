namespace КР_ПИ
{
    partial class AccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            lstPayroll = new ListBox();
            label1 = new Label();
            btnLOad = new Button();
            SuspendLayout();
            // 
            // lstPayroll
            // 
            lstPayroll.FormattingEnabled = true;
            lstPayroll.ItemHeight = 22;
            lstPayroll.Location = new Point(52, 62);
            lstPayroll.Margin = new Padding(3, 4, 3, 4);
            lstPayroll.Name = "lstPayroll";
            lstPayroll.Size = new Size(571, 246);
            lstPayroll.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(52, 36);
            label1.Name = "label1";
            label1.Size = new Size(141, 22);
            label1.TabIndex = 1;
            label1.Text = "Список сотрудников";
            // 
            // btnLOad
            // 
            btnLOad.BackColor = Color.Gray;
            btnLOad.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLOad.Location = new Point(52, 337);
            btnLOad.Margin = new Padding(3, 4, 3, 4);
            btnLOad.Name = "btnLOad";
            btnLOad.Size = new Size(187, 54);
            btnLOad.TabIndex = 2;
            btnLOad.Text = "Загрузить данные";
            btnLOad.UseVisualStyleBackColor = false;
            btnLOad.Click += btnLOad_Click;
            // 
            // AccountantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(682, 453);
            Controls.Add(btnLOad);
            Controls.Add(label1);
            Controls.Add(lstPayroll);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountantForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бухгалтер - данные для расчёта ЗП";
            Load += AccountantForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPayroll;
        private Label label1;
        private Button btnLOad;
    }
}