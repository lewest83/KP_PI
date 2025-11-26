namespace КР_ПИ
{
    partial class ApplyLeaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLeaveForm));
            lblFrom = new Label();
            dtFrom = new DateTimePicker();
            lblTo = new Label();
            dtTo = new DateTimePicker();
            lblReason = new Label();
            txtReason = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            lblFrom.ForeColor = SystemColors.ButtonFace;
            lblFrom.Location = new Point(74, 66);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(25, 22);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "С:";
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(105, 61);
            dtFrom.Margin = new Padding(3, 4, 3, 4);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(199, 27);
            dtFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            lblTo.ForeColor = SystemColors.ButtonFace;
            lblTo.Location = new Point(353, 66);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(34, 22);
            lblTo.TabIndex = 2;
            lblTo.Text = "По:";
            // 
            // dtTo
            // 
            dtTo.Location = new Point(393, 57);
            dtTo.Margin = new Padding(3, 4, 3, 4);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(199, 27);
            dtTo.TabIndex = 3;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            lblReason.ForeColor = SystemColors.ButtonFace;
            lblReason.Location = new Point(74, 209);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(76, 22);
            lblReason.TabIndex = 4;
            lblReason.Text = "Причина:";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(156, 204);
            txtReason.Margin = new Padding(3, 4, 3, 4);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(199, 27);
            txtReason.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSend.Location = new Point(74, 279);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(152, 45);
            btnSend.TabIndex = 6;
            btnSend.Text = "Отправить";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // ApplyLeaveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(682, 453);
            Controls.Add(btnSend);
            Controls.Add(txtReason);
            Controls.Add(lblReason);
            Controls.Add(dtTo);
            Controls.Add(lblTo);
            Controls.Add(dtFrom);
            Controls.Add(lblFrom);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplyLeaveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подача заявления на отпуск";
            WindowState = FormWindowState.Minimized;
            Load += ApplyLeaveForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private DateTimePicker dtFrom;
        private Label lblTo;
        private DateTimePicker dtTo;
        private Label lblReason;
        private TextBox txtReason;
        private Button btnSend;
    }
}