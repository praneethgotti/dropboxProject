﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace FinalProject.FPSVC {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AddFilesSoap", Namespace="http://tempuri.org/")]
    public partial class AddFiles : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback addFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback displayByUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPersonsOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AddFiles() {
            this.Url = global::FinalProject.Properties.Settings.Default.FinalProject_FPSVC_AddFiles;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event addFileCompletedEventHandler addFileCompleted;
        
        /// <remarks/>
        public event displayByUserCompletedEventHandler displayByUserCompleted;
        
        /// <remarks/>
        public event updateFileCompletedEventHandler updateFileCompleted;
        
        /// <remarks/>
        public event deleteFileCompletedEventHandler deleteFileCompleted;
        
        /// <remarks/>
        public event deleteUserCompletedEventHandler deleteUserCompleted;
        
        /// <remarks/>
        public event GetPersonsCompletedEventHandler GetPersonsCompleted;
        
        /// <remarks/>
        public event updateUserCompletedEventHandler updateUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addFile(string fileName, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] document, System.DateTime date, string user) {
            this.Invoke("addFile", new object[] {
                        fileName,
                        document,
                        date,
                        user});
        }
        
        /// <remarks/>
        public void addFileAsync(string fileName, byte[] document, System.DateTime date, string user) {
            this.addFileAsync(fileName, document, date, user, null);
        }
        
        /// <remarks/>
        public void addFileAsync(string fileName, byte[] document, System.DateTime date, string user, object userState) {
            if ((this.addFileOperationCompleted == null)) {
                this.addFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddFileOperationCompleted);
            }
            this.InvokeAsync("addFile", new object[] {
                        fileName,
                        document,
                        date,
                        user}, this.addFileOperationCompleted, userState);
        }
        
        private void OnaddFileOperationCompleted(object arg) {
            if ((this.addFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/displayByUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet displayByUser(string username, string password, string user) {
            object[] results = this.Invoke("displayByUser", new object[] {
                        username,
                        password,
                        user});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void displayByUserAsync(string username, string password, string user) {
            this.displayByUserAsync(username, password, user, null);
        }
        
        /// <remarks/>
        public void displayByUserAsync(string username, string password, string user, object userState) {
            if ((this.displayByUserOperationCompleted == null)) {
                this.displayByUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OndisplayByUserOperationCompleted);
            }
            this.InvokeAsync("displayByUser", new object[] {
                        username,
                        password,
                        user}, this.displayByUserOperationCompleted, userState);
        }
        
        private void OndisplayByUserOperationCompleted(object arg) {
            if ((this.displayByUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.displayByUserCompleted(this, new displayByUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateFile(string username, string password, string name, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] document, System.DateTime date, string fn) {
            this.Invoke("updateFile", new object[] {
                        username,
                        password,
                        name,
                        document,
                        date,
                        fn});
        }
        
        /// <remarks/>
        public void updateFileAsync(string username, string password, string name, byte[] document, System.DateTime date, string fn) {
            this.updateFileAsync(username, password, name, document, date, fn, null);
        }
        
        /// <remarks/>
        public void updateFileAsync(string username, string password, string name, byte[] document, System.DateTime date, string fn, object userState) {
            if ((this.updateFileOperationCompleted == null)) {
                this.updateFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateFileOperationCompleted);
            }
            this.InvokeAsync("updateFile", new object[] {
                        username,
                        password,
                        name,
                        document,
                        date,
                        fn}, this.updateFileOperationCompleted, userState);
        }
        
        private void OnupdateFileOperationCompleted(object arg) {
            if ((this.updateFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void deleteFile(string username, string password, string name) {
            this.Invoke("deleteFile", new object[] {
                        username,
                        password,
                        name});
        }
        
        /// <remarks/>
        public void deleteFileAsync(string username, string password, string name) {
            this.deleteFileAsync(username, password, name, null);
        }
        
        /// <remarks/>
        public void deleteFileAsync(string username, string password, string name, object userState) {
            if ((this.deleteFileOperationCompleted == null)) {
                this.deleteFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteFileOperationCompleted);
            }
            this.InvokeAsync("deleteFile", new object[] {
                        username,
                        password,
                        name}, this.deleteFileOperationCompleted, userState);
        }
        
        private void OndeleteFileOperationCompleted(object arg) {
            if ((this.deleteFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void deleteUser(string username, string password, int LoginID) {
            this.Invoke("deleteUser", new object[] {
                        username,
                        password,
                        LoginID});
        }
        
        /// <remarks/>
        public void deleteUserAsync(string username, string password, int LoginID) {
            this.deleteUserAsync(username, password, LoginID, null);
        }
        
        /// <remarks/>
        public void deleteUserAsync(string username, string password, int LoginID, object userState) {
            if ((this.deleteUserOperationCompleted == null)) {
                this.deleteUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteUserOperationCompleted);
            }
            this.InvokeAsync("deleteUser", new object[] {
                        username,
                        password,
                        LoginID}, this.deleteUserOperationCompleted, userState);
        }
        
        private void OndeleteUserOperationCompleted(object arg) {
            if ((this.deleteUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPersons", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetPersons() {
            object[] results = this.Invoke("GetPersons", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetPersonsAsync() {
            this.GetPersonsAsync(null);
        }
        
        /// <remarks/>
        public void GetPersonsAsync(object userState) {
            if ((this.GetPersonsOperationCompleted == null)) {
                this.GetPersonsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPersonsOperationCompleted);
            }
            this.InvokeAsync("GetPersons", new object[0], this.GetPersonsOperationCompleted, userState);
        }
        
        private void OnGetPersonsOperationCompleted(object arg) {
            if ((this.GetPersonsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPersonsCompleted(this, new GetPersonsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateUser(string username, string password, int LoginID, string FirstName, string LastName, [System.Xml.Serialization.XmlElementAttribute("Username")] string Username1, [System.Xml.Serialization.XmlElementAttribute("Password")] string Password1, string Email, string PhoneNumber) {
            this.Invoke("updateUser", new object[] {
                        username,
                        password,
                        LoginID,
                        FirstName,
                        LastName,
                        Username1,
                        Password1,
                        Email,
                        PhoneNumber});
        }
        
        /// <remarks/>
        public void updateUserAsync(string username, string password, int LoginID, string FirstName, string LastName, string Username1, string Password1, string Email, string PhoneNumber) {
            this.updateUserAsync(username, password, LoginID, FirstName, LastName, Username1, Password1, Email, PhoneNumber, null);
        }
        
        /// <remarks/>
        public void updateUserAsync(string username, string password, int LoginID, string FirstName, string LastName, string Username1, string Password1, string Email, string PhoneNumber, object userState) {
            if ((this.updateUserOperationCompleted == null)) {
                this.updateUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateUserOperationCompleted);
            }
            this.InvokeAsync("updateUser", new object[] {
                        username,
                        password,
                        LoginID,
                        FirstName,
                        LastName,
                        Username1,
                        Password1,
                        Email,
                        PhoneNumber}, this.updateUserOperationCompleted, userState);
        }
        
        private void OnupdateUserOperationCompleted(object arg) {
            if ((this.updateUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void addFileCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void displayByUserCompletedEventHandler(object sender, displayByUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class displayByUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal displayByUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void updateFileCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void deleteFileCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void deleteUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetPersonsCompletedEventHandler(object sender, GetPersonsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPersonsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPersonsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void updateUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591