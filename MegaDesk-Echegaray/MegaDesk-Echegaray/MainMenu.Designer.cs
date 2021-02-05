
namespace MegaDesk_Echegaray
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuote.Location = new System.Drawing.Point(68, 66);
            this.btnAddNewQuote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(116, 40);
            this.btnAddNewQuote.TabIndex = 0;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(68, 122);
            this.btnViewQuotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(116, 40);
            this.btnViewQuotes.TabIndex = 1;
            this.btnViewQuotes.Text = "&View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = true;
            this.btnViewQuotes.Click += new System.EventHandler(this.btnViewQuotes_Click);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(68, 178);
            this.btnSearchQuotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(116, 40);
            this.btnSearchQuotes.TabIndex = 2;
            this.btnSearchQuotes.Text = "&Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = true;
            this.btnSearchQuotes.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(68, 235);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "MEGADESK";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnAddNewQuote);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuote;
        private System.Windows.Forms.Button btnViewQuotes;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

