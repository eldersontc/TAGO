﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAGO_Presentacion.VISANETService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tarjeta", Namespace="http://schemas.datacontract.org/2004/07/TAGO_VISANET.Domino")]
    [System.SerializableAttribute()]
    public partial class Tarjeta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoVerificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoElectronicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ImporteSaldoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VencimientoField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoVerificacion {
            get {
                return this.CodigoVerificacionField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoVerificacionField, value) != true)) {
                    this.CodigoVerificacionField = value;
                    this.RaisePropertyChanged("CodigoVerificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CorreoElectronico {
            get {
                return this.CorreoElectronicoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoElectronicoField, value) != true)) {
                    this.CorreoElectronicoField = value;
                    this.RaisePropertyChanged("CorreoElectronico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ImporteSaldo {
            get {
                return this.ImporteSaldoField;
            }
            set {
                if ((this.ImporteSaldoField.Equals(value) != true)) {
                    this.ImporteSaldoField = value;
                    this.RaisePropertyChanged("ImporteSaldo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vencimiento {
            get {
                return this.VencimientoField;
            }
            set {
                if ((object.ReferenceEquals(this.VencimientoField, value) != true)) {
                    this.VencimientoField = value;
                    this.RaisePropertyChanged("Vencimiento");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VISANETService.IServiceVISANET")]
    public interface IServiceVISANET {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVISANET/obtenerTarjeta", ReplyAction="http://tempuri.org/IServiceVISANET/obtenerTarjetaResponse")]
        TAGO_Presentacion.VISANETService.Tarjeta obtenerTarjeta(string Numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVISANET/obtenerTarjeta", ReplyAction="http://tempuri.org/IServiceVISANET/obtenerTarjetaResponse")]
        System.Threading.Tasks.Task<TAGO_Presentacion.VISANETService.Tarjeta> obtenerTarjetaAsync(string Numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVISANET/registrarPagoVISANET", ReplyAction="http://tempuri.org/IServiceVISANET/registrarPagoVISANETResponse")]
        int registrarPagoVISANET(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVISANET/registrarPagoVISANET", ReplyAction="http://tempuri.org/IServiceVISANET/registrarPagoVISANETResponse")]
        System.Threading.Tasks.Task<int> registrarPagoVISANETAsync(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceVISANETChannel : TAGO_Presentacion.VISANETService.IServiceVISANET, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceVISANETClient : System.ServiceModel.ClientBase<TAGO_Presentacion.VISANETService.IServiceVISANET>, TAGO_Presentacion.VISANETService.IServiceVISANET {
        
        public ServiceVISANETClient() {
        }
        
        public ServiceVISANETClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceVISANETClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceVISANETClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceVISANETClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TAGO_Presentacion.VISANETService.Tarjeta obtenerTarjeta(string Numero) {
            return base.Channel.obtenerTarjeta(Numero);
        }
        
        public System.Threading.Tasks.Task<TAGO_Presentacion.VISANETService.Tarjeta> obtenerTarjetaAsync(string Numero) {
            return base.Channel.obtenerTarjetaAsync(Numero);
        }
        
        public int registrarPagoVISANET(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion) {
            return base.Channel.registrarPagoVISANET(Numero, Vencimiento, CodigoVerificacion, Nombre, Apellido, CorreoElectronico, ImporteOperacion);
        }
        
        public System.Threading.Tasks.Task<int> registrarPagoVISANETAsync(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion) {
            return base.Channel.registrarPagoVISANETAsync(Numero, Vencimiento, CodigoVerificacion, Nombre, Apellido, CorreoElectronico, ImporteOperacion);
        }
    }
}
