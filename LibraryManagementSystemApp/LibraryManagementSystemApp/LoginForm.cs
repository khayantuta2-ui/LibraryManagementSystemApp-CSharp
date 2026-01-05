using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private LibraryManager libraryManager;

        public LoginForm()
        {
            InitializeComponent();
            libraryManager = new LibraryManager();
        }

        // Event handler for Login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Check if logging in as librarian
                if (rbLibrarian.Checked)
                {
                    Librarian librarian = libraryManager.AuthenticateLibrarian(username, password);
                    if (librarian != null)
                    {
                        MessageBox.Show("Welcome, " + librarian.Name + "!\n" + librarian.GetRole(), "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open Librarian Dashboard
                        LibrarianForm librarianForm = new LibrarianForm(libraryManager);
                        this.Hide();
                        librarianForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid librarian credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Check if logging in as member
                else if (rbMember.Checked)
                {
                    Member member = libraryManager.AuthenticateMember(username, password);
                    if (member != null)
                    {
                        MessageBox.Show("Welcome, " + member.Name + "!\n" + member.GetRole(), "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open Member Dashboard
                        MemberForm memberForm = new MemberForm(libraryManager, member);
                        this.Hide();
                        memberForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid member credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select user type (Librarian or Member).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}