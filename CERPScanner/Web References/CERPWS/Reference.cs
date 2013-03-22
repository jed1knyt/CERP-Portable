﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.4927.
// 
namespace CERPScanner.CERPWS {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://cerp.com.ph/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Service1() {
            this.Url = "http://192.168.1.250/cerpws/Service1.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/Login", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Login(string _emp_id, string _pwd) {
            object[] results = this.Invoke("Login", new object[] {
                        _emp_id,
                        _pwd});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginLogin(string _emp_id, string _pwd, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Login", new object[] {
                        _emp_id,
                        _pwd}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndLogin(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetItemIDCode", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetItemIDCode(string _bar_code) {
            object[] results = this.Invoke("GetItemIDCode", new object[] {
                        _bar_code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetItemIDCode(string _bar_code, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetItemIDCode", new object[] {
                        _bar_code}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetItemIDCode(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetItemDetails", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetItemDetails(string _bar_code) {
            object[] results = this.Invoke("GetItemDetails", new object[] {
                        _bar_code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetItemDetails(string _bar_code, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetItemDetails", new object[] {
                        _bar_code}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetItemDetails(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetItemFullDetails", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetItemFullDetails(string _bar_code) {
            object[] results = this.Invoke("GetItemFullDetails", new object[] {
                        _bar_code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetItemFullDetails(string _bar_code, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetItemFullDetails", new object[] {
                        _bar_code}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetItemFullDetails(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/HasInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool HasInventory(string _bar_code, string _item_type) {
            object[] results = this.Invoke("HasInventory", new object[] {
                        _bar_code,
                        _item_type});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginHasInventory(string _bar_code, string _item_type, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("HasInventory", new object[] {
                        _bar_code,
                        _item_type}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndHasInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/HasDuplicateWarehouseInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool HasDuplicateWarehouseInventory(int _item_id, string _item_type, string _invoice_no, string _lot_no) {
            object[] results = this.Invoke("HasDuplicateWarehouseInventory", new object[] {
                        _item_id,
                        _item_type,
                        _invoice_no,
                        _lot_no});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginHasDuplicateWarehouseInventory(int _item_id, string _item_type, string _invoice_no, string _lot_no, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("HasDuplicateWarehouseInventory", new object[] {
                        _item_id,
                        _item_type,
                        _invoice_no,
                        _lot_no}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndHasDuplicateWarehouseInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetMaterials", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetMaterials() {
            object[] results = this.Invoke("GetMaterials", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMaterials(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMaterials", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGetMaterials(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetWarehouseInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetWarehouseInventory(int _item_id) {
            object[] results = this.Invoke("GetWarehouseInventory", new object[] {
                        _item_id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetWarehouseInventory(int _item_id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetWarehouseInventory", new object[] {
                        _item_id}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetWarehouseInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetPlanQty", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public decimal GetPlanQty(int _item_id, string _tracking_no) {
            object[] results = this.Invoke("GetPlanQty", new object[] {
                        _item_id,
                        _tracking_no});
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPlanQty(int _item_id, string _tracking_no, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPlanQty", new object[] {
                        _item_id,
                        _tracking_no}, callback, asyncState);
        }
        
        /// <remarks/>
        public decimal EndGetPlanQty(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/AdjustWarehouseInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AdjustWarehouseInventory(string _type, int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _mat_lot_no, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks, int _destination_terminal_id) {
            object[] results = this.Invoke("AdjustWarehouseInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _mat_lot_no,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks,
                        _destination_terminal_id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAdjustWarehouseInventory(string _type, int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _mat_lot_no, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks, int _destination_terminal_id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AdjustWarehouseInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _mat_lot_no,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks,
                        _destination_terminal_id}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndAdjustWarehouseInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/UpdateWarehouseInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateWarehouseInventory(string _type, int _item_id, string _item_type, string _invoice_no, string _lot_no, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks) {
            object[] results = this.Invoke("UpdateWarehouseInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _invoice_no,
                        _lot_no,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateWarehouseInventory(string _type, int _item_id, string _item_type, string _invoice_no, string _lot_no, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateWarehouseInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _invoice_no,
                        _lot_no,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndUpdateWarehouseInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/IsProdRequestPartial", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsProdRequestPartial() {
            object[] results = this.Invoke("IsProdRequestPartial", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIsProdRequestPartial(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("IsProdRequestPartial", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndIsProdRequestPartial(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetWarehouseMatLotQty", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public decimal GetWarehouseMatLotQty(int _item_id, string _mat_lot) {
            object[] results = this.Invoke("GetWarehouseMatLotQty", new object[] {
                        _item_id,
                        _mat_lot});
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetWarehouseMatLotQty(int _item_id, string _mat_lot, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetWarehouseMatLotQty", new object[] {
                        _item_id,
                        _mat_lot}, callback, asyncState);
        }
        
        /// <remarks/>
        public decimal EndGetWarehouseMatLotQty(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/UpdateWarehouseRequest", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateWarehouseRequest(int _item_id, string _tracking_no, int _status, string _qty) {
            object[] results = this.Invoke("UpdateWarehouseRequest", new object[] {
                        _item_id,
                        _tracking_no,
                        _status,
                        _qty});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateWarehouseRequest(int _item_id, string _tracking_no, int _status, string _qty, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateWarehouseRequest", new object[] {
                        _item_id,
                        _tracking_no,
                        _status,
                        _qty}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndUpdateWarehouseRequest(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/AddProductionInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddProductionInventory(int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _lot_no, int _src_terminal_id, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks) {
            object[] results = this.Invoke("AddProductionInventory", new object[] {
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _lot_no,
                        _src_terminal_id,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddProductionInventory(int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _lot_no, int _src_terminal_id, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddProductionInventory", new object[] {
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _lot_no,
                        _src_terminal_id,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndAddProductionInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/GetCurrentProductionQuantity", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public decimal GetCurrentProductionQuantity(int _item_id, string _item_type, string _tracking_no, string _prod_lot_no) {
            object[] results = this.Invoke("GetCurrentProductionQuantity", new object[] {
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no});
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCurrentProductionQuantity(int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCurrentProductionQuantity", new object[] {
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no}, callback, asyncState);
        }
        
        /// <remarks/>
        public decimal EndGetCurrentProductionQuantity(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/RemoveIfZeroQty", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int RemoveIfZeroQty(int _item_id, string _tracking_no, string _prod_lot_no, string _mat_lot_no, int _terminal_id, decimal _qty) {
            object[] results = this.Invoke("RemoveIfZeroQty", new object[] {
                        _item_id,
                        _tracking_no,
                        _prod_lot_no,
                        _mat_lot_no,
                        _terminal_id,
                        _qty});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRemoveIfZeroQty(int _item_id, string _tracking_no, string _prod_lot_no, string _mat_lot_no, int _terminal_id, decimal _qty, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("RemoveIfZeroQty", new object[] {
                        _item_id,
                        _tracking_no,
                        _prod_lot_no,
                        _mat_lot_no,
                        _terminal_id,
                        _qty}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndRemoveIfZeroQty(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/AdjustProductionInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AdjustProductionInventory(string _type, int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _mat_lot_no, int _src_terminal_id, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks) {
            object[] results = this.Invoke("AdjustProductionInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _mat_lot_no,
                        _src_terminal_id,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAdjustProductionInventory(string _type, int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _mat_lot_no, int _src_terminal_id, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AdjustProductionInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _mat_lot_no,
                        _src_terminal_id,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndAdjustProductionInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/UpdateProductionInventory", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateProductionInventory(string _type, int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _lot_no, int _src_terminal_id, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks) {
            object[] results = this.Invoke("UpdateProductionInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _lot_no,
                        _src_terminal_id,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateProductionInventory(string _type, int _item_id, string _item_type, string _tracking_no, string _prod_lot_no, string _lot_no, int _src_terminal_id, int _terminal_id, int _terminal_device_id, int _status, decimal _qty, string _remarks, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateProductionInventory", new object[] {
                        _type,
                        _item_id,
                        _item_type,
                        _tracking_no,
                        _prod_lot_no,
                        _lot_no,
                        _src_terminal_id,
                        _terminal_id,
                        _terminal_device_id,
                        _status,
                        _qty,
                        _remarks}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndUpdateProductionInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com.ph/test", RequestNamespace="http://cerp.com.ph/", ResponseNamespace="http://cerp.com.ph/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string test() {
            object[] results = this.Invoke("test", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begintest(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("test", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string Endtest(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}
