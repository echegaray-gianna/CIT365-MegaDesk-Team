
namespace MegaDesk_Echegaray
{
    partial class SearchQuotes
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
            this.btnSearchQuotesClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSearchQuotesClose
            // 
            this.btnSearchQuotesClose.Location = new System.Drawing.Point(456, 11);
            this.btnSearchQuotesClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchQuotesClose.Name = "btnSearchQuotesClose";
            this.btnSearchQuotesClose.Size = new System.Drawing.Size(66, 23);
            this.btnSearchQuotesClose.TabIndex = 0;
            this.btnSearchQuotesClose.Text = "Close";
            this.btnSearchQuotesClose.UseVisualStyleBackColor = true;
            this.btnSearchQuotesClose.Click += new System.EventHandler(this.btnSearchQuotesClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Desktop Material";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(156, 11);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(131, 21);
            this.MaterialComboBox.TabIndex = 2;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(12, 51);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(509, 225);
            this.searchListBox.TabIndex = 3;
            this.searchListBox.SelectedIndexChanged += new System.EventHandler(this.searchListBox_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchQuotesClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchQuotesClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.ListBox searchListBox;
    }
}