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
            this.rentsDataGridView = new System.Windows.Forms.DataGridView();
            this.bookLabel = new System.Windows.Forms.Label();
            this.bookCB = new System.Windows.Forms.ComboBox();
            this.readerCB = new System.Windows.Forms.ComboBox();
            this.readerLabel = new System.Windows.Forms.Label();
            this.rentDateLabel = new System.Windows.Forms.Label();
            this.rentDateTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rentsDataGridView
            // 
            this.rentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentsDataGridView.Location = new System.Drawing.Point(318, 12);
            this.rentsDataGridView.Name = "rentsDataGridView";
            this.rentsDataGridView.RowHeadersWidth = 51;
            this.rentsDataGridView.RowTemplate.Height = 24;
            this.rentsDataGridView.Size = new System.Drawing.Size(470, 426);
            this.rentsDataGridView.TabIndex = 0;
            this.rentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentsDataGridView_CellClick);
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookLabel.Location = new System.Drawing.Point(30, 44);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(42, 16);
            this.bookLabel.TabIndex = 19;
            this.bookLabel.Text = "Book:";
            // 
            // bookCB
            // 
            this.bookCB.FormattingEnabled = true;
            this.bookCB.Location = new System.Drawing.Point(156, 41);
            this.bookCB.Name = "bookCB";
            this.bookCB.Size = new System.Drawing.Size(141, 24);
            this.bookCB.TabIndex = 21;
            // 
            // readerCB
            // 
            this.readerCB.FormattingEnabled = true;
            this.readerCB.Location = new System.Drawing.Point(156, 77);
            this.readerCB.Name = "readerCB";
            this.readerCB.Size = new System.Drawing.Size(141, 24);
            this.readerCB.TabIndex = 23;
            // 
            // readerLabel
            // 
            this.readerLabel.AutoSize = true;
            this.readerLabel.BackColor = System.Drawing.Color.Transparent;
            this.readerLabel.Location = new System.Drawing.Point(30, 80);
            this.readerLabel.Name = "readerLabel";
            this.readerLabel.Size = new System.Drawing.Size(56, 16);
            this.readerLabel.TabIndex = 22;
            this.readerLabel.Text = "Reader:";
            // 
            // rentDateLabel
            // 
            this.rentDateLabel.AutoSize = true;
            this.rentDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.rentDateLabel.Location = new System.Drawing.Point(30, 120);
            this.rentDateLabel.Name = "rentDateLabel";
            this.rentDateLabel.Size = new System.Drawing.Size(70, 16);
            this.rentDateLabel.TabIndex = 24;
            this.rentDateLabel.Text = "Rent Date:";
            // 
            // rentDateTB
            // 
            this.rentDateTB.Location = new System.Drawing.Point(156, 117);
            this.rentDateTB.Name = "rentDateTB";
            this.rentDateTB.Size = new System.Drawing.Size(141, 22);
            this.rentDateTB.TabIndex = 25;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(189, 164);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 42);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(189, 164);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(108, 42);
            this.updateBtn.TabIndex = 27;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.rentDateLabel);
            this.Controls.Add(this.rentDateTB);
            this.Controls.Add(this.readerCB);
            this.Controls.Add(this.readerLabel);
            this.Controls.Add(this.bookCB);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.rentsDataGridView);
            this.Name = "Rents";
            this.Text = "Rents";
            this.Load += new System.EventHandler(this.Rents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).EndInit();
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
    }
}