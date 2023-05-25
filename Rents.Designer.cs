namespace Library
{
    partial class Rents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rents));
            this.rentsDataGridView = new System.Windows.Forms.DataGridView();
            this.bookLabel = new System.Windows.Forms.Label();
            this.bookCB = new System.Windows.Forms.ComboBox();
            this.readerCB = new System.Windows.Forms.ComboBox();
            this.readerLabel = new System.Windows.Forms.Label();
            this.rentDateLabel = new System.Windows.Forms.Label();
            this.rentDateTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rentsDataGridView
            // 
            this.rentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentsDataGridView.Location = new System.Drawing.Point(238, -2);
            this.rentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentsDataGridView.Name = "rentsDataGridView";
            this.rentsDataGridView.RowHeadersWidth = 51;
            this.rentsDataGridView.RowTemplate.Height = 24;
            this.rentsDataGridView.Size = new System.Drawing.Size(361, 372);
            this.rentsDataGridView.TabIndex = 0;
            this.rentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentsDataGridView_CellClick);
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookLabel.Location = new System.Drawing.Point(22, 36);
            this.bookLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(35, 13);
            this.bookLabel.TabIndex = 19;
            this.bookLabel.Text = "Book:";
            // 
            // bookCB
            // 
            this.bookCB.FormattingEnabled = true;
            this.bookCB.Location = new System.Drawing.Point(117, 33);
            this.bookCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookCB.Name = "bookCB";
            this.bookCB.Size = new System.Drawing.Size(107, 21);
            this.bookCB.TabIndex = 21;
            // 
            // readerCB
            // 
            this.readerCB.FormattingEnabled = true;
            this.readerCB.Location = new System.Drawing.Point(117, 63);
            this.readerCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readerCB.Name = "readerCB";
            this.readerCB.Size = new System.Drawing.Size(107, 21);
            this.readerCB.TabIndex = 23;
            // 
            // readerLabel
            // 
            this.readerLabel.AutoSize = true;
            this.readerLabel.BackColor = System.Drawing.Color.Transparent;
            this.readerLabel.Location = new System.Drawing.Point(22, 65);
            this.readerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readerLabel.Name = "readerLabel";
            this.readerLabel.Size = new System.Drawing.Size(45, 13);
            this.readerLabel.TabIndex = 22;
            this.readerLabel.Text = "Reader:";
            // 
            // rentDateLabel
            // 
            this.rentDateLabel.AutoSize = true;
            this.rentDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.rentDateLabel.Location = new System.Drawing.Point(22, 98);
            this.rentDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rentDateLabel.Name = "rentDateLabel";
            this.rentDateLabel.Size = new System.Drawing.Size(59, 13);
            this.rentDateLabel.TabIndex = 24;
            this.rentDateLabel.Text = "Rent Date:";
            // 
            // rentDateTB
            // 
            this.rentDateTB.Location = new System.Drawing.Point(117, 95);
            this.rentDateTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentDateTB.Name = "rentDateTB";
            this.rentDateTB.Size = new System.Drawing.Size(107, 20);
            this.rentDateTB.TabIndex = 25;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(142, 133);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(81, 34);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(142, 133);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(81, 34);
            this.updateBtn.TabIndex = 27;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 387);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.rentDateTB);
            this.Controls.Add(this.readerCB);
            this.Controls.Add(this.bookCB);
            this.Controls.Add(this.rentDateLabel);
            this.Controls.Add(this.readerLabel);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.rentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Rents";
            this.Text = "Rents";
            this.Load += new System.EventHandler(this.Rents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentsDataGridView;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.ComboBox bookCB;
        private System.Windows.Forms.ComboBox readerCB;
        private System.Windows.Forms.Label readerLabel;
        private System.Windows.Forms.Label rentDateLabel;
        private System.Windows.Forms.TextBox rentDateTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}