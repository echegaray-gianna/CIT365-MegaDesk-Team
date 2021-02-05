
namespace MegaDesk_Echegaray
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.btnAddQuoteClose = new System.Windows.Forms.Button();
            this.btnAddQuoteSbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.InputWidth = new System.Windows.Forms.TextBox();
            this.dWidth = new System.Windows.Forms.Label();
            this.InputDepth = new System.Windows.Forms.TextBox();
            this.dDepth = new System.Windows.Forms.Label();
            this.Drawers = new System.Windows.Forms.Label();
            this.DrawersNumber = new System.Windows.Forms.NumericUpDown();
            this.dMaterial = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DesktopMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shippingDays = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddQuoteClose
            // 
            this.btnAddQuoteClose.Location = new System.Drawing.Point(320, 316);
            this.btnAddQuoteClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddQuoteClose.Name = "btnAddQuoteClose";
            this.btnAddQuoteClose.Size = new System.Drawing.Size(137, 31);
            this.btnAddQuoteClose.TabIndex = 0;
            this.btnAddQuoteClose.Text = "Close";
            this.btnAddQuoteClose.UseVisualStyleBackColor = true;
            this.btnAddQuoteClose.Click += new System.EventHandler(this.btnAddQuoteClose_Click);
            // 
            // btnAddQuoteSbt
            // 
            this.btnAddQuoteSbt.Location = new System.Drawing.Point(148, 316);
            this.btnAddQuoteSbt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddQuoteSbt.Name = "btnAddQuoteSbt";
            this.btnAddQuoteSbt.Size = new System.Drawing.Size(137, 31);
            this.btnAddQuoteSbt.TabIndex = 1;
            this.btnAddQuoteSbt.Text = "Submit";
            this.btnAddQuoteSbt.UseVisualStyleBackColor = true;
            this.btnAddQuoteSbt.Click += new System.EventHandler(this.btnAddQuoteSbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(148, 64);
            this.customerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(228, 20);
            this.customerName.TabIndex = 3;
            // 
            // InputWidth
            // 
            this.InputWidth.Location = new System.Drawing.Point(148, 105);
            this.InputWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputWidth.Name = "InputWidth";
            this.InputWidth.Size = new System.Drawing.Size(77, 20);
            this.InputWidth.TabIndex = 5;
            this.InputWidth.Validating += new System.ComponentModel.CancelEventHandler(this.InputWidth_Validating);
            // 
            // dWidth
            // 
            this.dWidth.AutoSize = true;
            this.dWidth.Location = new System.Drawing.Point(16, 109);
            this.dWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dWidth.Name = "dWidth";
            this.dWidth.Size = new System.Drawing.Size(113, 13);
            this.dWidth.TabIndex = 4;
            this.dWidth.Text = "Desk Width (24- 96 in)";
            this.dWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputDepth
            // 
            this.InputDepth.Location = new System.Drawing.Point(148, 144);
            this.InputDepth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputDepth.Name = "InputDepth";
            this.InputDepth.Size = new System.Drawing.Size(77, 20);
            this.InputDepth.TabIndex = 7;
            this.InputDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputDepth_KeyPress);
            this.InputDepth.Validated += new System.EventHandler(this.InputDepth_Validated);
            // 
            // dDepth
            // 
            this.dDepth.AutoSize = true;
            this.dDepth.Location = new System.Drawing.Point(8, 146);
            this.dDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dDepth.Name = "dDepth";
            this.dDepth.Size = new System.Drawing.Size(117, 13);
            this.dDepth.TabIndex = 6;
            this.dDepth.Text = "Desk Depth (12 - 48 in)";
            this.dDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Drawers
            // 
            this.Drawers.AutoSize = true;
            this.Drawers.Location = new System.Drawing.Point(44, 183);
            this.Drawers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(46, 13);
            this.Drawers.TabIndex = 8;
            this.Drawers.Text = "Drawers";
            this.Drawers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DrawersNumber
            // 
            this.DrawersNumber.Location = new System.Drawing.Point(148, 183);
            this.DrawersNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DrawersNumber.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawersNumber.Name = "DrawersNumber";
            this.DrawersNumber.Size = new System.Drawing.Size(75, 20);
            this.DrawersNumber.TabIndex = 9;
            this.DrawersNumber.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // dMaterial
            // 
            this.dMaterial.AutoSize = true;
            this.dMaterial.Location = new System.Drawing.Point(44, 227);
            this.dMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dMaterial.Name = "dMaterial";
            this.dMaterial.Size = new System.Drawing.Size(44, 13);
            this.dMaterial.TabIndex = 10;
            this.dMaterial.Text = "Material";
            this.dMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DesktopMaterial
            // 
            this.DesktopMaterial.AllowDrop = true;
            this.DesktopMaterial.FormattingEnabled = true;
            this.DesktopMaterial.Location = new System.Drawing.Point(148, 227);
            this.DesktopMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.Size = new System.Drawing.Size(127, 21);
            this.DesktopMaterial.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rush Order \r\nOptions";
            // 
            // shippingDays
            // 
            this.shippingDays.FormattingEnabled = true;
            this.shippingDays.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.shippingDays.Location = new System.Drawing.Point(148, 274);
            this.shippingDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shippingDays.Name = "shippingDays";
            this.shippingDays.Size = new System.Drawing.Size(133, 21);
            this.shippingDays.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Days";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Location = new System.Drawing.Point(189, 24);
            this.currentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(159, 13);
            this.currentDate.TabIndex = 17;
            this.currentDate.Text = "Please complete the blank fields";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 385);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shippingDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DesktopMaterial);
            this.Controls.Add(this.dMaterial);
            this.Controls.Add(this.DrawersNumber);
            this.Controls.Add(this.Drawers);
            this.Controls.Add(this.InputDepth);
            this.Controls.Add(this.dDepth);
            this.Controls.Add(this.InputWidth);
            this.Controls.Add(this.dWidth);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddQuoteSbt);
            this.Controls.Add(this.btnAddQuoteClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuoteClose;
        private System.Windows.Forms.Button btnAddQuoteSbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox InputWidth;
        private System.Windows.Forms.Label dWidth;
        private System.Windows.Forms.TextBox InputDepth;
        private System.Windows.Forms.Label dDepth;
        private System.Windows.Forms.Label Drawers;
        private System.Windows.Forms.NumericUpDown DrawersNumber;
        private System.Windows.Forms.Label dMaterial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox DesktopMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shippingDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentDate;
    }
}