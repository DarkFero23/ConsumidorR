﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumidorR.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        int Suma(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SumaAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        int Resta(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        System.Threading.Tasks.Task<int> RestaAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicación", ReplyAction="*")]
        int Multiplicación(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicación", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultiplicaciónAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/División", ReplyAction="*")]
        int División(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/División", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivisiónAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ConsumidorR.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ConsumidorR.ServiceReference1.WebService1Soap>, ConsumidorR.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Suma(int x, int y) {
            return base.Channel.Suma(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SumaAsync(int x, int y) {
            return base.Channel.SumaAsync(x, y);
        }
        
        public int Resta(int x, int y) {
            return base.Channel.Resta(x, y);
        }
        
        public System.Threading.Tasks.Task<int> RestaAsync(int x, int y) {
            return base.Channel.RestaAsync(x, y);
        }
        
        public int Multiplicación(int x, int y) {
            return base.Channel.Multiplicación(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicaciónAsync(int x, int y) {
            return base.Channel.MultiplicaciónAsync(x, y);
        }
        
        public int División(int x, int y) {
            return base.Channel.División(x, y);
        }
        
        public System.Threading.Tasks.Task<int> DivisiónAsync(int x, int y) {
            return base.Channel.DivisiónAsync(x, y);
        }
    }
}