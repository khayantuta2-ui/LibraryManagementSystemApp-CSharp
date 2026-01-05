namespace LibraryManagementSystem
{
    partial class LibrarianForm
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
            this.grpAddBook = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.grpAddMember = new System.Windows.Forms.GroupBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberPassword = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.lblSearchBooks = new System.Windows.Forms.Label();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpAddBook.SuspendLayout();
            this.grpAddMember.SuspendLayout();
            this.grpBooks.SuspendLayout();
            this.grpMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(280, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Librarian Dashboard";
            // 
            // grpAddBook
            // 
            this.grpAddBook.Controls.Add(this.btnAddBook);
            this.grpAddBook.Controls.Add(this.txtBookAuthor);
            this.grpAddBook.Controls.Add(this.txtBookTitle);
            this.grpAddBook.Controls.Add(this.lblBookAuthor);
            this.grpAddBook.Controls.Add(this.lblBookTitle);
            this.grpAddBook.Location = new System.Drawing.Point(20, 60);
            this.grpAddBook.Name = "grpAddBook";
            this.grpAddBook.Size = new System.Drawing.Size(350, 140);
            this.grpAddBook.TabIndex = 1;
            this.grpAddBook.TabStop = false;
            this.grpAddBook.Text = "Add New Book";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(220, 95);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 25);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(100, 60);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(220, 20);
            this.txtBookAuthor.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(100, 30);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(220, 20);
            this.txtBookTitle.TabIndex = 2;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(20, 63);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblBookAuthor.TabIndex = 1;
            this.lblBookAuthor.Text = "Author:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(20, 33);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(30, 13);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Title:";
            // 
            // grpAddMember
            // 
            this.grpAddMember.Controls.Add(this.btnAddMember);
            this.grpAddMember.Controls.Add(this.txtMemberPassword);
            this.grpAddMember.Controls.Add(this.txtMemberName);
            this.grpAddMember.Controls.Add(this.lblMemberPassword);
            this.grpAddMember.Controls.Add(this.lblMemberName);
            this.grpAddMember.Location = new System.Drawing.Point(390, 60);
            this.grpAddMember.Name = "grpAddMember";
            this.grpAddMember.Size = new System.Drawing.Size(350, 140);
            this.grpAddMember.TabIndex = 2;
            this.grpAddMember.TabStop = false;
            this.grpAddMember.Text = "Add New Member";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(220, 95);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(100, 25);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.Location = new System.Drawing.Point(100, 60);
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.PasswordChar = '*';
            this.txtMemberPassword.Size = new System.Drawing.Size(220, 20);
            this.txtMemberPassword.TabIndex = 3;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(100, 30);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(220, 20);
            this.txtMemberName.TabIndex = 2;
            // 
            // lblMemberPassword
            // 
            this.lblMemberPassword.AutoSize = true;
            this.lblMemberPassword.Location = new System.Drawing.Point(20, 63);
            this.lblMemberPassword.Name = "lblMemberPassword";
            this.lblMemberPassword.Size = new System.Drawing.Size(56, 13);
            this.lblMemberPassword.TabIndex = 1;
            this.lblMemberPassword.Text = "Password:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(20, 33);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(38, 13);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Name:";
            // 
            // grpBooks
            // 
            this.grpBooks.Controls.Add(this.lstBooks);
            this.grpBooks.Controls.Add(this.btnSearchBooks);
            this.grpBooks.Controls.Add(this.txtSearchBooks);
            this.grpBooks.Controls.Add(this.lblSearchBooks);
            this.grpBooks.Location = new System.Drawing.Point(20, 220);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Size = new System.Drawing.Size(350, 280);
            this.grpBooks.TabIndex = 3;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "Books in Library";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.HorizontalScrollbar = true;
            this.lstBooks.Location = new System.Drawing.Point(20, 80);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(310, 186);
            this.lstBooks.TabIndex = 3;
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
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.lstMembers);
            this.grpMembers.Location = new System.Drawing.Point(390, 220);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(350, 280);
            this.grpMembers.TabIndex = 4;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "Registered Members";
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.HorizontalScrollbar = true;
            this.lstMembers.Location = new System.Drawing.Point(20, 30);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(310, 238);
            this.lstMembers.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(560, 520);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(660, 520);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 561);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpMembers);
            this.Controls.Add(this.grpBooks);
            this.Controls.Add(this.grpAddMember);
            this.Controls.Add(this.grpAddBook);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Librarian";
            this.grpAddBook.ResumeLayout(false);
            this.grpAddBook.PerformLayout();
            this.grpAddMember.ResumeLayout(false);
            this.grpAddMember.PerformLayout();
            this.grpBooks.ResumeLayout(false);
            this.grpBooks.PerformLayout();
            this.grpMembers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAddBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.GroupBox grpAddMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberPassword;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.Label lblSearchBooks;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
    }
}