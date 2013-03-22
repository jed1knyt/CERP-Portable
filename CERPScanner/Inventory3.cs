using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CERPScanner
{
    public partial class Inventory3 : Form
    {
        public Inventory3(Form _parent)
        {
            InitializeComponent();
            this.Owner = _parent;
        }

        private void Inventory3_Load(object sender, EventArgs e)
        {
            lblItemCode.Text = CERPInventory.ItemCode;
            lblUOM.Text = CERPInventory.UOM;
            tbQty.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }

        // increment tbQty value
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tbQty.Text == "")
            {
                tbQty.Text = "1";
            }
            else
            {
                tbQty.Text = (Convert.ToDecimal(tbQty.Text) + 1).ToString();
            }            
        }

        // decrement tbQty value
        private void btnDn_Click(object sender, EventArgs e)
        {
            if (tbQty.Text == "")
            {
                tbQty.Text = "1";
            }
            else
            {
                if (tbQty.Text != "0")
                {
                    tbQty.Text = (Convert.ToDecimal(tbQty.Text) - 1).ToString();
                }
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDone_Click(object sender, EventArgs e)
        {
            if (tbQty.Text != "" || tbQty.Text != "0")
            {
                if (CERPInventory.ScanType == "OUTPUT" && (Convert.ToDecimal(tbQty.Text.Trim()) > CERPInventory.Qty))
                {
                    MessageBox.Show("There is not enough stock in warehouse.");
                    tbQty.Focus();
                }
                else
                {
                    CERPWS.Service1 svc = new CERPWS.Service1();
                    string result = svc.AdjustWarehouseInventory(CERPInventory.ScanType,
                                                                            CERPInventory.ItemID,
                                                                            CERPInventory.ItemType,
                                                                            CERPInventory.Invoice,
                                                                            CERPInventory.ProdLot,
                                                                            CERPInventory.MatLot,
                                                                            CERPConfig.TerminalID,
                                                                            CERPConfig.TerminalDeviceID,
                                                                            148, //TODO: set status
                                                                            Convert.ToDecimal(tbQty.Text.Trim()),
                                                                            tbRemarks.Text.Trim(),
                                                                            CERPInventory.ProdTerminal);
                    StringReader sr = new StringReader(result);
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("table");
                    ds.ReadXml(sr);
                    dt = ds.Tables[0];

                    if (Convert.ToInt16(dt.Rows[0].ItemArray[0].ToString()) > 0)
                    {
                        MessageBox.Show("Adjusted");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dt.Rows[0].ItemArray[1].ToString());
                    }
                }
            }
        }
    }
}