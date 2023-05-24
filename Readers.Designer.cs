namespace Library
{
    partial class Readers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readers));
            this.readersDataGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // readersDataGridView
            // 
            this.readersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersDataGridView.Location = new System.Drawing.Point(313, 5);
            this.readersDataGridView.Name = "readersDataGridView";
            this.readersDataGridView.RowHeadersWidth = 51;
            this.readersDataGridView.RowTemplate.Height = 24;
            this.readersDataGridView.Size = new System.Drawing.Size(484, 443);
            this.readersDataGridView.TabIndex = 1;
            this.readersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readersDataGridView_CellClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(184, 162);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 42);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(184, 162);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(108, 42);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(30, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(151, 53);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(141, 22);
            this.nameTB.TabIndex = 18;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Location = new System.Drawing.Point(30, 90);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(61, 16);
            this.addressLabel.TabIndex = 19;
            this.addressLabel.Text = "Address:";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(151, 87);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(141, 22);
            this.addressTB.TabIndex = 20;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Location = new System.Drawing.Point(30, 125);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(100, 16);
            this.phoneNumberLabel.TabIndex = 21;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Location = new System.Drawing.Point(151, 122);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(141, 22);
            this.phoneNumberTB.TabIndex = 22;
            this.phoneNumberTB.TextChanged += new System.EventHandler(this.phoneNumberTB_TextChanged);
            this.phoneNumberTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTB_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 443);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readersDataGridView);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.phoneNumberTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateBtn);
            this.Name = "Readers";
            this.Text = "Readers";
            this.Load += new System.EventHandler(this.Readers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView readersDataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}