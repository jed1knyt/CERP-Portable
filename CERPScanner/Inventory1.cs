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
    public partial class Inventory1 : Form
    {
        public Inventory1(Form _parent)
        {
            InitializeComponent();
            this.Owner = _parent;
        }

        private void Inventory1_Load(object sender, EventArgs e)
        {
            lblItemCode.Text = CERPInventory.ItemCode;
            lblItemDesc.Text = CERPInventory.ItemDesc;

            CERPWS.Service1 svc = new CERPWS.Service1();
            string result = svc.GetWarehouseInventory(CERPInventory.ItemID);

            StringReader sr = new StringReader(result);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("table");
            ds.ReadXml(sr);
            dt = ds.Tables[0];
            if (dt.Rows[0].ItemArray[0].ToString() == "0")
            {
                MessageBox.Show(dt.Rows[0].ItemArray[1].ToString());
                CERPInventory.Qty = 0;
                lblQty.Text = CERPInventory.Qty.ToString();
                lblUOM.Text = "";

                CERPInventory.OutOfStock = true;
            }
            else
            {
                CERPInventory.Qty = Convert.ToDecimal(dt.Rows[0].ItemArray[0].ToString());
                CERPInventory.UOM = dt.Rows[0].ItemArray[1].ToString();
                lblQty.Text = CERPInventory.Qty.ToString("G29");
                lblUOM.Text = CERPInventory.UOM;

                CERPInventory.OutOfStock = false;
            }

            
            
        }
              
        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdjust_Click(object sender, EventArgs e)
        {
            Inventory2 inv = new Inventory2(this);
            if (inv.ShowDialog() == DialogResult.OK)
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}