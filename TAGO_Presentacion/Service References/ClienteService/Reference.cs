﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAGO_Presentacion.ClienteService {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tarjeta", Namespace="http://schemas.datacontract.org/2004/07/TAGO_Servicios.Dominio")]
    [System.SerializableAttribute()]
    public partial class Tarjeta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CVVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaVencimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
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
        public string CVV {
            get {
                return this.CVVField;
            }
            set {
                if ((object.ReferenceEquals(this.CVVField, value) != true)) {
                    this.CVVField = value;
                    this.RaisePropertyChanged("CVV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaVencimiento {
            get {
                return this.FechaVencimientoField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaVencimientoField, value) != true)) {
                    this.FechaVencimientoField = value;
                    this.RaisePropertyChanged("FechaVencimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
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
        TAGO_Presentacion.ClienteService.Cliente RegistrarCliente(TAGO_Presentacion.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/RegistrarCliente", ReplyAction="http://tempuri.org/IClienteService/RegistrarClienteResponse")]
        System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Cliente> RegistrarClienteAsync(TAGO_Presentacion.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarCliente", ReplyAction="http://tempuri.org/IClienteService/ModificarClienteResponse")]
        TAGO_Presentacion.ClienteService.Cliente ModificarCliente(TAGO_Presentacion.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarCliente", ReplyAction="http://tempuri.org/IClienteService/ModificarClienteResponse")]
        System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Cliente> ModificarClienteAsync(TAGO_Presentacion.ClienteService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ConsultarClientexEmail", ReplyAction="http://tempuri.org/IClienteService/ConsultarClientexEmailResponse")]
        TAGO_Presentacion.ClienteService.Cliente ConsultarClientexEmail(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ConsultarClientexEmail", ReplyAction="http://tempuri.org/IClienteService/ConsultarClientexEmailResponse")]
        System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Cliente> ConsultarClientexEmailAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/RegistrarTarjeta", ReplyAction="http://tempuri.org/IClienteService/RegistrarTarjetaResponse")]
        TAGO_Presentacion.ClienteService.Tarjeta RegistrarTarjeta(TAGO_Presentacion.ClienteService.Tarjeta tarjeta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/RegistrarTarjeta", ReplyAction="http://tempuri.org/IClienteService/RegistrarTarjetaResponse")]
        System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Tarjeta> RegistrarTarjetaAsync(TAGO_Presentacion.ClienteService.Tarjeta tarjeta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarTarjeta", ReplyAction="http://tempuri.org/IClienteService/ModificarTarjetaResponse")]
        TAGO_Presentacion.ClienteService.Tarjeta ModificarTarjeta(TAGO_Presentacion.ClienteService.Tarjeta tarjeta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarTarjeta", ReplyAction="http://tempuri.org/IClienteService/ModificarTarjetaResponse")]
        System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Tarjeta> ModificarTarjetaAsync(TAGO_Presentacion.ClienteService.Tarjeta tarjeta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/EliminarTarjeta", ReplyAction="http://tempuri.org/IClienteService/EliminarTarjetaResponse")]
        int EliminarTarjeta(string numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/EliminarTarjeta", ReplyAction="http://tempuri.org/IClienteService/EliminarTarjetaResponse")]
        System.Threading.Tasks.Task<int> EliminarTarjetaAsync(string numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ListarTarjetaxCliente", ReplyAction="http://tempuri.org/IClienteService/ListarTarjetaxClienteResponse")]
        TAGO_Presentacion.ClienteService.Tarjeta[] ListarTarjetaxCliente(string DNI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ListarTarjetaxCliente", ReplyAction="http://tempuri.org/IClienteService/ListarTarjetaxClienteResponse")]
        System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Tarjeta[]> ListarTarjetaxClienteAsync(string DNI);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : TAGO_Presentacion.ClienteService.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<TAGO_Presentacion.ClienteService.IClienteService>, TAGO_Presentacion.ClienteService.IClienteService {
        
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
        
        public TAGO_Presentacion.ClienteService.Cliente RegistrarCliente(TAGO_Presentacion.ClienteService.Cliente cliente) {
            return base.Channel.RegistrarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Cliente> RegistrarClienteAsync(TAGO_Presentacion.ClienteService.Cliente cliente) {
            return base.Channel.RegistrarClienteAsync(cliente);
        }
        
        public TAGO_Presentacion.ClienteService.Cliente ModificarCliente(TAGO_Presentacion.ClienteService.Cliente cliente) {
            return base.Channel.ModificarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Cliente> ModificarClienteAsync(TAGO_Presentacion.ClienteService.Cliente cliente) {
            return base.Channel.ModificarClienteAsync(cliente);
        }
        
        public TAGO_Presentacion.ClienteService.Cliente ConsultarClientexEmail(string Email) {
            return base.Channel.ConsultarClientexEmail(Email);
        }
        
        public System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Cliente> ConsultarClientexEmailAsync(string Email) {
            return base.Channel.ConsultarClientexEmailAsync(Email);
        }
        
        public TAGO_Presentacion.ClienteService.Tarjeta RegistrarTarjeta(TAGO_Presentacion.ClienteService.Tarjeta tarjeta) {
            return base.Channel.RegistrarTarjeta(tarjeta);
        }
        
        public System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Tarjeta> RegistrarTarjetaAsync(TAGO_Presentacion.ClienteService.Tarjeta tarjeta) {
            return base.Channel.RegistrarTarjetaAsync(tarjeta);
        }
        
        public TAGO_Presentacion.ClienteService.Tarjeta ModificarTarjeta(TAGO_Presentacion.ClienteService.Tarjeta tarjeta) {
            return base.Channel.ModificarTarjeta(tarjeta);
        }
        
        public System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Tarjeta> ModificarTarjetaAsync(TAGO_Presentacion.ClienteService.Tarjeta tarjeta) {
            return base.Channel.ModificarTarjetaAsync(tarjeta);
        }
        
        public int EliminarTarjeta(string numero) {
            return base.Channel.EliminarTarjeta(numero);
        }
        
        public System.Threading.Tasks.Task<int> EliminarTarjetaAsync(string numero) {
            return base.Channel.EliminarTarjetaAsync(numero);
        }
        
        public TAGO_Presentacion.ClienteService.Tarjeta[] ListarTarjetaxCliente(string DNI) {
            return base.Channel.ListarTarjetaxCliente(DNI);
        }
        
        public System.Threading.Tasks.Task<TAGO_Presentacion.ClienteService.Tarjeta[]> ListarTarjetaxClienteAsync(string DNI) {
            return base.Channel.ListarTarjetaxClienteAsync(DNI);
        }
    }
}
