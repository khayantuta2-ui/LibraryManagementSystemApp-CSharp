using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibrarianForm : Form
    {
        private LibraryManager libraryManager;

        public LibrarianForm(LibraryManager manager)
        {
            InitializeComponent();
            libraryManager = manager;
            LoadBooks();
            LoadMembers();
        }

        // Method to load all books into the listbox
        private void LoadBooks()
        {
            lstBooks.Items.Clear();
            foreach (Book book in libraryManager.GetAllBooks())
            {
                lstBooks.Items.Add(book.GetBookDetails());
            }
        }

        // Method to load all members into the listbox
        private void LoadMembers()
        {
            lstMembers.Items.Clear();
            foreach (Member member in libraryManager.GetAllMembers())
            {
                lstMembers.Items.Add("ID: " + member.Id + " | Name: " + member.Name + " | Joined: " + member.JoinDate.ToShortDateString());
            }
        }

        // Event handler for Add Book button
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtBookTitle.Text) || string.IsNullOrWhiteSpace(txtBookAuthor.Text))
                {
                    MessageBox.Show("Please enter book title and author.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get next available ID
                int bookId = libraryManager.GetNextBookId();
                string title = txtBookTitle.Text.Trim();
                string author = txtBookAuthor.Text.Trim();

                // Add book to library
                libraryManager.AddBook(bookId, title, author);
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields and refresh display
                txtBookTitle.Clear();
                txtBookAuthor.Clear();
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Add Member button
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtMemberName.Text) || string.IsNullOrWhiteSpace(txtMemberPassword.Text))
                {
                    MessageBox.Show("Please enter member name and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get next available ID
                int memberId = libraryManager.GetNextMemberId();
                string name = txtMemberName.Text.Trim();
                string password = txtMemberPassword.Text.Trim();

                // Add member to library
                libraryManager.AddMember(memberId, name, password);
                MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields and refresh display
                txtMemberName.Clear();
                txtMemberPassword.Clear();
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Search Books button
        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchBooks.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadBooks(); // Show all books if search is empty
                    return;
                }

                // Search for books
                var results = libraryManager.SearchBooks(searchTerm);
                lstBooks.Items.Clear();

                if (results.Count > 0)
                {
                    foreach (Book book in results)
                    {
                        lstBooks.Items.Add(book.GetBookDetails());
                    }
                }
                else
                {
                    MessageBox.Show("No books found matching the search term.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
            LoadMembers();
            MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for Logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}