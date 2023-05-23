using Library.Data;
using Library.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Books : Form
    {
        DataService service;
        Book toUpdate;
        public Books()
        {
            InitializeComponent();
            service = new DataService();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            showBooks();
            showAddBtn();
        }

        private void showAddBtn()
        {
            updateBtn.Hide();
            addBtn.Show();
        }

        private void showUpdateBtn()
        {
            updateBtn.Show();
            addBtn.Hide();
        }

        private void showBooks()
        {
            booksDataGridView.Columns.Clear();
            genreCB.Items.Clear();

            titleTB.Text = string.Empty;
            authorTB.Text = string.Empty;
            publishingHouseTB.Text = string.Empty;
            releaseYearTB.Text = string.Empty;
            priceTB.Text = string.Empty;
            genreCB.Text = string.Empty;

            foreach (Genre genre in service.GetAllGenres())
            {
                genreCB.Items.Add(genre.Name);
            }

            var books = (from b in service.GetAllBooks()
                         select new
                         {
                             b.Id,
                             b.Title,
                             b.Author,
                             b.PublishingHouse,
                             b.ReleaseYear,
                             b.Price,
                             Genre = b.Genre1.Name
                         });
            booksDataGridView.DataSource = books.ToList();
            booksDataGridView.Columns[0].Visible = false;

            booksDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Library.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });
            booksDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Library.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            try
            {
                Book book = new Book()
                {
                    Title = titleTB.Text,
                    Author = authorTB.Text,
                    PublishingHouse = publishingHouseTB.Text,
                    ReleaseYear = Convert.ToInt32(releaseYearTB.Text),
                    Price = Convert.ToDouble(priceTB.Text),
                    Genre = service.FindGenreByName(genreCB.Text)?.Id ?? throw new Exception("Genre cannot be null.")
                };

                service.AddBook(book);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                return;
            }

            showBooks();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                toUpdate.Title = titleTB.Text;
                toUpdate.Author = authorTB.Text;
                toUpdate.PublishingHouse = publishingHouseTB.Text;
                toUpdate.ReleaseYear = Convert.ToInt32(releaseYearTB.Text);
                toUpdate.Price = Convert.ToDouble(priceTB.Text);
                toUpdate.Genre = service.FindGenreByName(genreCB.Text)?.Id ?? throw new Exception("Genre cannot be null.");

                service.UpdateBook(toUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showAddBtn();
            showBooks();
        }

        private void booksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (booksDataGridView.Columns[e.ColumnIndex].Name.Equals("delete"))
            {
                try
                {
                    service.DeleteBook(service.FindBookById((int)booksDataGridView.Rows[e.RowIndex].Cells[0].Value).Id);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                showBooks();
            }

            if (booksDataGridView.Columns[e.ColumnIndex].Name.Equals("update")) 
            {
                toUpdate = service.FindBookById((int)booksDataGridView.Rows[e.RowIndex].Cells[0].Value);

                titleTB.Text = toUpdate.Title;
                authorTB.Text = toUpdate.Author;
                publishingHouseTB.Text = toUpdate.PublishingHouse;
                releaseYearTB.Text = toUpdate.ReleaseYear.ToString();
                priceTB.Text = toUpdate.Price.ToString();
                genreCB.Text = toUpdate.Genre1.Name;

                showUpdateBtn();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
