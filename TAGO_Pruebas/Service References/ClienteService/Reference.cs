﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAGO_Pruebas.ClienteService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/TAGO_Servicios.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CelularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Celular {
            get {
                return this.CelularField;
            }
            set {
                if ((object.ReferenceEquals(this.CelularField, value) != true)) {
                    this.CelularField = value;
                    this.RaisePropertyChanged("Celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteService.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/RegistrarCliente", ReplyAction="http://tempuri.org/IClienteService/RegistrarClienteResponse")]
        TAGO_Pruebas.ClienteService.Cliente RegistrarCliente(TAGO_Pruebas.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/RegistrarCliente", ReplyAction="http://tempuri.org/IClienteService/RegistrarClienteResponse")]
        System.Threading.Tasks.Task<TAGO_Pruebas.ClienteService.Cliente> RegistrarClienteAsync(TAGO_Pruebas.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarCliente", ReplyAction="http://tempuri.org/IClienteService/ModificarClienteResponse")]
        TAGO_Pruebas.ClienteService.Cliente ModificarCliente(TAGO_Pruebas.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarCliente", ReplyAction="http://tempuri.org/IClienteService/ModificarClienteResponse")]
        System.Threading.Tasks.Task<TAGO_Pruebas.ClienteService.Cliente> ModificarClienteAsync(TAGO_Pruebas.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ConsultarClientexEmail", ReplyAction="http://tempuri.org/IClienteService/ConsultarClientexEmailResponse")]
        TAGO_Pruebas.ClienteService.Cliente ConsultarClientexEmail(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ConsultarClientexEmail", ReplyAction="http://tempuri.org/IClienteService/ConsultarClientexEmailResponse")]
        System.Threading.Tasks.Task<TAGO_Pruebas.ClienteService.Cliente> ConsultarClientexEmailAsync(string Email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : TAGO_Pruebas.ClienteService.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<TAGO_Pruebas.ClienteService.IClienteService>, TAGO_Pruebas.ClienteService.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TAGO_Pruebas.ClienteService.Cliente RegistrarCliente(TAGO_Pruebas.ClienteService.Cliente cliente) {
            return base.Channel.RegistrarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<TAGO_Pruebas.ClienteService.Cliente> RegistrarClienteAsync(TAGO_Pruebas.ClienteService.Cliente cliente) {
            return base.Channel.RegistrarClienteAsync(cliente);
        }
        
        public TAGO_Pruebas.ClienteService.Cliente ModificarCliente(TAGO_Pruebas.ClienteService.Cliente cliente) {
            return base.Channel.ModificarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<TAGO_Pruebas.ClienteService.Cliente> ModificarClienteAsync(TAGO_Pruebas.ClienteService.Cliente cliente) {
            return base.Channel.ModificarClienteAsync(cliente);
        }
        
        public TAGO_Pruebas.ClienteService.Cliente ConsultarClientexEmail(string Email) {
            return base.Channel.ConsultarClientexEmail(Email);
        }
        
        public System.Threading.Tasks.Task<TAGO_Pruebas.ClienteService.Cliente> ConsultarClientexEmailAsync(string Email) {
            return base.Channel.ConsultarClientexEmailAsync(Email);
        }
    }
}
