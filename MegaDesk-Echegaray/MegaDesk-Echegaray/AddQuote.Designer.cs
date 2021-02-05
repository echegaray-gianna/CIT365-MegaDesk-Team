
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
            this.btnAddQuoteClose.Location = new System.Drawing.Point(95, 512);
            this.btnAddQuoteClose.Name = "btnAddQuoteClose";
            this.btnAddQuoteClose.Size = new System.Drawing.Size(206, 47);
            this.btnAddQuoteClose.TabIndex = 0;
            this.btnAddQuoteClose.Text = "Close";
            this.btnAddQuoteClose.UseVisualStyleBackColor = true;
            this.btnAddQuoteClose.Click += new System.EventHandler(this.btnAddQuoteClose_Click);
            // 
            // btnAddQuoteSbt
            // 
            this.btnAddQuoteSbt.Location = new System.Drawing.Point(440, 512);
            this.btnAddQuoteSbt.Name = "btnAddQuoteSbt";
            this.btnAddQuoteSbt.Size = new System.Drawing.Size(206, 47);
            this.btnAddQuoteSbt.TabIndex = 1;
            this.btnAddQuoteSbt.Text = "Submit";
            this.btnAddQuoteSbt.UseVisualStyleBackColor = true;
            this.btnAddQuoteSbt.Click += new System.EventHandler(this.btnAddQuoteSbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(222, 98);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(340, 26);
            this.customerName.TabIndex = 3;
            // 
            // InputWidth
            // 
            this.InputWidth.Location = new System.Drawing.Point(222, 162);
            this.InputWidth.Name = "InputWidth";
            this.InputWidth.Size = new System.Drawing.Size(113, 26);
            this.InputWidth.TabIndex = 5;
            this.InputWidth.Validating += new System.ComponentModel.CancelEventHandler(this.InputWidth_Validating);
            // 
            // dWidth
            // 
            this.dWidth.AutoSize = true;
            this.dWidth.Location = new System.Drawing.Point(24, 168);
            this.dWidth.Name = "dWidth";
            this.dWidth.Size = new System.Drawing.Size(166, 20);
            this.dWidth.TabIndex = 4;
            this.dWidth.Text = "Desk Width (24- 96 in)";
            this.dWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputDepth
            // 
            this.InputDepth.Location = new System.Drawing.Point(222, 221);
            this.InputDepth.Name = "InputDepth";
            this.InputDepth.Size = new System.Drawing.Size(113, 26);
            this.InputDepth.TabIndex = 7;
            this.InputDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputDepth_KeyPress);
            this.InputDepth.Validated += new System.EventHandler(this.InputDepth_Validated);
            // 
            // dDepth
            // 
            this.dDepth.AutoSize = true;
            this.dDepth.Location = new System.Drawing.Point(12, 224);
            this.dDepth.Name = "dDepth";
            this.dDepth.Size = new System.Drawing.Size(173, 20);
            this.dDepth.TabIndex = 6;
            this.dDepth.Text = "Desk Depth (12 - 48 in)";
            this.dDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Drawers
            // 
            this.Drawers.AutoSize = true;
            this.Drawers.Location = new System.Drawing.Point(66, 282);
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(68, 20);
            this.Drawers.TabIndex = 8;
            this.Drawers.Text = "Drawers";
            this.Drawers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DrawersNumber
            // 
            this.DrawersNumber.Location = new System.Drawing.Point(222, 282);
            this.DrawersNumber.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawersNumber.Name = "DrawersNumber";
            this.DrawersNumber.Size = new System.Drawing.Size(113, 26);
            this.DrawersNumber.TabIndex = 9;
            // 
            // dMaterial
            // 
            this.dMaterial.AutoSize = true;
            this.dMaterial.Location = new System.Drawing.Point(66, 349);
            this.dMaterial.Name = "dMaterial";
            this.dMaterial.Size = new System.Drawing.Size(65, 20);
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
            this.DesktopMaterial.Location = new System.Drawing.Point(222, 349);
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.Size = new System.Drawing.Size(189, 28);
            this.DesktopMaterial.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 40);
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
            this.shippingDays.Location = new System.Drawing.Point(222, 421);
            this.shippingDays.Name = "shippingDays";
            this.shippingDays.Size = new System.Drawing.Size(198, 28);
            this.shippingDays.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Days";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Location = new System.Drawing.Point(284, 37);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(41, 20);
            this.currentDate.TabIndex = 17;
            this.currentDate.Text = "date";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
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