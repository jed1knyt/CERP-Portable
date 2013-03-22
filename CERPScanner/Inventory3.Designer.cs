namespace CERPScanner
{
    partial class Inventory3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory3));
            this.lblItemCode = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.lblUOM = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbDone = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
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
            // tbQty
            // 
            this.tbQty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQty.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.tbQty.ForeColor = System.Drawing.Color.DimGray;
            this.tbQty.Location = new System.Drawing.Point(16, 36);
            this.tbQty.MaxLength = 10;
            this.tbQty.Multiline = true;
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(160, 38);
            this.tbQty.TabIndex = 13;
            this.tbQty.Text = "0";
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(178, 36);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(44, 30);
            this.btnUp.TabIndex = 14;
            this.btnUp.Text = "+";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(178, 67);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(44, 30);
            this.btnDn.TabIndex = 15;
            this.btnDn.Text = "-";
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // lblUOM
            // 
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblUOM.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUOM.Location = new System.Drawing.Point(16, 77);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(160, 20);
            this.lblUOM.Text = "pieces";
            this.lblUOM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbRemarks
            // 
            this.tbRemarks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRemarks.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.tbRemarks.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbRemarks.Location = new System.Drawing.Point(16, 100);
            this.tbRemarks.MaxLength = 100;
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(206, 49);
            this.tbRemarks.TabIndex = 17;
            this.tbRemarks.Text = "REMARKS";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(128, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.Text = "DONE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbDone
            // 
            this.pbDone.Image = ((System.Drawing.Image)(resources.GetObject("pbDone.Image")));
            this.pbDone.Location = new System.Drawing.Point(132, 158);
            this.pbDone.Name = "pbDone";
            this.pbDone.Size = new System.Drawing.Size(32, 32);
            this.pbDone.Click += new System.EventHandler(this.pbDone_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(70, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.Text = "BACK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(74, 158);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(32, 32);
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // Inventory3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.lblItemCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory3";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBack;
    }
}