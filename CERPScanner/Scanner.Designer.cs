namespace CERPScanner
{
    partial class Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblScan = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBarcode
            // 
            this.tbBarcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbBarcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.tbBarcode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbBarcode.Location = new System.Drawing.Point(3, 32);
            this.tbBarcode.Multiline = true;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(192, 26);
            this.tbBarcode.TabIndex = 2;
            this.tbBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(135, 63);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 30);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblScan
            // 
            this.lblScan.Location = new System.Drawing.Point(3, 9);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(192, 20);
            this.lblScan.Text = "LABEL";
            this.lblScan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(69, 63);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(60, 30);
            this.btnRescan.TabIndex = 3;
            this.btnRescan.Text = "Clear";
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(198, 105);
            this.ControlBox = false;
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblScan);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbBarcode);
            this.Location = new System.Drawing.Point(20, 60);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Scanner_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Scanner_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRescan;

    }
}