
using System;
using System.Windows.Forms;

namespace ClubManager
{
    public partial class LoginForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#7c3aed"), -0.2); // Same as panelLogin background
            panelLogin.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#7c3aed"), -0.2); // Slightly darker
            this.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            this.MouseDown += new MouseEventHandler(LoginForm_MouseDown);
            this.MouseMove += new MouseEventHandler(LoginForm_MouseMove);
            this.MouseUp += new MouseEventHandler(LoginForm_MouseUp);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginEmail.Text; // Assuming email field is used for username
            string password = txtLoginPassword.Text;

            if (username == "Randil" && password == "password")
            {
                // On success, create and show the MainMenu
                // Pass a dummy userId and clubId for this session
                MainMenu mainMenu = new MainMenu("Randil", "CLUB-ALPHA-001"); // Using "Randil" as userId
                mainMenu.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMascot_Click(object sender, EventArgs e)
        {

        }

        // Removed signup related methods as per user request
        // private void btnSignup_Click(object sender, EventArgs e) { ... }
        // private void lblToggleToSignup_Click(object sender, EventArgs e) { ... }
        // private void lblToggleToLogin_Click(object sender, EventArgs e) { ... }

    }
}
