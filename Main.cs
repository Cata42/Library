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
    public partial class Main : Form
    {
        Books books;
        Readers readers;
        Rents rents;
        public Main()
        {
            InitializeComponent();
            books = new Books();
            readers = new Readers();
            rents = new Rents();
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            books.ShowDialog();
            this.Show();
        }

        private void readersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            readers.ShowDialog();
            this.Show();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            rents.ShowDialog();
            this.Show();
        }
    }
}
