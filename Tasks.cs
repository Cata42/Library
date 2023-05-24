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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tasksDataSet.BookGenre' table. You can move, or remove it, as needed.
            this.bookGenreTableAdapter.Fill(this.tasksDataSet.BookGenre);
            // TODO: This line of code loads data into the 'tasksDataSet.RentBookGenre' table. You can move, or remove it, as needed.
            this.rentBookGenreTableAdapter.Fill(this.tasksDataSet.RentBookGenre);
            // TODO: This line of code loads data into the 'tasksDataSet.ReaderRentBookGenre' table. You can move, or remove it, as needed.
            this.readerRentBookGenreTableAdapter.Fill(this.tasksDataSet.ReaderRentBookGenre);

            this.reportViewer1.RefreshReport();
        }

        private void task2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.readerRentBookGenreTableAdapter.task2(this.tasksDataSet.ReaderRentBookGenre, readerToolStripTextBox.Text, minDateToolStripTextBox.Text, maxDateToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentBookGenreTableAdapter.task3(this.tasksDataSet.RentBookGenre, rentDateToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookGenreTableAdapter.task4(this.tasksDataSet.BookGenre, authorToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookGenreTableAdapter.task5(this.tasksDataSet.BookGenre, genreToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task6ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookGenreTableAdapter.task6(this.tasksDataSet.BookGenre, genreToolStripTextBox1.Text, publishingHouseToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookGenreTableAdapter.task7(this.tasksDataSet.BookGenre, publishingHouseToolStripTextBox1.Text, ((int)(System.Convert.ChangeType(releaseYearToolStripTextBox.Text, typeof(int)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task8ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.readerRentBookGenreTableAdapter.task8(this.tasksDataSet.ReaderRentBookGenre, bookToolStripTextBox.Text, genreToolStripTextBox2.Text, rentDateToolStripTextBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task9_1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentBookGenreTableAdapter.task9_1(this.tasksDataSet.RentBookGenre);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task9_2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentBookGenreTableAdapter.task9_2(this.tasksDataSet.RentBookGenre);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task10ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.readerRentBookGenreTableAdapter.task10(this.tasksDataSet.ReaderRentBookGenre);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
