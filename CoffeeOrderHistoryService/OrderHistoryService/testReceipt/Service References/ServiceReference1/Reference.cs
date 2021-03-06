﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testReceipt.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderH", Namespace="http://schemas.datacontract.org/2004/07/OrderHistoryService")]
    [System.SerializableAttribute()]
    public partial class OrderH : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CaloriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Calories {
            get {
                return this.CaloriesField;
            }
            set {
                if ((this.CaloriesField.Equals(value) != true)) {
                    this.CaloriesField = value;
                    this.RaisePropertyChanged("Calories");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string date {
            get {
                return this.dateField;
            }
            set {
                if ((object.ReferenceEquals(this.dateField, value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IOrderHistory")]
    public interface IOrderHistory {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderHistory/yourHistory", ReplyAction="http://tempuri.org/IOrderHistory/yourHistoryResponse")]
        testReceipt.ServiceReference1.OrderH yourHistory(string d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderHistory/yourHistory", ReplyAction="http://tempuri.org/IOrderHistory/yourHistoryResponse")]
        System.Threading.Tasks.Task<testReceipt.ServiceReference1.OrderH> yourHistoryAsync(string d);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderHistoryChannel : testReceipt.ServiceReference1.IOrderHistory, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderHistoryClient : System.ServiceModel.ClientBase<testReceipt.ServiceReference1.IOrderHistory>, testReceipt.ServiceReference1.IOrderHistory {
        
        public OrderHistoryClient() {
        }
        
        public OrderHistoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderHistoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderHistoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderHistoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public testReceipt.ServiceReference1.OrderH yourHistory(string d) {
            return base.Channel.yourHistory(d);
        }
        
        public System.Threading.Tasks.Task<testReceipt.ServiceReference1.OrderH> yourHistoryAsync(string d) {
            return base.Channel.yourHistoryAsync(d);
        }
    }
}
