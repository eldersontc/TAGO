﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAGO_Presentacion.VISANETService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VISANETService.IServiceVISANET")]
    public interface IServiceVISANET {
        
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
        
        public int registrarPagoVISANET(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion) {
            return base.Channel.registrarPagoVISANET(Numero, Vencimiento, CodigoVerificacion, Nombre, Apellido, CorreoElectronico, ImporteOperacion);
        }
        
        public System.Threading.Tasks.Task<int> registrarPagoVISANETAsync(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion) {
            return base.Channel.registrarPagoVISANETAsync(Numero, Vencimiento, CodigoVerificacion, Nombre, Apellido, CorreoElectronico, ImporteOperacion);
        }
    }
}
