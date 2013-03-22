namespace CERPScanner
{
    partial class Inventory2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory2));
            this.lblItemCode = new System.Windows.Forms.Label();
            this.tbInvoice = new System.Windows.Forms.TextBox();
            this.lblInvTrack = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatLot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProdLot = new System.Windows.Forms.TextBox();
            this.pbProdLot = new System.Windows.Forms.PictureBox();
            this.pbInvoice = new System.Windows.Forms.PictureBox();
            this.pbMatLot = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // lblItemCode
            // 
            this.lblItemCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblItemCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblItemCode.ForeColor = System.Drawing.Color.Maroon;
            this.lblItemCode.Location = new System.Drawing.Point(0, 6);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(238, 25);
            this.lblItemCode.Text = "I T E M C O D E";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbInvoice
            // 
            this.tbInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbInvoice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.tbInvoice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbInvoice.Location = new System.Drawing.Point(74, 97);
            this.tbInvoice.Name = "tbInvoice";
            this.tbInvoice.Size = new System.Drawing.Size(121, 26);
            this.tbInvoice.TabIndex = 3;
            // 
            // lblInvTrack
            // 
            this.lblInvTrack.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblInvTrack.Location = new System.Drawing.Point(10, 99);
            this.lblInvTrack.Name = "lblInvTrack";
            this.lblInvTrack.Size = new System.Drawing.Size(60, 26);
            this.lblInvTrack.Text = "Invoice";
            this.lblInvTrack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboType.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.cboType.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cboType.Items.Add("INPUT");
            this.cboType.Items.Add("OUTPUT");
            this.cboType.Location = new System.Drawing.Point(74, 36);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 29);
            this.cboType.TabIndex = 2;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.Text = "Mat\'l Lot";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbMatLot
            // 
            this.tbMatLot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbMatLot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.tbMatLot.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbMatLot.Location = new System.Drawing.Point(74, 126);
            this.tbMatLot.Name = "tbMatLot";
            this.tbMatLot.Size = new System.Drawing.Size(121, 26);
            this.tbMatLot.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(66, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.Text = "CANCEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbCancel
            // 
            this.pbCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbCancel.Image")));
            this.pbCancel.Location = new System.Drawing.Point(74, 156);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(32, 32);
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(123, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.Text = "NEXT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbNext
            // 
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(132, 156);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(32, 32);
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.Text = "Prod Lot";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbProdLot
            // 
            this.tbProdLot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbProdLot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.tbProdLot.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbProdLot.Location = new System.Drawing.Point(74, 68);
            this.tbProdLot.Name = "tbProdLot";
            this.tbProdLot.Size = new System.Drawing.Size(121, 26);
            this.tbProdLot.TabIndex = 19;
            // 
            // pbProdLot
            // 
            this.pbProdLot.Image = ((System.Drawing.Image)(resources.GetObject("pbProdLot.Image")));
            this.pbProdLot.Location = new System.Drawing.Point(198, 68);
            this.pbProdLot.Name = "pbProdLot";
            this.pbProdLot.Size = new System.Drawing.Size(24, 24);
            this.pbProdLot.Click += new System.EventHandler(this.pbProdLot_Click);
            // 
            // pbInvoice
            // 
            this.pbInvoice.Image = ((System.Drawing.Image)(resources.GetObject("pbInvoice.Image")));
            this.pbInvoice.Location = new System.Drawing.Point(198, 98);
            this.pbInvoice.Name = "pbInvoice";
            this.pbInvoice.Size = new System.Drawing.Size(24, 24);
            this.pbInvoice.Click += new System.EventHandler(this.pbInvoice_Click);
            // 
            // pbMatLot
            // 
            this.pbMatLot.Image = ((System.Drawing.Image)(resources.GetObject("pbMatLot.Image")));
            this.pbMatLot.Location = new System.Drawing.Point(198, 127);
            this.pbMatLot.Name = "pbMatLot";
            this.pbMatLot.Size = new System.Drawing.Size(24, 24);
            this.pbMatLot.Click += new System.EventHandler(this.pbMatLot_Click);
            // 
            // Inventory2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.ControlBox = false;
            this.Controls.Add(this.pbMatLot);
            this.Controls.Add(this.pbInvoice);
            this.Controls.Add(this.pbProdLot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProdLot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInvTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMatLot);
            this.Controls.Add(this.tbInvoice);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblItemCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory2";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox tbInvoice;
        private System.Windows.Forms.Label lblInvTrack;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatLot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProdLot;
        private System.Windows.Forms.PictureBox pbProdLot;
        private System.Windows.Forms.PictureBox pbInvoice;
        private System.Windows.Forms.PictureBox pbMatLot;
    }
}