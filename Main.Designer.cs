namespace Library
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.booksBtn = new System.Windows.Forms.Button();
            this.readersBtn = new System.Windows.Forms.Button();
            this.rentBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tasksBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksBtn
            // 
            this.booksBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.booksBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.booksBtn.Image = ((System.Drawing.Image)(resources.GetObject("booksBtn.Image")));
            this.booksBtn.Location = new System.Drawing.Point(217, 79);
            this.booksBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(138, 35);
            this.booksBtn.TabIndex = 0;
            this.booksBtn.Text = "Books";
            this.booksBtn.UseVisualStyleBackColor = false;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click);
            // 
            // readersBtn
            // 
            this.readersBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.readersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readersBtn.Image = ((System.Drawing.Image)(resources.GetObject("readersBtn.Image")));
            this.readersBtn.Location = new System.Drawing.Point(217, 277);
            this.readersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readersBtn.Name = "readersBtn";
            this.readersBtn.Size = new System.Drawing.Size(138, 35);
            this.readersBtn.TabIndex = 1;
            this.readersBtn.Text = "Readers";
            this.readersBtn.UseVisualStyleBackColor = true;
            this.readersBtn.Click += new System.EventHandler(this.readersBtn_Click);
            // 
            // rentBtn
            // 
            this.rentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentBtn.BackColor = System.Drawing.Color.SlateGray;
            this.rentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentBtn.Image = ((System.Drawing.Image)(resources.GetObject("rentBtn.Image")));
            this.rentBtn.Location = new System.Drawing.Point(217, 176);
            this.rentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(138, 35);
            this.rentBtn.TabIndex = 2;
            this.rentBtn.Text = "Rent";
            this.rentBtn.UseVisualStyleBackColor = false;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tasksBtn
            // 
            this.tasksBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tasksBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tasksBtn.Image = ((System.Drawing.Image)(resources.GetObject("tasksBtn.Image")));
            this.tasksBtn.Location = new System.Drawing.Point(403, 132);
            this.tasksBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tasksBtn.Name = "tasksBtn";
            this.tasksBtn.Size = new System.Drawing.Size(138, 35);
            this.tasksBtn.TabIndex = 4;
            this.tasksBtn.Text = "Tasks";
            this.tasksBtn.UseVisualStyleBackColor = true;
            this.tasksBtn.Click += new System.EventHandler(this.tasksBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tasksBtn);
            this.Controls.Add(this.readersBtn);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.booksBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Button readersBtn;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tasksBtn;
    }
}

