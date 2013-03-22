namespace CERPScanner
{
    partial class Inventory1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory1));
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbAdjust = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblQty.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.lblQty.ForeColor = System.Drawing.Color.DimGray;
            this.lblQty.Location = new System.Drawing.Point(0, 36);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(238, 33);
            this.lblQty.Text = "00000000";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUOM
            // 
            this.lblUOM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblUOM.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUOM.Location = new System.Drawing.Point(0, 74);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(238, 20);
            this.lblUOM.Text = "UOM";
            this.lblUOM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblItemDesc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblItemDesc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblItemDesc.Location = new System.Drawing.Point(0, 99);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(238, 51);
            this.lblItemDesc.Text = "DESCRIPTION";
            this.lblItemDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(74, 158);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(32, 32);
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbAdjust
            // 
            this.pbAdjust.Image = ((System.Drawing.Image)(resources.GetObject("pbAdjust.Image")));
            this.pbAdjust.Location = new System.Drawing.Point(132, 158);
            this.pbAdjust.Name = "pbAdjust";
            this.pbAdjust.Size = new System.Drawing.Size(32, 32);
            this.pbAdjust.Click += new System.EventHandler(this.pbAdjust_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(69, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.Text = "HOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(127, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.Text = "ADJUST";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Inventory1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAdjust);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblItemCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbAdjust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}