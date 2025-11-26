namespace КР_ПИ
{
    partial class BindUserToEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindUserToEmployee));
            cmbUsers = new ComboBox();
            cmbEmployees = new ComboBox();
            btnBind = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            resources.ApplyResources(cmbUsers, "cmbUsers");
            cmbUsers.Name = "cmbUsers";
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            resources.ApplyResources(cmbEmployees, "cmbEmployees");
            cmbEmployees.Name = "cmbEmployees";
            // 
            // btnBind
            // 
            btnBind.BackColor = Color.DarkGray;
            resources.ApplyResources(btnBind, "btnBind");
            btnBind.Name = "btnBind";
            btnBind.UseVisualStyleBackColor = false;
            btnBind.Click += btnBind_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Name = "label2";
            // 
            // BindUserToEmployee
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBind);
            Controls.Add(cmbEmployees);
            Controls.Add(cmbUsers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BindUserToEmployee";
            Load += BindUserToEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsers;
        private ComboBox cmbEmployees;
        private Button btnBind;
        private Label label1;
        private Label label2;
    }
}