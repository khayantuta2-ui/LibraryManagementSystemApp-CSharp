using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MemberForm : Form
    {
        private LibraryManager libraryManager;
        private Member currentMember;

        public MemberForm(LibraryManager manager, Member member)
        {
            InitializeComponent();
            libraryManager = manager;
            currentMember = member;
            LoadAvailableBooks();
            LoadBorrowedBooks();
            DisplayMemberInfo();
        }

        // Method to display member information
        private void DisplayMemberInfo()
        {
            lblMemberInfo.Text = "Welcome, " + currentMember.Name + " | Member ID: " + currentMember.Id + " | Join Date: " + currentMember.JoinDate.ToShortDateString();
        }

        // Method to load available books into the listbox
        private void LoadAvailableBooks()
        {
            lstAvailableBooks.Items.Clear();
            foreach (Book book in libraryManager.GetAllBooks())
            {
                if (book.IsAvailable)
                {
                    lstAvailableBooks.Items.Add(book.GetBookDetails());
                }
            }
        }

        // Method to load borrowed books into the listbox
        private void LoadBorrowedBooks()
        {
            lstBorrowedBooks.Items.Clear();
            foreach (Book book in currentMember.BorrowedBooks)
            {
                lstBorrowedBooks.Items.Add(book.GetBookDetails());
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
                    LoadAvailableBooks(); // Show all available books if search is empty
                    return;
                }

                // Search for available books
                var results = libraryManager.SearchBooks(searchTerm);
                lstAvailableBooks.Items.Clear();

                bool foundAvailable = false;
                foreach (Book book in results)
                {
                    if (book.IsAvailable)
                    {
                        lstAvailableBooks.Items.Add(book.GetBookDetails());
                        foundAvailable = true;
                    }
                }

                if (!foundAvailable)
                {
                    MessageBox.Show("No available books found matching the search term.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAvailableBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Borrow Book button
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a book is selected
                if (lstAvailableBooks.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a book to borrow.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate book ID input
                if (string.IsNullOrWhiteSpace(txtBorrowBookId.Text))
                {
                    MessageBox.Show("Please enter the Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse book ID
                if (!int.TryParse(txtBorrowBookId.Text, out int bookId))
                {
                    MessageBox.Show("Book ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Find the book
                Book bookToBorrow = libraryManager.FindBookById(bookId);

                if (bookToBorrow == null)
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Try to borrow the book - will throw custom exception if not available
                currentMember.BorrowBook(bookToBorrow);
                MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input and refresh displays
                txtBorrowBookId.Clear();
                LoadAvailableBooks();
                LoadBorrowedBooks();
            }
            catch (BookNotAvailableException ex)
            {
                // Handle custom exception
                MessageBox.Show(ex.Message, "Book Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Book ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error borrowing book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Return Book button
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a book is selected
                if (lstBorrowedBooks.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a book to return.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate book ID input
                if (string.IsNullOrWhiteSpace(txtReturnBookId.Text))
                {
                    MessageBox.Show("Please enter the Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse book ID
                if (!int.TryParse(txtReturnBookId.Text, out int bookId))
                {
                    MessageBox.Show("Book ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Find the book in borrowed books
                Book bookToReturn = currentMember.BorrowedBooks.Find(b => b.Id == bookId);

                if (bookToReturn == null)
                {
                    MessageBox.Show("You have not borrowed this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Return the book
                currentMember.ReturnBook(bookToReturn);
                MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input and refresh displays
                txtReturnBookId.Clear();
                LoadAvailableBooks();
                LoadBorrowedBooks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Book ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAvailableBooks();
            LoadBorrowedBooks();
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
