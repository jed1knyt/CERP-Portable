namespace CERPScanner
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.pbDetails = new System.Windows.Forms.PictureBox();
            this.pbInventory = new System.Windows.Forms.PictureBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // lblBarCode
            // 
            this.lblBarCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBarCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblBarCode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBarCode.Location = new System.Drawing.Point(0, 6);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(238, 25);
            this.lblBarCode.Text = "B A R C O D E";
            this.lblBarCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemCode
            // 
            this.lblItemCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblItemCode.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.lblItemCode.ForeColor = System.Drawing.Color.Maroon;
            this.lblItemCode.Location = new System.Drawing.Point(0, 36);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(238, 33);
            this.lblItemCode.Text = "I T E M C O D E";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblItemDesc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblItemDesc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblItemDesc.Location = new System.Drawing.Point(0, 74);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(238, 62);
            this.lblItemDesc.Text = "DESCRIPTION";
            this.lblItemDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbDetails
            // 
            this.pbDetails.Image = ((System.Drawing.Image)(resources.GetObject("pbDetails.Image")));
            this.pbDetails.Location = new System.Drawing.Point(76, 148);
            this.pbDetails.Name = "pbDetails";
            this.pbDetails.Size = new System.Drawing.Size(32, 32);
            this.pbDetails.Click += new System.EventHandler(this.pbDetails_Click);
            // 
            // pbInventory
            // 
            this.pbInventory.Image = ((System.Drawing.Image)(resources.GetObject("pbInventory.Image")));
            this.pbInventory.Location = new System.Drawing.Point(130, 148);
            this.pbInventory.Name = "pbInventory";
            this.pbInventory.Size = new System.Drawing.Size(32, 32);
            this.pbInventory.Click += new System.EventHandler(this.pbInventory_Click);
            // 
            // pbSettings
            // 
            this.pbSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbSettings.Image")));
            this.pbSettings.Location = new System.Drawing.Point(184, 148);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(32, 32);
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(184, 206);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(32, 32);
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(71, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.Text = "DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(116, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.Text = "INVENTORY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(178, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.Text = "CONFIG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(180, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.Text = "LOGOUT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(17, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.Text = "CLEAR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbClear
            // 
            this.pbClear.Image = ((System.Drawing.Image)(resources.GetObject("pbClear.Image")));
            this.pbClear.Location = new System.Drawing.Point(22, 148);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(32, 32);
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.pbInventory);
            this.Controls.Add(this.pbDetails);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.lblBarCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "CERP W/H Scanner v1.0";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Home_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.PictureBox pbDetails;
        private System.Windows.Forms.PictureBox pbInventory;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbClear;
    }
}