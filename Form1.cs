using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }
        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                // Create a new author
                var author = new Author { Name = authorName };

                // Create a new book and associate it with the author
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);  // Add the author to the context
                context.Books.Add(book);      // Add the book to the context
                context.SaveChanges();        // Save all changes to the database
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Select(b => $"[ID: {b.BookID}] {b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Retrieve input from text boxes (adjust names based on your form's controls)
            string authorName = txtAuthorName.Text;    // Assume TextBox for author is named txtAuthor
            string bookTitle = txtBookTitle.Text;      // Assume TextBox for title is named txtTitle

            // Validate input
            if (string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(bookTitle))
            {
                MessageBox.Show("Please enter both the author's name and the book title.");
                return;
            }

            try
            {
                // Add the author and book to the database
                AddAuthorWithBook(authorName, bookTitle);
                MessageBox.Show("Book added successfully!");

                // Optional: Clear the input fields after adding
                txtAuthorName.Clear();
                txtBookTitle.Clear();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Error: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage);
            }
        }

        private void btnShowBooks_Click_1(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;  // Display the list of books in the ListBox
        }

        public bool UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books
                    .Include(b => b.Author)
                    .FirstOrDefault(b => b.BookID == bookId);

                if (book == null) return false;

                book.Title = newTitle;
                book.Author.Name = newAuthorName;
                return context.SaveChanges() > 0;
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            try
            {
                bool updated = UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
                if (updated)
                {
                    MessageBox.Show("Book updated successfully!");
                    // Refresh the list
                    var updatedBooks = GetBooksWithAuthors();
                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = updatedBooks;
                }
                else
                {
                    MessageBox.Show("No book found with ID: " + bookId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Delete Book
        public bool DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book == null) return false;

                context.Books.Remove(book);
                return context.SaveChanges() > 0; // Returns true if 1+ rows affected
            }
        }

        //Search Book by Authors
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            try
            {
                bool deleted = DeleteBook(bookId);
                if (deleted)
                {
                    MessageBox.Show("Book deleted successfully!");
                    // Force refresh the list
                    var updatedBooks = GetBooksWithAuthors();
                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = updatedBooks;
                }
                else
                {
                    MessageBox.Show("No book found with ID: " + bookId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }
    }
}
