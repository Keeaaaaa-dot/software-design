using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            string bookTitle = txtBookTitle.Text;

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please enter both the author name and book title.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await AddAuthorWithBookAsync(authorName, bookTitle);

            MessageBox.Show("Book and author added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the list
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = await GetBooksWithAuthorsAsync();
        }

        private async void btnShowBook_Click(object sender, EventArgs e)
        {
            var books = await GetBooksWithAuthorsAsync();
            listBoxBooks.DataSource = books;
        }

        private async void btnUpdateBook_Click_1(object sender, EventArgs e)
        {
            int bookID;
            if (!int.TryParse(txtBookID.Text, out bookID))
            {
                MessageBox.Show("Please enter a valid Book ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newBookTitle = txtBookTitle.Text.Trim();
            string newAuthorName = txtAuthorName.Text.Trim();

            if (string.IsNullOrEmpty(newBookTitle) || string.IsNullOrEmpty(newAuthorName))
            {
                MessageBox.Show("Please enter both the new book title and author name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await UpdateBookAsync(bookID, newBookTitle, newAuthorName);

            MessageBox.Show("Book and author updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the list
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = await GetBooksWithAuthorsAsync();
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int bookID;
            if (!int.TryParse(txtBookID.Text, out bookID))
            {
                MessageBox.Show("Please enter a valid Book ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await DeleteBookAsync(bookID);

            MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the list
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = await GetBooksWithAuthorsAsync();
        }

        private async void btnSearchBooksByAuthor_Click(object sender, EventArgs e)
        {
            string authorName = txtSearchAuthor.Text.Trim();
            if (string.IsNullOrEmpty(authorName))
            {
                MessageBox.Show("Please enter an author's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var booksByAuthor = await GetBooksByAuthorAsync(authorName);

            if (booksByAuthor.Count == 0)
            {
                MessageBox.Show("No books found for the given author.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listBoxBooks.DataSource = booksByAuthor;
            }
        }

        // Delete book asynchronously
        public async Task DeleteBookAsync(int bookID)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FirstOrDefaultAsync(b => b.BookID == bookID);
                if (book == null)
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        // Get books by author asynchronously
        public async Task<List<string>> GetBooksByAuthorAsync(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }

        // Update book asynchronously
        public async Task UpdateBookAsync(int bookID, string newBookTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookID);
                if (book == null)
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == newAuthorName);
                if (author == null)
                {
                    author = new Author { Name = newAuthorName };
                    await context.Authors.AddAsync(author);
                }

                book.Title = newBookTitle;
                book.Author = author;

                await context.SaveChangesAsync();
            }
        }

        // Add author with book asynchronously
        public async Task AddAuthorWithBookAsync(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    await context.Authors.AddAsync(author);
                }

                var book = new Book { Title = bookTitle, Author = author };
                await context.Books.AddAsync(book);

                await context.SaveChangesAsync();
            }
        }

        // Get all books with authors asynchronously
        public async Task<List<string>> GetBooksWithAuthorsAsync()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = await context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return booksWithAuthors;
            }
        }
    }
   
}
