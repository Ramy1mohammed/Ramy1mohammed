namespace PrintInvoice
{
    partial class FrmInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInv));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvNum = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvInv = new System.Windows.Forms.DataGridView();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnPrintInv = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "شاشه الفاتوره";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(271, 85);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(605, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "https://www.facebook.com/romio.hashad.3/";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم الفاتوره:";
            // 
            // txtInvNum
            // 
            this.txtInvNum.ForeColor = System.Drawing.Color.Red;
            this.txtInvNum.Location = new System.Drawing.Point(155, 132);
            this.txtInvNum.Name = "txtInvNum";
            this.txtInvNum.Size = new System.Drawing.Size(459, 38);
            this.txtInvNum.TabIndex = 3;
            this.txtInvNum.Text = "00000123";
            this.txtInvNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            // 
            // txtDate
            // 
            this.txtDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDate.Location = new System.Drawing.Point(777, 132);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(299, 38);
            this.txtDate.TabIndex = 5;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            this.txtDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDate_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "التاريخ:";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.ForeColor = System.Drawing.Color.Black;
            this.txtCustName.Location = new System.Drawing.Point(155, 187);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(921, 41);
            this.txtCustName.TabIndex = 7;
            this.txtCustName.Text = "الاسم";
            this.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "اسم الزبون:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1343, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintInvoice.Properties.Resources._1591187049492;
            this.pictureBox1.Location = new System.Drawing.Point(1131, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "الصنف:";
            // 
            // cbxItem
            // 
            this.cbxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(155, 276);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(715, 39);
            this.cbxItem.TabIndex = 11;
            this.cbxItem.SelectedIndexChanged += new System.EventHandler(this.cbxItem_SelectedIndexChanged);
            this.cbxItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxItem_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "السعر:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(155, 333);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(320, 38);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDate_MouseDown);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.Location = new System.Drawing.Point(585, 333);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(285, 38);
            this.txtQty.TabIndex = 15;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "الكميه:";
            // 
            // DgvInv
            // 
            this.DgvInv.AllowUserToAddRows = false;
            this.DgvInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColType,
            this.ColQty,
            this.ColItemPrice,
            this.ColSubTotal});
            this.DgvInv.Location = new System.Drawing.Point(18, 391);
            this.DgvInv.Name = "DgvInv";
            this.DgvInv.RowHeadersWidth = 51;
            this.DgvInv.RowTemplate.Height = 24;
            this.DgvInv.Size = new System.Drawing.Size(1324, 351);
            this.DgvInv.TabIndex = 16;
            this.DgvInv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvInv_CellBeginEdit);
            this.DgvInv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInv_CellEndEdit);
            this.DgvInv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvInv_RowsRemoved);
            // 
            // ColType
            // 
            this.ColType.HeaderText = "الصنف";
            this.ColType.MinimumWidth = 6;
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            // 
            // ColQty
            // 
            this.ColQty.HeaderText = "الكميه";
            this.ColQty.MinimumWidth = 6;
            this.ColQty.Name = "ColQty";
            // 
            // ColItemPrice
            // 
            this.ColItemPrice.HeaderText = "سعر الوحده";
            this.ColItemPrice.MinimumWidth = 6;
            this.ColItemPrice.Name = "ColItemPrice";
            this.ColItemPrice.ReadOnly = true;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "الاجمالى الفرعى";
            this.ColSubTotal.MinimumWidth = 6;
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(917, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 36);
            this.label10.TabIndex = 17;
            this.label10.Text = "￬الاجمالى￬";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.DarkViolet;
            this.txtTotal.ForeColor = System.Drawing.Color.Yellow;
            this.txtTotal.Location = new System.Drawing.Point(886, 333);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(189, 38);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDate_MouseDown);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddItem.Location = new System.Drawing.Point(1082, 279);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 98);
            this.btnAddItem.TabIndex = 19;
            this.btnAddItem.Text = "اضافه";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnPrintInv
            // 
            this.btnPrintInv.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrintInv.Location = new System.Drawing.Point(1222, 279);
            this.btnPrintInv.Name = "btnPrintInv";
            this.btnPrintInv.Size = new System.Drawing.Size(120, 98);
            this.btnPrintInv.TabIndex = 20;
            this.btnPrintInv.Text = "طباعه";
            this.btnPrintInv.UseVisualStyleBackColor = false;
            this.btnPrintInv.Click += new System.EventHandler(this.btnPrintInv_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 754);
            this.Controls.Add(this.btnPrintInv);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvInv);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmInv";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvNum;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgvInv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnPrintInv;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
    }
}

