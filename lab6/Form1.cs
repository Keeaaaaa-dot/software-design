using lab6;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
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

        public async Task<List<string>> GetBooksAsync()
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = await context.Books.Include(x => x.Author)
                        .Select(x => $"{x.BookID}: {x.Title} by {x.Author.Name}")
                        .ToListAsync();

                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching books: {ex.Message}");
                return new List<string>();
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Visible = true;
                progressBar.Value = 0;
                var progress = new Progress<int>(value => progressBar.Value = value);
                var books = await GetBooksAsyncWithProgress(progress);
                listBoxBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching books: {ex.Message}");
            }
            finally
            {
                progressBar.Visible = false;
            }
        }

        private async Task<List<string>> GetBooksAsyncWithProgress(IProgress<int> progress)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = await context.Books.Include(x => x.Author).ToListAsync();
                    var result = new List<string>();
                    int count = books.Count;
                    for (int i = 0; i < count; i++)
                    {
                        result.Add($"{books[i].BookID}: {books[i].Title} by {books[i].Author.Name}");
                        progress.Report((i + 1) * 100 / count);
                        await Task.Delay(100);
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}");
                return new List<string>();
            }
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(bookTitle) || string.IsNullOrWhiteSpace(authorName))
                {
                    MessageBox.Show("Book title and author name cannot be empty.");
                    return;
                }

                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };
                    context.Authors.Add(author);
                    context.Books.Add(book);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}");
            }
        }

        private async void btnAddBook_ClickAsync(object sender, EventArgs e)
        {
            await SaveBookAsync(txtBookTitle.Text, txtAuthorName.Text);
        }

        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(newTitle) || string.IsNullOrWhiteSpace(newAuthorName))
                {
                    MessageBox.Show("New title and author name cannot be empty.");
                    return;
                }

                using (var context = new BookstoreContext())
                {
                    var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookId);
                    if (book != null)
                    {
                        book.Title = newTitle;
                        book.Author.Name = newAuthorName;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}");
            }
        }

        private async void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Invalid Book ID.");
                return;
            }
            await UpdateBookAsync(bookId, txtBookTitle.Text, txtAuthorName.Text);
        }

        public async Task DeleteBookAsync(int bookId)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var book = await context.Books.FindAsync(bookId);
                    if (book != null)
                    {
                        context.Books.Remove(book);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}");
            }
        }

        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Invalid Book ID.");
                return;
            }
            await DeleteBookAsync(bookId);
        }

        public async Task<List<string>> SearchBooksAsync(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    MessageBox.Show("Search term cannot be empty.");
                    return new List<string>();
                }

                using (var context = new BookstoreContext())
                {
                    var books = await context.Books.Include(x => x.Author)
                        .Where(x => x.Title.Contains(searchTerm))
                        .Select(x => $"{x.BookID}: {x.Title} by {x.Author.Name}")
                        .ToListAsync();
                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}");
                return new List<string>();
            }
        }

        private async void btnSearch_ClickAsync(object sender, EventArgs e)
        {
            var results = await SearchBooksAsync(txtSearch.Text);
            listBoxSearchResults.DataSource = results;
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // BLANK
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // BLANK
        }
    }
}
