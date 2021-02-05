
namespace MegaDesk_Echegaray
{
    partial class ViewAllQuotes
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
            this.btnViewAllQuotesClose = new System.Windows.Forms.Button();
            this.dataGridDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewAllQuotesClose
            // 
            this.btnViewAllQuotesClose.Location = new System.Drawing.Point(51, 343);
            this.btnViewAllQuotesClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllQuotesClose.Name = "btnViewAllQuotesClose";
            this.btnViewAllQuotesClose.Size = new System.Drawing.Size(143, 44);
            this.btnViewAllQuotesClose.TabIndex = 0;
            this.btnViewAllQuotesClose.Text = "Close";
            this.btnViewAllQuotesClose.UseVisualStyleBackColor = true;
            this.btnViewAllQuotesClose.Click += new System.EventHandler(this.btnViewAllQuotesClose_Click);
            // 
            // dataGridDisplay
            // 
            this.dataGridDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplay.Location = new System.Drawing.Point(51, 12);
            this.dataGridDisplay.Name = "dataGridDisplay";
            this.dataGridDisplay.Size = new System.Drawing.Size(649, 316);
            this.dataGridDisplay.TabIndex = 1;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 437);
            this.Controls.Add(this.dataGridDisplay);
            this.Controls.Add(this.btnViewAllQuotesClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            //this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewAllQuotesClose;
        private System.Windows.Forms.DataGridView dataGridDisplay;
    }
}