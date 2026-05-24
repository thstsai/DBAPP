using System;
using System.Linq;
using System.Windows.Forms;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // validate input
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("username and password is required!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open database
            using (var db = new UniversityEntities())
            {
                // check if user exists
                var user = db.user
                    .Where(u => u.username == usernameTextBox.Text &&
                                u.password == passwordTextBox.Text)
                    .FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // store current user in session
                Session.CurrentUser = user;

                // hide login form
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                this.Hide();

                // open form based on role
                switch (user.role)
                {
                    case "administrator":
                        var adminForm = new AdminForm();
                        adminForm.ShowDialog();
                        break;

                    case "instructor":
                        var facultyForm = new FacultyForm();
                        facultyForm.ShowDialog();
                        break;

                    case "student":
                        var studentForm = new StudentForm();
                        studentForm.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("Unknown role: " + user.role, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                // show login form again after sub-form closes
                this.Show();
            }
        }
    }
}
