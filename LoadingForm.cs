using System;
using System.Windows.Forms;

namespace ClubManager
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#7c3aed"); // Primary color
            this.FormBorderStyle = FormBorderStyle.None; // Make it borderless
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form

            // Center label1 and progressBar1
            label1.Location = new System.Drawing.Point((this.ClientSize.Width - label1.Width) / 2, (this.ClientSize.Height - label1.Height) / 2);
            progressBar1.Location = new System.Drawing.Point((this.ClientSize.Width - progressBar1.Width) / 2, (this.ClientSize.Height / 2) + 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}