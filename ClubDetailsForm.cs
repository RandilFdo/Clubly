using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ClubManager
{
    public partial class ClubDetailsForm : Form
    {
        public ClubDetailsForm(Club club, Color primaryColor)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;

            // Custom Title Bar
            Guna2Panel titleBarPanel = new Guna2Panel
            {
                Dock = DockStyle.Top,
                Height = 30,
                FillColor = primaryColor
            };

            Label titleLabel = new Label
            {
                Text = club.Name,
                Dock = DockStyle.Left,
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            titleBarPanel.Controls.Add(titleLabel);

            Guna2ControlBox closeButton = new Guna2ControlBox
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                FillColor = primaryColor,
                IconColor = Color.White,
                Dock = DockStyle.Right
            };
            titleBarPanel.Controls.Add(closeButton);

            // Details
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 6,
                Padding = new Padding(10),
                AutoSize = true
            };
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            Label lblCategory = new Label { Text = "Category:", AutoSize = true, Anchor = AnchorStyles.Left };
            Label valCategory = new Label { Text = club.Category, AutoSize = true, Anchor = AnchorStyles.Left };

            Label lblDescription = new Label { Text = "Description:", AutoSize = true, Anchor = AnchorStyles.Left };
            Label valDescription = new Label { Text = club.Description, AutoSize = true, Anchor = AnchorStyles.Left };

            Label lblNextEventDate = new Label { Text = "Next Event Date:", AutoSize = true, Anchor = AnchorStyles.Left };
            Label valNextEventDate = new Label { Text = club.NextEventDate.ToShortDateString(), AutoSize = true, Anchor = AnchorStyles.Left };

            Label lblOutstandingTasks = new Label { Text = "Outstanding Tasks:", AutoSize = true, Anchor = AnchorStyles.Left };
            Label valOutstandingTasks = new Label { Text = club.OutstandingTasks.ToString(), AutoSize = true, Anchor = AnchorStyles.Left };

            Label lblUnpaidDues = new Label { Text = "Unpaid Dues:", AutoSize = true, Anchor = AnchorStyles.Left };
            Label valUnpaidDues = new Label { Text = club.UnpaidDues.ToString(), AutoSize = true, Anchor = AnchorStyles.Left };

            tableLayoutPanel.Controls.Add(lblCategory, 0, 0);
            tableLayoutPanel.Controls.Add(valCategory, 1, 0);
            tableLayoutPanel.Controls.Add(lblDescription, 0, 1);
            tableLayoutPanel.Controls.Add(valDescription, 1, 1);
            tableLayoutPanel.Controls.Add(lblNextEventDate, 0, 2);
            tableLayoutPanel.Controls.Add(valNextEventDate, 1, 2);
            tableLayoutPanel.Controls.Add(lblOutstandingTasks, 0, 3);
            tableLayoutPanel.Controls.Add(valOutstandingTasks, 1, 3);
            tableLayoutPanel.Controls.Add(lblUnpaidDues, 0, 4);
            tableLayoutPanel.Controls.Add(valUnpaidDues, 1, 4);

            this.Controls.Add(tableLayoutPanel);
            this.Controls.Add(titleBarPanel);
        }
    }
}