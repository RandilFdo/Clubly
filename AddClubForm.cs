using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace ClubManager
{
    public partial class AddClubForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color primaryColor;
        public Club NewClub { get; private set; }
        private Club existingClub;

        private Guna2Panel titleBar;
        private Guna2TextBox txtName;
        private Guna2TextBox txtCategory;
        private Guna2TextBox txtDescription;
        private Guna2DateTimePicker dtpNextEventDate;
        private Guna2NumericUpDown nudOutstandingTasks;
        private Guna2NumericUpDown nudUnpaidDues;
        private Guna2Button btnSave;
        private Guna2Button btnCancel;

        public AddClubForm(Color primaryColor, Club clubToEdit = null)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(600, 750);
            this.BackColor = Color.White;
            this.primaryColor = primaryColor;
            this.existingClub = clubToEdit;

            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
            // ===== TITLE BAR =====
            titleBar = new Guna2Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                FillColor = primaryColor,
                ShadowDecoration = { Enabled = true, Depth = 5 }
            };

            Label titleLabel = new Label
            {
                Text = existingClub == null ? "ADD NEW CLUB" : "EDIT CLUB",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Guna2ControlBox closeButton = new Guna2ControlBox
            {
                Dock = DockStyle.Right,
                FillColor = primaryColor,
                IconColor = Color.White,
                HoverState = { FillColor = Color.Red }
            };

            titleBar.Controls.Add(titleLabel);
            titleBar.Controls.Add(closeButton);

            // Make draggable
            titleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
            };
            titleLabel.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
            };

            // ===== MAIN CONTENT PANEL =====
            Guna2Panel mainPanel = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                FillColor = Color.FromArgb(242, 245, 250),
                Padding = new Padding(30)
            };

            // ===== FORM CONTENT =====
            Panel formContent = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.Transparent
            };

            int yPosition = 0;
            int spacing = 55;
            int labelMargin = 30;

            // Club Name
            Label lblName = CreateLabel("Club Name *", yPosition);
            formContent.Controls.Add(lblName);
            yPosition += labelMargin;

            txtName = new Guna2TextBox
            {
                Location = new Point(0, yPosition),
                Width = 500,
                Height = 40,
                PlaceholderText = "Enter club name...",
                Font = new Font("Segoe UI", 10F),
                BorderRadius = 8,
                BorderColor = Color.FromArgb(213, 218, 223),
                FocusedState = { BorderColor = primaryColor }
            };
            formContent.Controls.Add(txtName);
            yPosition += spacing;

            // Category
            Label lblCategory = CreateLabel("Category", yPosition);
            formContent.Controls.Add(lblCategory);
            yPosition += labelMargin;

            txtCategory = new Guna2TextBox
            {
                Location = new Point(0, yPosition),
                Width = 500,
                Height = 40,
                PlaceholderText = "e.g., Sports, Arts, Technology...",
                Font = new Font("Segoe UI", 10F),
                BorderRadius = 8,
                BorderColor = Color.FromArgb(213, 218, 223),
                FocusedState = { BorderColor = primaryColor }
            };
            formContent.Controls.Add(txtCategory);
            yPosition += spacing;

            // Description
            Label lblDescription = CreateLabel("Description", yPosition);
            formContent.Controls.Add(lblDescription);
            yPosition += labelMargin;

            txtDescription = new Guna2TextBox
            {
                Location = new Point(0, yPosition),
                Width = 500,
                Height = 100,
                Multiline = true,
                PlaceholderText = "Enter club description...",
                Font = new Font("Segoe UI", 10F),
                BorderRadius = 8,
                BorderColor = Color.FromArgb(213, 218, 223),
                FocusedState = { BorderColor = primaryColor }
            };
            formContent.Controls.Add(txtDescription);
            yPosition += 115;

            // Next Event Date
            Label lblNextEventDate = CreateLabel("Next Event Date", yPosition);
            formContent.Controls.Add(lblNextEventDate);
            yPosition += labelMargin;

            dtpNextEventDate = new Guna2DateTimePicker
            {
                Location = new Point(0, yPosition),
                Width = 500,
                Height = 40,
                Font = new Font("Segoe UI", 10F),
                BorderRadius = 8,
                BorderColor = Color.FromArgb(213, 218, 223),
                Checked = true,
                FillColor = Color.White,
                Format = DateTimePickerFormat.Long
            };
            formContent.Controls.Add(dtpNextEventDate);
            yPosition += spacing;

            // --- Numeric Up/Downs Side-by-Side ---
            int numericY = yPosition;

            // Outstanding Tasks
            Label lblOutstandingTasks = CreateLabel("Outstanding Tasks", numericY);
            formContent.Controls.Add(lblOutstandingTasks);
            numericY += labelMargin;

            nudOutstandingTasks = new Guna2NumericUpDown
            {
                Location = new Point(0, numericY),
                Width = 240,
                Height = 40,
                Minimum = 0,
                Maximum = 1000,
                Font = new Font("Segoe UI", 10F),
                BorderRadius = 8,
                BorderColor = Color.FromArgb(213, 218, 223),
                FocusedState = { BorderColor = primaryColor },
                UpDownButtonFillColor = primaryColor,
                UpDownButtonForeColor = Color.White
            };
            formContent.Controls.Add(nudOutstandingTasks);

            // Unpaid Dues
            Label lblUnpaidDues = CreateLabel("Unpaid Dues ($)", numericY - labelMargin);
            lblUnpaidDues.Location = new Point(260, numericY - labelMargin);
            formContent.Controls.Add(lblUnpaidDues);

            nudUnpaidDues = new Guna2NumericUpDown
            {
                Location = new Point(260, numericY),
                Width = 240,
                Height = 40,
                Minimum = 0,
                Maximum = 100000,
                Font = new Font("Segoe UI", 10F),
                BorderRadius = 8,
                BorderColor = Color.FromArgb(213, 218, 223),
                FocusedState = { BorderColor = primaryColor },
                UpDownButtonFillColor = primaryColor,
                UpDownButtonForeColor = Color.White
            };
            formContent.Controls.Add(nudUnpaidDues);

            mainPanel.Controls.Add(formContent);

            // ===== BUTTON PANEL =====
            Guna2Panel buttonPanel = new Guna2Panel
            {
                Dock = DockStyle.Bottom,
                Height = 80,
                FillColor = Color.White,
                Padding = new Padding(0, 15, 30, 15)
            };

            btnSave = new Guna2Button
            {
                Text = existingClub == null ? "ADD CLUB" : "UPDATE CLUB",
                Height = 45,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BorderRadius = 10,
                FillColor = primaryColor,
                ForeColor = Color.White,
                Dock = DockStyle.Right,
                Width = 180,
                Cursor = Cursors.Hand
            };

            btnCancel = new Guna2Button
            {
                Text = "CANCEL",
                Height = 45,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BorderRadius = 10,
                FillColor = Color.Transparent,
                ForeColor = Color.FromArgb(64, 64, 64),
                Dock = DockStyle.Right,
                Width = 130,
                Cursor = Cursors.Hand
            };

            buttonPanel.Controls.Add(btnSave);
            buttonPanel.Controls.Add(btnCancel);

            // ===== ADD ALL TO FORM =====
            this.Controls.Add(mainPanel);
            this.Controls.Add(buttonPanel);
            this.Controls.Add(titleBar);

            // ===== POPULATE DATA IF EDITING =====
            if (existingClub != null)
            {
                txtName.Text = existingClub.Name;
                txtCategory.Text = existingClub.Category;
                txtDescription.Text = existingClub.Description;
                dtpNextEventDate.Value = existingClub.NextEventDate;
                nudOutstandingTasks.Value = existingClub.OutstandingTasks;
                nudUnpaidDues.Value = existingClub.UnpaidDues;
            }

            // ===== EVENT HANDLERS =====
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }

        private Label CreateLabel(string text, int yPosition)
        {
            return new Label
            {
                Text = text,
                Location = new Point(0, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64)
            };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a club name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Save data
            if (existingClub != null)
            {
                existingClub.Name = txtName.Text.Trim();
                existingClub.Category = txtCategory.Text.Trim();
                existingClub.Description = txtDescription.Text.Trim();
                existingClub.NextEventDate = dtpNextEventDate.Value;
                existingClub.OutstandingTasks = (int)nudOutstandingTasks.Value;
                existingClub.UnpaidDues = (int)nudUnpaidDues.Value;
                NewClub = existingClub;
            }
            else
            {
                NewClub = new Club(
                    txtName.Text.Trim(),
                    txtCategory.Text.Trim(),
                    txtDescription.Text.Trim(),
                    dtpNextEventDate.Value,
                    (int)nudOutstandingTasks.Value,
                    (int)nudUnpaidDues.Value
                );
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
