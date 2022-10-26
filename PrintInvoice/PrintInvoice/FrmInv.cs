using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintInvoice
{
    public partial class FrmInv : Form
    {
        public FrmInv()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/romio.hashad.3/");
        }

        private void FrmInv_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                Dictionary<int, string> itemsData = new Dictionary<int, string>() {
                [16000] = "لاب توب DELL",
                [17000] = "لاب توب HP",
                [15500] = "لاب توب سامسونج",
                [150] = "كيبورد عادى",
                [80] = "ماوس عادى",
                [250] = "كيبورد DELL",
                [120] = "ماوس DELL",
                [280] = "كيبورد HP",
                [130]="ماوس HP",
                [950]="طابعه حبر HP",
                [1650]="طابعه ليزر HP",
                [400]="راوتر انترنت"
            };

            cbxItem.DataSource = new BindingSource(itemsData,null);
            cbxItem.DisplayMember = "Value";
            cbxItem.ValueMember = "Key";
            txtPrice.Text = cbxItem.SelectedValue.ToString();

            foreach(DataGridViewColumn col in DgvInv.Columns)
            {
                col.DefaultCellStyle.ForeColor = Color.Navy;
            }
            DgvInv.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            DgvInv.Columns[3].DefaultCellStyle.ForeColor = Color.DarkGreen;

            txtCustName.Focus();
            txtCustName.Select();
        }
        private void Prevent_ContextMenu(TextBox txt,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txt.ContextMenu = new ContextMenu();
            }
        }

        private void Prevent_Keys(TextBox txt, KeyPressEventArgs e)
        {
            if (txt == txtDate)
                e.Handled = true;
            else if (txt == txtInvNum||txt==txtQty)
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar))) { e.Handled = true; };
        }
        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Prevent_Keys((TextBox)sender, e);

        }

        private void txtDate_MouseDown(object sender, MouseEventArgs e)
        {
            Prevent_ContextMenu((TextBox)sender, e);
        }


        private void GoTo(Control ctrl,KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ctrl.Focus();
            }
        }

        private void txtCustName_KeyDown(object sender, KeyEventArgs e)
        {
            GoTo(cbxItem, e);
        }

        private void cbxItem_KeyDown(object sender, KeyEventArgs e)
        {
            GoTo(txtQty, e);
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAddItem.PerformClick();
                txtCustName.Focus();
            }
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cbxItem.SelectedIndex <= -1) return;

            string item = cbxItem.Text;
            int qty = Convert.ToInt32( txtQty.Text);
            int price = Convert.ToInt32(txtPrice.Text);
            int subtotal = qty * price;
            txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + subtotal)+"";
            object[] alldata = { item,qty, price, subtotal };
            DgvInv.Rows.Add(alldata);
        }

        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = cbxItem.SelectedValue.ToString();
        }


        string oldValue = "";
        private void DgvInv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(DgvInv.CurrentRow!=null)
            {
                oldValue = DgvInv.CurrentRow.Cells[1].Value.ToString();
            }
        }
        string newValue = "";
        private void DgvInv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(DgvInv.CurrentRow!=null)
            {
                newValue = DgvInv.CurrentRow.Cells[1].Value.ToString();
                if (newValue == oldValue) return;
                if(!Regex.IsMatch(newValue,"^\\d+$"))
                {
                    DgvInv.CurrentRow.Cells[1].Value = oldValue;
                }
                else
                {
                    int subNewTotal = 0;
                    DgvInv.CurrentRow.Cells[1].Value = newValue;
                    int p =(int)DgvInv.CurrentRow.Cells[2].Value;
                    int q = Convert.ToInt32(newValue);
                    DgvInv.CurrentRow.Cells[3].Value = p * q;
                    foreach(DataGridViewRow r in DgvInv.Rows)
                    {
                        subNewTotal += (int)r.Cells[3].Value;
                    }
                    txtTotal.Text = subNewTotal.ToString();
                }
            }
        }
        private void Change_Font(FontStyle fs)
        {
            Font f = new Font("Microsoft Sans Serif", 18, fs);
            label2.Font = f;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Change_Font(FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Change_Font(FontStyle.Bold);
        }
        int m = -1;
        private void btnPrintInv_Click(object sender, EventArgs e)
        {
            m = -1; 
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            m++;
            float margin = 40;
            Font f = new Font("Arial", 18, FontStyle.Bold);


            string strInvNum = "#NO " + txtInvNum.Text;
            string strDate = "التاريخ: " + txtDate.Text;
            string strCustName = "مطلوب من السيد: " + txtCustName.Text;

            SizeF InvNumSize = e.Graphics.MeasureString(strInvNum, f);
            SizeF DateSize = e.Graphics.MeasureString(strDate, f);
            SizeF CustNameSize = e.Graphics.MeasureString(strCustName, f);

            e.Graphics.DrawString(strInvNum, f, Brushes.Red, (e.PageBounds.Width - InvNumSize.Width) / 2, margin);
            e.Graphics.DrawString(strDate, f, Brushes.Black, e.PageBounds.Width - DateSize.Width - margin, margin + InvNumSize.Height);
            e.Graphics.DrawString(strCustName, f, Brushes.Black, e.PageBounds.Width - CustNameSize.Width - margin, margin + InvNumSize.Height + DateSize.Height);
            e.Graphics.DrawImage(Properties.Resources._1591187049492, 5, 5, 200, 200);

            float preHeights = margin + InvNumSize.Height + DateSize.Height + CustNameSize.Height + 70;
            e.Graphics.DrawRectangle(Pens.Black, margin / 2, preHeights, e.PageBounds.Width - margin, e.PageBounds.Height - preHeights - margin / 2);

            float colHeight = 50;

            float col1width = 300;
            float col2width = 125 + col1width;
            float col3width = 125 + col2width;
            float col4width = 250 + col3width;

            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin / 2, preHeights + colHeight, margin / 2, preHeights + colHeight);

            e.Graphics.DrawString("الصنف", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col1width + 120, preHeights + colHeight - 40);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - (margin / 2) - col1width, preHeights, e.PageBounds.Width - (margin / 2) - col1width, e.PageBounds.Height - (margin) / 2);

            e.Graphics.DrawString("الكميه", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col2width + 40, preHeights + colHeight - 40);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - (margin / 2) - col2width, preHeights, e.PageBounds.Width - (margin / 2) - col2width, e.PageBounds.Height - (margin) / 2);

            e.Graphics.DrawString("سعر الوحده", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col3width + 15, preHeights + colHeight - 40);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - (margin / 2) - col3width, preHeights, e.PageBounds.Width - (margin / 2) - col3width, e.PageBounds.Height - (margin / 2));

            e.Graphics.DrawString("الاجمالى الفرعى", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col3width - 200, preHeights + colHeight - 40);
            //////////////Fill Invioce in Print Page

            float rowHeight = 50;
           
            for (; m < DgvInv.Rows.Count; m++)
            {
                    e.Graphics.DrawString(DgvInv.Rows[m].Cells[0].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - (margin / 2) - col1width, preHeights + rowHeight + colHeight - 30);
                    e.Graphics.DrawString(DgvInv.Rows[m].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col2width, preHeights + colHeight + rowHeight - 30);
                    e.Graphics.DrawString(DgvInv.Rows[m].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col3width, preHeights + colHeight + rowHeight - 30);
                    e.Graphics.DrawString(DgvInv.Rows[m].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col4width, preHeights + colHeight + rowHeight - 30);

                    e.Graphics.DrawLine(Pens.Black, margin / 2, preHeights + colHeight + rowHeight, e.PageBounds.Width - (margin / 2), preHeights + colHeight + rowHeight);

                    rowHeight += 50;

                if (rowHeight == e.PageBounds.Height - 300)
                {
                    e.HasMorePages = true;
                    break;
                }

            }
            if (rowHeight < e.PageBounds.Height - 300)
            {
                e.Graphics.DrawString("الاجمالى", f, Brushes.Red, e.PageBounds.Width - (margin / 2) - col3width, preHeights + colHeight + rowHeight - 30);
                e.Graphics.DrawString(txtTotal.Text, f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col4width, preHeights + colHeight + rowHeight - 30);
            }

            ////////////Print More Pages

        }

        private void DgvInv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DgvInv.Rows.Count < 1)
                txtTotal.Text = "0";
            if (DgvInv.Rows.Count >= 1)
            {
                int itotal = 0;
                foreach (DataGridViewRow r in DgvInv.Rows)
                {
                    itotal += (int)r.Cells[3].Value;
                }
                txtTotal.Text = itotal.ToString();
            }
        }
    }
}
