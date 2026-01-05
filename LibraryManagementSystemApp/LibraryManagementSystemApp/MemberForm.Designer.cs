namespace LibraryManagementSystem
{
    partial class MemberForm
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.grpAvailableBooks = new System.Windows.Forms.GroupBox();
            this.lstAvailableBooks = new System.Windows.Forms.ListBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.lblSearchBooks = new System.Windows.Forms.Label();
            this.grpBorrowBook = new System.Windows.Forms.GroupBox();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.txtBorrowBookId = new System.Windows.Forms.TextBox();
            this.lblBorrowBookId = new System.Windows.Forms.Label();
            this.grpBorrowedBooks = new System.Windows.Forms.GroupBox();
            this.lstBorrowedBooks = new System.Windows.Forms.ListBox();
            this.grpReturnBook = new System.Windows.Forms.GroupBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.txtReturnBookId = new System.Windows.Forms.TextBox();
            this.lblReturnBookId = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpAvailableBooks.SuspendLayout();
            this.grpBorrowBook.SuspendLayout();
            this.grpBorrowedBooks.SuspendLayout();
            this.grpReturnBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(280, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Member Dashboard";
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Location = new System.Drawing.Point(20, 50);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(74, 13);
            this.lblMemberInfo.TabIndex = 1;
            this.lblMemberInfo.Text = "Member Info";
            // 
            // grpAvailableBooks
            // 
            this.grpAvailableBooks.Controls.Add(this.lstAvailableBooks);
            this.grpAvailableBooks.Controls.Add(this.btnSearchBooks);
            this.grpAvailableBooks.Controls.Add(this.txtSearchBooks);
            this.grpAvailableBooks.Controls.Add(this.lblSearchBooks);
            this.grpAvailableBooks.Location = new System.Drawing.Point(20, 80);
            this.grpAvailableBooks.Name = "grpAvailableBooks";
            this.grpAvailableBooks.Size = new System.Drawing.Size(350, 280);
            this.grpAvailableBooks.TabIndex = 2;
            this.grpAvailableBooks.TabStop = false;
            this.grpAvailableBooks.Text = "Available Books";
            // 
            // lstAvailableBooks
            // 
            this.lstAvailableBooks.FormattingEnabled = true;
            this.lstAvailableBooks.HorizontalScrollbar = true;
            this.lstAvailableBooks.Location = new System.Drawing.Point(20, 80);
            this.lstAvailableBooks.Name = "lstAvailableBooks";
            this.lstAvailableBooks.Size = new System.Drawing.Size(310, 186);
            this.lstAvailableBooks.TabIndex = 3;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(230, 42);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(100, 25);
            this.btnSearchBooks.TabIndex = 2;
            this.btnSearchBooks.Text = "Search";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Location = new System.Drawing.Point(80, 45);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(140, 20);
            this.txtSearchBooks.TabIndex = 1;
            // 
            // lblSearchBooks
            // 
            this.lblSearchBooks.AutoSize = true;
            this.lblSearchBooks.Location = new System.Drawing.Point(20, 48);
            this.lblSearchBooks.Name = "lblSearchBooks";
            this.lblSearchBooks.Size = new System.Drawing.Size(44, 13);
            this.lblSearchBooks.TabIndex = 0;
            this.lblSearchBooks.Text = "Search:";
            // 
            // grpBorrowBook
            // 
            this.grpBorrowBook.Controls.Add(this.btnBorrowBook);
            this.grpBorrowBook.Controls.Add(this.txtBorrowBookId);
            this.grpBorrowBook.Controls.Add(this.lblBorrowBookId);
            this.grpBorrowBook.Location = new System.Drawing.Point(20, 380);
            this.grpBorrowBook.Name = "grpBorrowBook";
            this.grpBorrowBook.Size = new System.Drawing.Size(350, 100);
            this.grpBorrowBook.TabIndex = 3;
            this.grpBorrowBook.TabStop = false;
            this.grpBorrowBook.Text = "Borrow Book";
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(230, 50);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(100, 25);
            this.btnBorrowBook.TabIndex = 2;
            this.btnBorrowBook.Text = "Borrow";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // txtBorrowBookId
            // 
            this.txtBorrowBookId.Location = new System.Drawing.Point(100, 53);
            this.txtBorrowBookId.Name = "txtBorrowBookId";
            this.txtBorrowBookId.Size = new System.Drawing.Size(120, 20);
            this.txtBorrowBookId.TabIndex = 1;
            // 
            // lblBorrowBookId
            // 
            this.lblBorrowBookId.AutoSize = true;
            this.lblBorrowBookId.Location = new System.Drawing.Point(20, 56);
            this.lblBorrowBookId.Name = "lblBorrowBookId";
            this.lblBorrowBookId.Size = new System.Drawing.Size(49, 13);
            this.lblBorrowBookId.TabIndex = 0;
            this.lblBorrowBookId.Text = "Book ID:";
            // 
            // grpBorrowedBooks
            // 
            this.grpBorrowedBooks.Controls.Add(this.lstBorrowedBooks);
            this.grpBorrowedBooks.Location = new System.Drawing.Point(390, 80);
            this.grpBorrowedBooks.Name = "grpBorrowedBooks";
            this.grpBorrowedBooks.Size = new System.Drawing.Size(350, 280);
            this.grpBorrowedBooks.TabIndex = 4;
            this.grpBorrowedBooks.TabStop = false;
            this.grpBorrowedBooks.Text = "My Borrowed Books";
            // 
            // lstBorrowedBooks
            // 
            this.lstBorrowedBooks.FormattingEnabled = true;
            this.lstBorrowedBooks.HorizontalScrollbar = true;
            this.lstBorrowedBooks.Location = new System.Drawing.Point(20, 30);
            this.lstBorrowedBooks.Name = "lstBorrowedBooks";
            this.lstBorrowedBooks.Size = new System.Drawing.Size(310, 238);
            this.lstBorrowedBooks.TabIndex = 0;
            // 
            // grpReturnBook
            // 
            this.grpReturnBook.Controls.Add(this.btnReturnBook);
            this.grpReturnBook.Controls.Add(this.txtReturnBookId);
            this.grpReturnBook.Controls.Add(this.lblReturnBookId);
            this.grpReturnBook.Location = new System.Drawing.Point(390, 380);
            this.grpReturnBook.Name = "grpReturnBook";
            this.grpReturnBook.Size = new System.Drawing.Size(350, 100);
            this.grpReturnBook.TabIndex = 5;
            this.grpReturnBook.TabStop = false;
            this.grpReturnBook.Text = "Return Book";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(230, 50);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(100, 25);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // txtReturnBookId
            // 
            this.txtReturnBookId.Location = new System.Drawing.Point(100, 53);
            this.txtReturnBookId.Name = "txtReturnBookId";
            this.txtReturnBookId.Size = new System.Drawing.Size(120, 20);
            this.txtReturnBookId.TabIndex = 1;
            // 
            // lblReturnBookId
            // 
            this.lblReturnBookId.AutoSize = true;
            this.lblReturnBookId.Location = new System.Drawing.Point(20, 56);
            this.lblReturnBookId.Name = "lblReturnBookId";
            this.lblReturnBookId.Size = new System.Drawing.Size(49, 13);
            this.lblReturnBookId.TabIndex = 0;
            this.lblReturnBookId.Text = "Book ID:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(560, 500);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(660, 500);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 541);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpReturnBook);
            this.Controls.Add(this.grpBorrowedBooks);
            this.Controls.Add(this.grpBorrowBook);
            this.Controls.Add(this.grpAvailableBooks);
            this.Controls.Add(this.lblMemberInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Member";
            this.grpAvailableBooks.ResumeLayout(false);
            this.grpAvailableBooks.PerformLayout();
            this.grpBorrowBook.ResumeLayout(false);
            this.grpBorrowBook.PerformLayout();
            this.grpBorrowedBooks.ResumeLayout(false);
            this.grpReturnBook.ResumeLayout(false);
            this.grpReturnBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.GroupBox grpAvailableBooks;
        private System.Windows.Forms.ListBox lstAvailableBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.Label lblSearchBooks;
        private System.Windows.Forms.GroupBox grpBorrowBook;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.TextBox txtBorrowBookId;
        private System.Windows.Forms.Label lblBorrowBookId;
        private System.Windows.Forms.GroupBox grpBorrowedBooks;
        private System.Windows.Forms.ListBox lstBorrowedBooks;
        private System.Windows.Forms.GroupBox grpReturnBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.TextBox txtReturnBookId;
        private System.Windows.Forms.Label lblReturnBookId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
    }
}