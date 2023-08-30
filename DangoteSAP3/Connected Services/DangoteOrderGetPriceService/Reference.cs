﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DangoteSAP3.DangoteOrderGetPriceService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:dangote-group.com:ng:isop:postatctransaction", ConfigurationName="DangoteOrderGetPriceService.si_price_abs_sync")]
    public interface si_price_abs_sync {
        
        // CODEGEN: Generating message contract since the operation si_price_abs_sync is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncResponse si_price_abs_sync(DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        System.Threading.Tasks.Task<DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncResponse> si_price_abs_syncAsync(DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:dangote-group.com:ng:isop:postatctransaction")]
    public partial class dt_price_in : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string delv_statusField;
        
        private string tran_idField;
        
        private string sales_orgField;
        
        private string divisionField;
        
        private string plantField;
        
        private string cust_numField;
        
        private string cityField;
        
        private string streetField;
        
        private string countryField;
        
        private string cust_nameField;
        
        private string regionField;
        
        private dt_price_inLines[] materialsField;
        
        private dt_price_inLines1[] quantitiesField;
        
        private string acess_tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string delv_status {
            get {
                return this.delv_statusField;
            }
            set {
                this.delv_statusField = value;
                this.RaisePropertyChanged("delv_status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string tran_id {
            get {
                return this.tran_idField;
            }
            set {
                this.tran_idField = value;
                this.RaisePropertyChanged("tran_id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string sales_org {
            get {
                return this.sales_orgField;
            }
            set {
                this.sales_orgField = value;
                this.RaisePropertyChanged("sales_org");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string division {
            get {
                return this.divisionField;
            }
            set {
                this.divisionField = value;
                this.RaisePropertyChanged("division");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string plant {
            get {
                return this.plantField;
            }
            set {
                this.plantField = value;
                this.RaisePropertyChanged("plant");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string cust_num {
            get {
                return this.cust_numField;
            }
            set {
                this.cust_numField = value;
                this.RaisePropertyChanged("cust_num");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
                this.RaisePropertyChanged("street");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("country");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string cust_name {
            get {
                return this.cust_nameField;
            }
            set {
                this.cust_nameField = value;
                this.RaisePropertyChanged("cust_name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string region {
            get {
                return this.regionField;
            }
            set {
                this.regionField = value;
                this.RaisePropertyChanged("region");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("lines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public dt_price_inLines[] materials {
            get {
                return this.materialsField;
            }
            set {
                this.materialsField = value;
                this.RaisePropertyChanged("materials");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        [System.Xml.Serialization.XmlArrayItemAttribute("lines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public dt_price_inLines1[] quantities {
            get {
                return this.quantitiesField;
            }
            set {
                this.quantitiesField = value;
                this.RaisePropertyChanged("quantities");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string acess_token {
            get {
                return this.acess_tokenField;
            }
            set {
                this.acess_tokenField = value;
                this.RaisePropertyChanged("acess_token");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:dangote-group.com:ng:isop:postatctransaction")]
    public partial class dt_price_inLines : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string material_noField;
        
        private string material_txtField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string material_no {
            get {
                return this.material_noField;
            }
            set {
                this.material_noField = value;
                this.RaisePropertyChanged("material_no");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string material_txt {
            get {
                return this.material_txtField;
            }
            set {
                this.material_txtField = value;
                this.RaisePropertyChanged("material_txt");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:dangote-group.com:ng:isop:postatctransaction")]
    public partial class dt_price_out : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string base_priceField;
        
        private string delivery_priceField;
        
        private dt_price_outLines[] error_logField;
        
        private string access_tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string base_price {
            get {
                return this.base_priceField;
            }
            set {
                this.base_priceField = value;
                this.RaisePropertyChanged("base_price");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string delivery_price {
            get {
                return this.delivery_priceField;
            }
            set {
                this.delivery_priceField = value;
                this.RaisePropertyChanged("delivery_price");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("lines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public dt_price_outLines[] error_log {
            get {
                return this.error_logField;
            }
            set {
                this.error_logField = value;
                this.RaisePropertyChanged("error_log");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string access_token {
            get {
                return this.access_tokenField;
            }
            set {
                this.access_tokenField = value;
                this.RaisePropertyChanged("access_token");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:dangote-group.com:ng:isop:postatctransaction")]
    public partial class dt_price_outLines : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string titleField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:dangote-group.com:ng:isop:postatctransaction")]
    public partial class dt_price_inLines1 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private decimal qtyField;
        
        private bool qtyFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
                this.RaisePropertyChanged("qty");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtySpecified {
            get {
                return this.qtyFieldSpecified;
            }
            set {
                this.qtyFieldSpecified = value;
                this.RaisePropertyChanged("qtySpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class si_price_abs_syncRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:dangote-group.com:ng:isop:postatctransaction", Order=0)]
        public DangoteSAP3.DangoteOrderGetPriceService.dt_price_in mt_price_in;
        
        public si_price_abs_syncRequest() {
        }
        
        public si_price_abs_syncRequest(DangoteSAP3.DangoteOrderGetPriceService.dt_price_in mt_price_in) {
            this.mt_price_in = mt_price_in;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class si_price_abs_syncResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:dangote-group.com:ng:isop:postatctransaction", Order=0)]
        public DangoteSAP3.DangoteOrderGetPriceService.dt_price_out mt_price_out;
        
        public si_price_abs_syncResponse() {
        }
        
        public si_price_abs_syncResponse(DangoteSAP3.DangoteOrderGetPriceService.dt_price_out mt_price_out) {
            this.mt_price_out = mt_price_out;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface si_price_abs_syncChannel : DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_sync, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class si_price_abs_syncClient : System.ServiceModel.ClientBase<DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_sync>, DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_sync {
        
        public si_price_abs_syncClient() {
        }
        
        public si_price_abs_syncClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public si_price_abs_syncClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public si_price_abs_syncClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public si_price_abs_syncClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncResponse DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_sync.si_price_abs_sync(DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest request) {
            return base.Channel.si_price_abs_sync(request);
        }
        
        public DangoteSAP3.DangoteOrderGetPriceService.dt_price_out si_price_abs_sync(DangoteSAP3.DangoteOrderGetPriceService.dt_price_in mt_price_in) {
            DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest inValue = new DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest();
            inValue.mt_price_in = mt_price_in;
            DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncResponse retVal = ((DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_sync)(this)).si_price_abs_sync(inValue);
            return retVal.mt_price_out;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncResponse> DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_sync.si_price_abs_syncAsync(DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest request) {
            return base.Channel.si_price_abs_syncAsync(request);
        }
        
        public System.Threading.Tasks.Task<DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncResponse> si_price_abs_syncAsync(DangoteSAP3.DangoteOrderGetPriceService.dt_price_in mt_price_in) {
            DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest inValue = new DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_syncRequest();
            inValue.mt_price_in = mt_price_in;
            return ((DangoteSAP3.DangoteOrderGetPriceService.si_price_abs_sync)(this)).si_price_abs_syncAsync(inValue);
        }
    }
}
