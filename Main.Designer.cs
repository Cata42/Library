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
            this.tezeapa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // booksBtn
            // 
            this.booksBtn.Location = new System.Drawing.Point(165, 321);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(143, 101);
            this.booksBtn.TabIndex = 0;
            this.booksBtn.Text = "Books";
            this.booksBtn.UseVisualStyleBackColor = true;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click);
            // 
            // readersBtn
            // 
            this.readersBtn.Location = new System.Drawing.Point(438, 321);
            this.readersBtn.Name = "readersBtn";
            this.readersBtn.Size = new System.Drawing.Size(143, 101);
            this.readersBtn.TabIndex = 1;
            this.readersBtn.Text = "Readers";
            this.readersBtn.UseVisualStyleBackColor = true;
            this.readersBtn.Click += new System.EventHandler(this.readersBtn_Click);
            // 
            // rentBtn
            // 
            this.rentBtn.Location = new System.Drawing.Point(301, 12);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(143, 330);
            this.rentBtn.TabIndex = 2;
            this.rentBtn.Text = "Rent";
            this.rentBtn.UseVisualStyleBackColor = true;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // tezeapa
            // 
            this.tezeapa.AutoSize = true;
            this.tezeapa.Location = new System.Drawing.Point(474, 52);
            this.tezeapa.Name = "tezeapa";
            this.tezeapa.Size = new System.Drawing.Size(215, 16);
            this.tezeapa.TabIndex = 3;
            this.tezeapa.Text = "Tzeapa! Ce? N-ai mai luat tzeapa?!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.readersBtn);
            this.Controls.Add(this.booksBtn);
            this.Controls.Add(this.tezeapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Button readersBtn;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Label tezeapa;
    }
}

