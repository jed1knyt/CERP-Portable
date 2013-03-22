using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BCD.net;

namespace CERPScanner
{
    public partial class Home : Form
    {
        private bool has_item = false;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //TODO: Check wifi
        }

        private void Home_Closing(object sender, CancelEventArgs e)
        {

        }

        private int GetItemDetails()
        {
            int ret = 0;
            lblBarCode.Text = CERPInventory.BarCode;

            CERPWS.Service1 svc = new CERPWS.Service1();
            //string result = svc.GetItemIDCode(CERPInventory.BarCode);
            string result = svc.GetItemDetails(CERPInventory.BarCode);

            StringReader sr = new StringReader(result);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("table");
            ds.ReadXml(sr);
            dt = ds.Tables[0];



            if (dt.Rows[0].ItemArray[0].ToString() == "0")
            {
                MessageBox.Show(dt.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                CERPInventory.ItemID = Convert.ToInt16(dt.Rows[0].ItemArray[0]);
                CERPInventory.ItemCode = dt.Rows[0].ItemArray[1].ToString();
                CERPInventory.ItemDesc = dt.Rows[0].ItemArray[2].ToString();
                CERPInventory.ItemType = "MAT"; //TODO: AUTOMATE
                CERPInventory.ProdTerminal = Convert.ToInt16(dt.Rows[0].ItemArray[3]);
                lblItemCode.Text = CERPInventory.ItemCode;
                lblItemDesc.Text = CERPInventory.ItemDesc;
                ret = 1;
            }
            return ret;
        }      

        private void pbLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // TODO: Log User Audit Trail
                this.Close();
            }
        }

        private void pbInventory_Click(object sender, EventArgs e)
        {
            if (!has_item)
            {
                //MessageBox.Show("No item was scanned yet.");
                Scanner scan = new Scanner("Scan Item Barcode");
                if (scan.ShowDialog() == DialogResult.OK)
                {
                    CERPInventory.BarCode = scan.tbBarcode.Text;
                    if (GetItemDetails() > 0)
                    {
                        has_item = true;

                        Inventory1 inv = new Inventory1(this);
                        inv.ShowDialog();
                    }
                }
            }
            else
            {
                Inventory1 inv = new Inventory1(this);
                inv.ShowDialog();
            }   
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {

        }

        private void pbDetails_Click(object sender, EventArgs e)
        {
            if (!has_item)
            {
                MessageBox.Show("No item was scanned yet.");
                Scanner scan = new Scanner("Scan Item Barcode");
                if (scan.ShowDialog() == DialogResult.OK)
                {
                    CERPInventory.BarCode = scan.tbBarcode.Text;
                    if (GetItemDetails() > 0)
                    {
                        has_item = true;

                        Details det = new Details();
                        det.ShowDialog();
                    }
                }
            }
            else
            {
                Details det = new Details();
                det.ShowDialog();
            } 
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            lblBarCode.Text = "B A R C O D E";
            lblItemCode.Text = "I T E M C O D E";
            lblItemDesc.Text = "DESCRIPTION";

            CERPInventory.ClearAll();

            has_item = false;
        }

    }
}