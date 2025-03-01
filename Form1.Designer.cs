namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnShowBooks = new Button();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDeleteBook = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(191, 66);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 27);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(191, 99);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(191, 165);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(125, 29);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(350, 66);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(371, 204);
            listBoxBooks.TabIndex = 3;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(191, 200);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(125, 29);
            btnShowBooks.TabIndex = 4;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click_1;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(191, 132);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 11;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(191, 235);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(125, 29);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 69);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 7;
            label1.Text = "Author name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 102);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 8;
            label2.Text = "Book title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 135);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 9;
            label3.Text = "Book ID:";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(191, 270);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(125, 29);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteBook);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(btnShowBooks);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnShowBooks;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDeleteBook;
    }
}