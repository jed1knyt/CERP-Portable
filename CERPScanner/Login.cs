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
    public partial class Login : Form
    {
        string last_user = @"\last_user.txt";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(CERPConfig.AppPath + last_user))
            {
                using (StreamReader sr = File.OpenText(CERPConfig.AppPath + last_user))
                {
                    tbEmpID.Text = sr.ReadLine(); 
                    cbRemember.Checked = true;
                    tbPwd.Focus();
                }
            }

            // TODO CheckConnectivity function
            // TODO CheckWiFi
            // TODO Enable/Disable Beep
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmpID.Text.Trim() != "" && tbPwd.Text.Trim() != "")
            {
                RememberMe(tbEmpID.Text.Trim());

                CERPWS.Service1 svc = new CERPWS.Service1();
                StringReader sr = new StringReader(svc.Login(tbEmpID.Text, tbPwd.Text));
                DataSet ds = new DataSet();
                DataTable dt = new DataTable("table");
                ds.ReadXml(sr);
                dt = ds.Tables[0];

                if (Convert.ToInt32(dt.Rows[0].ItemArray[0]) == 0)
                {
                    MessageBox.Show(dt.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    //int id = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                    //string first_name = dt.Rows[0].ItemArray[1].ToString();
                    //string last_name = dt.Rows[0].ItemArray[2].ToString();
                    //int role = Convert.ToInt32(dt.Rows[0].ItemArray[3].ToString());

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void RememberMe(string name)
        {
            if (cbRemember.Checked && tbEmpID.Text != "")
            {
                if (File.Exists(CERPConfig.AppPath + last_user))
                {
                    File.Delete(CERPConfig.AppPath + last_user);
                }
                using (StreamWriter sw = File.CreateText(CERPConfig.AppPath + last_user))
                {
                    sw.WriteLine(name.Trim());
                }
            }
        }

    }
}