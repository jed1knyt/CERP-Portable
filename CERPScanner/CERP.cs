using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;

namespace CERPScanner
{
    #region Configurations
    public static class CERPConfig
    {
        public static string WSUrl
        {
            //TODO: Dynamic IP settings
            get { return "http://192.168.1.250/cerpws/Service1.asmx"; }
        }    

        public static string AppPath
        {
            get { return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase); }
        }

        public static string DBConString
        {
            get { return "Data Source="+ AppPath +"\\cerpdb.sdf;Persist Security Info=True; Password="; }
        }

        private static int GetSettings(string setting)
        {
            if (!File.Exists(AppPath + "\\settings.txt"))
            {
                using (StreamWriter sw = File.CreateText(AppPath + "\\settings.txt"))
                {
                    sw.WriteLine("DEVICEID=0");
                    sw.WriteLine("TERMINALDEVICEID=0");
                }
            }

            int result=0;
            int line=0;
            switch (setting)
            { 
                case "DEVICEID":
                    line = 1; break;
                case "TERMINALDEVICEID":
                    line = 2; break;
            }
            using (var sr = new System.IO.StreamReader(AppPath + "\\settings.txt"))
            {
                string sline = "";
                for (int i = 1; i <= line; i++)
                    sline = sr.ReadLine();
                    
                result = Convert.ToInt16(sline.Substring(sline.IndexOf("=") + 1));
            }

            return result;
        }

        public static int SetSettings(string setting, int value)
        {
            int result = 0;
            return result;
        }

        private static int iTerminalID;
        public static int TerminalID
        {
            get { return iTerminalID; }
            set { iTerminalID = value; }
        }

        private static int iDeviceID;
        public static int DeviceID
        {
            get { return CERPConfig.GetSettings("DEVICEID"); }
            set { iDeviceID = value; }
        }

        private static int iTerminalDeviceID;
        public static int TerminalDeviceID
        {
            get { return CERPConfig.GetSettings("TERMINALDEVICEID"); }
            set { iTerminalDeviceID = value; }
        }

        private static int iUserID;
        public static int UserID
        {
            get { return iUserID; }
            set { iUserID = value; }
        }

    }
    #endregion

    #region Tools

    // USAGE: CERPTools.IsNullOrValue(value, 0)
    public static class CERPTools
    {
        public static bool IsNullOrValue(this double? value, double valueToCheck)
        {
            return (value ?? valueToCheck) == valueToCheck;
        }
    }
    #endregion

    #region Inventory
    public static class CERPInventory
    {
        private static string sBarCode;
        public static string BarCode
        {
            get { return sBarCode; }
            set { sBarCode = value; }
        }

        private static int iItemID;
        public static int ItemID
        {
            get { return iItemID; }
            set { iItemID = value; }
        }

        private static string sItemCode;
        public static string ItemCode
        {
            get { return sItemCode; }
            set { sItemCode = value; }
        }

        private static string sItemDesc;
        public static string ItemDesc
        {
            get { return sItemDesc; }
            set { sItemDesc = value; }
        }

        private static decimal dQty;
        public static decimal Qty
        {
            get { return dQty; }
            set { dQty = value; }
        }

        private static string sUOM;
        public static string UOM
        {
            get { return sUOM; }
            set { sUOM = value; }
        }

        private static string sScanType;
        public static string ScanType
        {
            get { return sScanType; }
            set { sScanType = value; }
        }

        private static string sItemType;
        public static string ItemType
        {
            get { return sItemType; }
            set { sItemType = value; }
        }

        private static string sInvoice;
        public static string Invoice
        {
            get { return sInvoice; }
            set { sInvoice = value; }
        }

        private static string sMatLot;
        public static string MatLot
        {
            get { return sMatLot; }
            set { sMatLot = value; }
        }

        private static string sProdLot;
        public static string ProdLot
        {
            get { return sProdLot; }
            set { sProdLot = value; }
        }

        private static string sInOut;
        public static string InOut
        {
            get { return sInOut; }
            set { sInOut = value; }
        }

        private static int iProdTerminal;
        public static int ProdTerminal
        {
            get { return iProdTerminal; }
            set { iProdTerminal = value; }
        }

        private static bool bOutOfStock;
        public static bool OutOfStock
        {
            get { return bOutOfStock; }
            set { bOutOfStock = value; }
        }

        public static void ClearAll()
        {
            BarCode = null;
            ItemID = -1;
            ItemCode = null;
            ItemDesc = null;
            OutOfStock = false;
            Qty = -1;
            UOM = null;
            ScanType = null;
            ItemType = null;
            Invoice = null;
            MatLot = null;
            ProdLot = null;
            InOut = null;
            ProdTerminal = -1;
            OutOfStock = false;
        }
    }
    #endregion
}
