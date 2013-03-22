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
    public partial class Scanner : Form
    {
        #region  BCD Library
        MsgWindow MsgWin;
        const byte SCAN_MESSAGE = 0x1A;
        const byte SCAN_KEYDOWN = 0x1B;
        const byte SCAN_KEYUP = 0x1C;
        const byte SCAN_GOTBARCODE = 0x1D;

        public CBScanner BScanner = new CBScanner();
        public bool bContMode;   //K04232009++
        //private int buzzer_pb_ms;

        private void InitPara()
        {
            //this.BScanner.BarcodeScanSE955();
            this.BScanner.StartBarcodeScan();
            this.BScanner.InitBarcode();
        }

        private void DeInitPara()
        {
            this.BScanner.CloseBarcode();
            this.BScanner.StopBarcodeScan();
        }

        public void SendMSG(byte x)
        {
            switch (x)
            {
                case SCAN_GOTBARCODE:
                    //CERPInventory.BarCode = this.BScanner.GetBarcodeData();

                    //GetItemDetails();

                    tbBarcode.Text = this.BScanner.GetBarcodeData();
                    break;
            }
        }

        public void ReInit()
        {
            this.BScanner.InitBarcode();
        }

        #endregion

        public Scanner(string labelText)
        {
            InitializeComponent();
            this.MsgWin = new MsgWindow(this);
            lblScan.Text = labelText;
        }

        private void Scanner_Load(object sender, EventArgs e)
        {
            InitPara();
            bContMode = false;  //K04232009++   
        }

        private void Scanner_Closing(object sender, CancelEventArgs e)
        {
            DeInitPara();
            this.MsgWin.Dispose();  //C05212009++
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbBarcode.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            tbBarcode.Text = "";
        }
    }
}