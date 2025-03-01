using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        private const int pageSize = 10;
        private int currentPage = 1;

        public Form1()
        {
            InitializeComponent();
            LoadBooksOnStartupAsync(); 
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadBooksOnStartupAsync();
        }

     
        private async Task LoadBooksOnStartupAsync()
        {
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
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

      
        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                return await context.Books
                    .Include(b => b.Author)
                    .OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
            }
        }

        // Pagination - Next Page
        private async void btnNextPage_ClickAsync(object sender, EventArgs e)
        {
            currentPage++;
            await LoadBooksOnStartupAsync();
        }

        // Pagination - Previous Page
        private async void btnPreviousPage_ClickAsync(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadBooksOnStartupAsync();
            }
            else
            {
                MessageBox.Show("You are already on the first page.");
            }
        }

    
        private async void btnSearch_ClickAsync(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                var books = await SearchBooksAsync(searchTerm);
                listBoxBooks.DataSource = books;
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        public async Task<List<string>> SearchBooksAsync(string searchTerm)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    return await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(searchTerm))
                        .Select(b => $"{b.Title} by {b.Author.Name}")
                        .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}");
                return new List<string>();
            }
        }

  
        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }

        private async void btnExportBooks_ClickAsync(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully!");
            }
        }

      
        public async Task ImportBooksAsync(string filePath)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var lines = await File.ReadAllLinesAsync(filePath);

                    foreach (var line in lines)
                    {
                        var parts = line.Split(','); // Assuming CSV format: Title, Author
                        if (parts.Length == 2)
                        {
                            string title = parts[0].Trim();
                            string authorName = parts[1].Trim();

                            var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
                            if (author == null)
                            {
                                author = new Author { Name = authorName };
                                context.Authors.Add(author);
                            }

                            var book = new Book { Title = title, Author = author };
                            context.Books.Add(book);
                        }
                    }

                    await context.SaveChangesAsync();
                    MessageBox.Show("Books imported successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing books: {ex.Message}");
            }
        }

        private async void btnImportBooks_ClickAsync(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Import Book List"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                await ImportBooksAsync(filePath);
                await LoadBooksOnStartupAsync(); 
            }
        }
    }
}
