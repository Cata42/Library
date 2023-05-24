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
    public partial class Readers : Form
    {
        DataService service;
        Reader toUpdate;
        public Readers()
        {
            InitializeComponent();
            service = new DataService();
            toUpdate = new Reader();
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            showReaders();
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

        private void showReaders()
        {
            readersDataGridView.Columns.Clear();

            nameTB.Text = string.Empty;
            addressTB.Text = string.Empty;
            phoneNumberTB.Text = string.Empty;

            var readers = (from r in service.GetAllReaders()
                         select new
                         {
                             r.Id,
                             r.Name,
                             r.Address,
                             r.PhoneNumber
                         });
            readersDataGridView.DataSource = readers.ToList();
            readersDataGridView.Columns[0].Visible = false;

            readersDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Library.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });
            readersDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Library.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void readersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (readersDataGridView.Columns[e.ColumnIndex].Name.Equals("delete"))
            {
                try
                {
                    service.DeleteReader(service.FindReaderById((int)readersDataGridView.Rows[e.RowIndex].Cells[0].Value).Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                showReaders();
            }

            if (readersDataGridView.Columns[e.ColumnIndex].Name.Equals("update"))
            {
                toUpdate = service.FindReaderById((int)readersDataGridView.Rows[e.RowIndex].Cells[0].Value);

                nameTB.Text = toUpdate.Name;
                addressTB.Text = toUpdate.Address;
                phoneNumberTB.Text = toUpdate.PhoneNumber;

                showUpdateBtn();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Reader book = new Reader()
                {
                    Name = nameTB.Text,
                    Address = addressTB.Text,
                    PhoneNumber = phoneNumberTB.Text
                };

                service.AddReader(book);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showReaders();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                toUpdate.Name = nameTB.Text;
                toUpdate.Address = addressTB.Text;
                toUpdate.PhoneNumber = phoneNumberTB.Text;

                service.UpdateReader(toUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showAddBtn();
            showReaders();
        }

        private void phoneNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit (0-9) or the Backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Cancel the keypress event
                e.Handled = true;
            }
        }

        private void phoneNumberTB_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Remove any non-digit characters from the textbox text
            string digitsOnly = new string(textBox.Text.Where(char.IsDigit).ToArray());

            // Update the textbox text with the cleaned up string
            textBox.Text = digitsOnly;

            // Check if the remaining text has a length less than 9
            if (digitsOnly.Length < 9 || digitsOnly.Length > 9)
            {
                // Set the textbox's background color to indicate an error
                textBox.ForeColor = Color.Red;
            }
            else
            {
                // Set the textbox's background color back to default
                textBox.ForeColor = Color.Black;
            }
        }
    }
}
