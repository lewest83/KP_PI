namespace КР_ПИ
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Arial Narrow", 10.2F);
            lblUser.ForeColor = SystemColors.ButtonFace;
            lblUser.Location = new Point(56, 58);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(131, 22);
            lblUser.TabIndex = 0;
            lblUser.Text = "Имя пользователя";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Arial Narrow", 10.2F);
            txtUser.Location = new Point(56, 82);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(243, 27);
            txtUser.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Font = new Font("Arial Narrow", 10.2F);
            lblPass.ForeColor = SystemColors.ButtonFace;
            lblPass.Location = new Point(56, 165);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(59, 22);
            lblPass.TabIndex = 2;
            lblPass.Text = "Пароль";
            lblPass.Click += lblPass_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Arial Narrow", 10.2F);
            txtPass.Location = new Point(56, 189);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(243, 27);
            txtPass.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Arial Narrow", 10.2F);
            lblRole.Location = new Point(575, 57);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 22);
            lblRole.TabIndex = 4;
            lblRole.Text = "Роль";
            lblRole.Click += label1_Click;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Arial Narrow", 10.2F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(374, 81);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(243, 30);
            cmbRole.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ControlDark;
            btnCreate.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreate.Location = new Point(216, 289);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(243, 40);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(682, 453);
            Controls.Add(btnCreate);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txtUser;
        private Label lblPass;
        private TextBox txtPass;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnCreate;
    }
}