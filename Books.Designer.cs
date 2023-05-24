namespace Library
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publishingHouseTB = new System.Windows.Forms.TextBox();
            this.publishingHouseLabel = new System.Windows.Forms.Label();
            this.releaseYearTB = new System.Windows.Forms.TextBox();
            this.releaseYearLabel = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreCB = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(315, 0);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowHeadersWidth = 51;
            this.booksDataGridView.RowTemplate.Height = 24;
            this.booksDataGridView.Size = new System.Drawing.Size(487, 451);
            this.booksDataGridView.TabIndex = 0;
            this.booksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellClick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Location = new System.Drawing.Point(12, 108);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 16);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(133, 105);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(141, 22);
            this.titleTB.TabIndex = 2;
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(133, 137);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(141, 22);
            this.authorTB.TabIndex = 4;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Location = new System.Drawing.Point(12, 140);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(48, 16);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Author:";
            // 
            // publishingHouseTB
            // 
            this.publishingHouseTB.Location = new System.Drawing.Point(133, 169);
            this.publishingHouseTB.Name = "publishingHouseTB";
            this.publishingHouseTB.Size = new System.Drawing.Size(141, 22);
            this.publishingHouseTB.TabIndex = 6;
            // 
            // publishingHouseLabel
            // 
            this.publishingHouseLabel.AutoSize = true;
            this.publishingHouseLabel.Location = new System.Drawing.Point(12, 172);
            this.publishingHouseLabel.Name = "publishingHouseLabel";
            this.publishingHouseLabel.Size = new System.Drawing.Size(115, 16);
            this.publishingHouseLabel.TabIndex = 5;
            this.publishingHouseLabel.Text = "Publishing House:";
            // 
            // releaseYearTB
            // 
            this.releaseYearTB.Location = new System.Drawing.Point(133, 205);
            this.releaseYearTB.Name = "releaseYearTB";
            this.releaseYearTB.Size = new System.Drawing.Size(141, 22);
            this.releaseYearTB.TabIndex = 8;
            // 
            // releaseYearLabel
            // 
            this.releaseYearLabel.AutoSize = true;
            this.releaseYearLabel.Location = new System.Drawing.Point(12, 208);
            this.releaseYearLabel.Name = "releaseYearLabel";
            this.releaseYearLabel.Size = new System.Drawing.Size(94, 16);
            this.releaseYearLabel.TabIndex = 7;
            this.releaseYearLabel.Text = "Release Year:";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(133, 238);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(141, 22);
            this.priceTB.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 241);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 16);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(12, 277);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(47, 16);
            this.genreLabel.TabIndex = 11;
            this.genreLabel.Text = "Genre:";
            // 
            // genreCB
            // 
            this.genreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Location = new System.Drawing.Point(133, 274);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(141, 24);
            this.genreCB.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(166, 320);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 42);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(166, 320);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(108, 42);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 608);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.publishingHouseLabel);
            this.Controls.Add(this.releaseYearLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.releaseYearTB);
            this.Controls.Add(this.publishingHouseTB);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox publishingHouseTB;
        private System.Windows.Forms.Label publishingHouseLabel;
        private System.Windows.Forms.TextBox releaseYearTB;
        private System.Windows.Forms.Label releaseYearLabel;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreCB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}