namespace EducationCenter
{
    partial class LoginView
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
            panel1 = new Panel();
            EducationCenterTleLbl = new Label();
            EmailLoginLbl = new Label();
            LoginEmailTxb = new TextBox();
            PasswordLoginLbl = new Label();
            LoginPassTxb = new TextBox();
            LoginBtn = new Button();
            LoginErrorMsgLbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(EducationCenterTleLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // EducationCenterTleLbl
            // 
            EducationCenterTleLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            EducationCenterTleLbl.AutoSize = true;
            EducationCenterTleLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EducationCenterTleLbl.Location = new Point(325, 27);
            EducationCenterTleLbl.Name = "EducationCenterTleLbl";
            EducationCenterTleLbl.Size = new Size(104, 45);
            EducationCenterTleLbl.TabIndex = 0;
            EducationCenterTleLbl.Text = "Login";
            // 
            // EmailLoginLbl
            // 
            EmailLoginLbl.AutoSize = true;
            EmailLoginLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLoginLbl.Location = new Point(199, 197);
            EmailLoginLbl.Name = "EmailLoginLbl";
            EmailLoginLbl.Size = new Size(66, 30);
            EmailLoginLbl.TabIndex = 1;
            EmailLoginLbl.Text = "Email";
            // 
            // LoginEmailTxb
            // 
            LoginEmailTxb.Location = new Point(277, 204);
            LoginEmailTxb.Name = "LoginEmailTxb";
            LoginEmailTxb.Size = new Size(226, 23);
            LoginEmailTxb.TabIndex = 2;
            // 
            // PasswordLoginLbl
            // 
            PasswordLoginLbl.AutoSize = true;
            PasswordLoginLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLoginLbl.Location = new Point(160, 248);
            PasswordLoginLbl.Name = "PasswordLoginLbl";
            PasswordLoginLbl.Size = new Size(105, 30);
            PasswordLoginLbl.TabIndex = 3;
            PasswordLoginLbl.Text = "Password";
            // 
            // LoginPassTxb
            // 
            LoginPassTxb.Location = new Point(277, 255);
            LoginPassTxb.Name = "LoginPassTxb";
            LoginPassTxb.PasswordChar = '*';
            LoginPassTxb.Size = new Size(226, 23);
            LoginPassTxb.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ActiveCaption;
            LoginBtn.FlatAppearance.BorderColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Location = new Point(277, 320);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(226, 23);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // LoginErrorMsgLbl
            // 
            LoginErrorMsgLbl.AutoSize = true;
            LoginErrorMsgLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginErrorMsgLbl.ForeColor = Color.Red;
            LoginErrorMsgLbl.Location = new Point(277, 281);
            LoginErrorMsgLbl.Name = "LoginErrorMsgLbl";
            LoginErrorMsgLbl.Size = new Size(0, 21);
            LoginErrorMsgLbl.TabIndex = 6;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginErrorMsgLbl);
            Controls.Add(LoginBtn);
            Controls.Add(LoginPassTxb);
            Controls.Add(PasswordLoginLbl);
            Controls.Add(LoginEmailTxb);
            Controls.Add(EmailLoginLbl);
            Controls.Add(panel1);
            Name = "LoginView";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label EducationCenterTleLbl;
        private Label EmailLoginLbl;
        private TextBox LoginEmailTxb;
        private Label PasswordLoginLbl;
        private TextBox LoginPassTxb;
        private Button LoginBtn;
        private Label LoginErrorMsgLbl;
    }
}