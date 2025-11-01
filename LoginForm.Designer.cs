namespace ClubManager
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelLogin = new Panel();
            lblLoginTitle = new Label();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBoxMascot = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMascot).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(lblLoginTitle);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtLoginPassword);
            panelLogin.Controls.Add(txtLoginEmail);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(491, 176);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(500, 350);
            panelLogin.TabIndex = 0;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.ForeColor = Color.White;
            lblLoginTitle.Location = new Point(240, 40);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(123, 46);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(155, 109, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(240, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BackColor = Color.FromArgb(90, 46, 158);
            txtLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPassword.ForeColor = Color.White;
            txtLoginPassword.Location = new Point(220, 217);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(280, 31);
            txtLoginPassword.TabIndex = 3;
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.BackColor = Color.FromArgb(90, 46, 158);
            txtLoginEmail.BorderStyle = BorderStyle.FixedSingle;
            txtLoginEmail.ForeColor = Color.White;
            txtLoginEmail.Location = new Point(220, 147);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(280, 31);
            txtLoginEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(100, 220);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(100, 150);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // pictureBoxMascot
            // 
            pictureBoxMascot.BackColor = Color.Transparent;
            pictureBoxMascot.Image = Properties.Resources.mascot;
            pictureBoxMascot.Location = new Point(135, 178);
            pictureBoxMascot.Name = "pictureBoxMascot";
            pictureBoxMascot.Size = new Size(450, 350);
            pictureBoxMascot.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMascot.TabIndex = 1;
            pictureBoxMascot.TabStop = false;
            pictureBoxMascot.Click += pictureBoxMascot_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelLogin);
            Controls.Add(pictureBoxMascot);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMascot).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.PictureBox pictureBoxMascot;

    }
}