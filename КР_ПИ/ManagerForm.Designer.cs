namespace КР_ПИ
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            lstDeptEmployees = new ListBox();
            label1 = new Label();
            btnApprove = new Button();
            SuspendLayout();
            // 
            // lstDeptEmployees
            // 
            lstDeptEmployees.FormattingEnabled = true;
            lstDeptEmployees.ItemHeight = 22;
            lstDeptEmployees.Location = new Point(76, 59);
            lstDeptEmployees.Margin = new Padding(3, 4, 3, 4);
            lstDeptEmployees.Name = "lstDeptEmployees";
            lstDeptEmployees.Size = new Size(534, 290);
            lstDeptEmployees.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(76, 33);
            label1.Name = "label1";
            label1.Size = new Size(169, 22);
            label1.TabIndex = 1;
            label1.Text = "Список заявок на отпуск";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = SystemColors.ControlDark;
            btnApprove.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnApprove.Location = new Point(76, 357);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(255, 44);
            btnApprove.TabIndex = 2;
            btnApprove.Text = "Согласовать отпуск";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(682, 453);
            Controls.Add(btnApprove);
            Controls.Add(label1);
            Controls.Add(lstDeptEmployees);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начальник отдела - согласование отпусков";
            Load += ManagerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDeptEmployees;
        private Label label1;
        private Button btnApprove;
    }
}