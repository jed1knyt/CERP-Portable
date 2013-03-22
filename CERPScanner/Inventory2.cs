using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CERPScanner
{
    public partial class Inventory2 : Form
    {
        public Inventory2(Form _parent)
        {
            InitializeComponent();
            this.Owner = _parent;
        }

        private void Inventory2_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            lblItemCode.Text = CERPInventory.ItemCode;
        }
             

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                lblInvTrack.Text = "Invoice";
                tbProdLot.Enabled = false;
                tbProdLot.Text = "N/A";
            }
            else
            {
                lblInvTrack.Text = "Tracking";
                tbProdLot.Enabled = true;
                tbProdLot.Text = "";
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            //((DataRowView)cboType.SelectedValue).Row.ItemArray[0].ToString()
            CERPInventory.ScanType = cboType.SelectedItem.ToString();
            if (cboType.SelectedItem.ToString() == "INPUT")
            {
                CERPInventory.Invoice = tbInvoice.Text.Trim();
                CERPInventory.MatLot = tbMatLot.Text.Trim();
                CERPConfig.TerminalID = 1;
            }
            else
            {
                CERPInventory.Invoice = tbInvoice.Text.Trim();
                CERPInventory.ProdLot = tbProdLot.Text.Trim();
                CERPInventory.MatLot = tbMatLot.Text.Trim();
                CERPConfig.TerminalID = 2;
            }

            Inventory3 inv = new Inventory3(this);
            if (inv.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pbProdLot_Click(object sender, EventArgs e)
        {
            Scanner scan = new Scanner("Scan Production Lot Number.");
            if (scan.ShowDialog() == DialogResult.OK)
            {
                CERPInventory.ProdLot = scan.tbBarcode.Text;
                tbProdLot.Text = CERPInventory.ProdLot;
            }
        }

        private void pbInvoice_Click(object sender, EventArgs e)
        {
            Scanner scan = new Scanner("Scan Invoice Number.");
            if (scan.ShowDialog() == DialogResult.OK)
            {
                CERPInventory.Invoice = scan.tbBarcode.Text;
                tbInvoice.Text = CERPInventory.Invoice;
            }
        }

        private void pbMatLot_Click(object sender, EventArgs e)
        {
            Scanner scan = new Scanner("Scan Material Lot Number.");
            if (scan.ShowDialog() == DialogResult.OK)
            {
                CERPInventory.MatLot = scan.tbBarcode.Text;
                tbMatLot.Text = CERPInventory.MatLot;
            }
        }
    }


}