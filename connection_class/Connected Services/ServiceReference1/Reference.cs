﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace connection_class.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService3Soap")]
    public interface WebService3Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add", ReplyAction="*")]
        int add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> addAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService3SoapChannel : connection_class.ServiceReference1.WebService3Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService3SoapClient : System.ServiceModel.ClientBase<connection_class.ServiceReference1.WebService3Soap>, connection_class.ServiceReference1.WebService3Soap {
        
        public WebService3SoapClient() {
        }
        
        public WebService3SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService3SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService3SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService3SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int add(int a, int b) {
            return base.Channel.add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int a, int b) {
            return base.Channel.addAsync(a, b);
        }
    }
}
