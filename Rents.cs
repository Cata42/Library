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
    public partial class Rents : Form
    {
        DataService service;
        Rent toUpdate;
        public Rents()
        {
            InitializeComponent();
            service = new DataService();
            toUpdate = new Rent();
        }

        private void Rents_Load(object sender, EventArgs e)
        {
            showRents();
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

        private void showRents()
        {
            rentsDataGridView.Columns.Clear();
            bookCB.Items.Clear();
            readerCB.Items.Clear();

            foreach(Book book in service.GetAllBooks())
            {
                bookCB.Items.Add(book.Id);
            }

            foreach(Reader reader in service.GetAllReaders())
            {
                readerCB.Items.Add(reader.Id);
            }

            bookCB.Text = string.Empty;
            readerCB.Text = string.Empty;
            rentDateTB.Text = string.Empty;

            var rents = (from r in service.GetAllRents()
                         select new
                         {
                             r.Id,
                             Book = r.Book1.Title + " by " + r.Book1.Author,
                             Reader = r.Reader1.Name + " " + r.Reader1.Id,
                             ReaderPhoneNumber = r.Reader1.PhoneNumber,
                             r.RentDate,
                             MustBeReturnedBefore = r.ExpectedReturnDate,
                             r.ReturnDate
                         });
            rentsDataGridView.DataSource = rents.ToList();
            rentsDataGridView.Columns[0].Visible = false;

            rentsDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Library.Properties.Resources._return,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Return",
                Name = "return"
            });
            rentsDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Library.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });
            rentsDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Library.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private DateTime calculateExpectedReturnDate(DateTime rentDate)
        {
            return rentDate.AddDays(14);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Rent rent = new Rent()
                {
                    Book = Convert.ToInt32(bookCB.Text),
                    Reader = Convert.ToInt32(readerCB.Text),
                    RentDate = DateTime.Parse(rentDateTB.Text),
                    ExpectedReturnDate = calculateExpectedReturnDate(DateTime.Parse(rentDateTB.Text)),
                    ReturnDate = null
                };

                service.AddRent(rent);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showRents();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                toUpdate.Book = Convert.ToInt32(bookCB.Text);
                toUpdate.Reader = Convert.ToInt32(readerCB.Text);
                toUpdate.RentDate = DateTime.Parse(rentDateTB.Text);
                toUpdate.ExpectedReturnDate = calculateExpectedReturnDate(DateTime.Parse(rentDateTB.Text));
                service.UpdateRent(toUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showAddBtn();
            showRents();
        }

        private void rentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rentsDataGridView.Columns[e.ColumnIndex].Name.Equals("return"))
            {
                try
                {
                    toUpdate = service.FindRentById((int)rentsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                    toUpdate.ReturnDate = DateTime.Now;
                    service.UpdateRent(toUpdate);
                    showRents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (rentsDataGridView.Columns[e.ColumnIndex].Name.Equals("delete"))
            {
                try
                {
                    service.DeleteRent(service.FindRentById((int)rentsDataGridView.Rows[e.RowIndex].Cells[0].Value).Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                showRents();
            }

            if (rentsDataGridView.Columns[e.ColumnIndex].Name.Equals("update"))
            {
                toUpdate = service.FindRentById((int)rentsDataGridView.Rows[e.RowIndex].Cells[0].Value);

                bookCB.Text = toUpdate.Book.ToString();
                readerCB.Text = toUpdate.Reader.ToString();
                rentDateTB.Text = toUpdate.RentDate.ToString();

                showUpdateBtn();
            }
        }
    }
}
