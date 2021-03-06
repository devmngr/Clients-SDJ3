﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PackingClient.IWebServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webserver", ConfigurationName="IWebServer.IWebServerPortType")]
    public interface IWebServerPortType {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:addTrayContent")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void addTrayContent(int args0, int args1, double args2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:addTrayContent")]
        System.Threading.Tasks.Task addTrayContentAsync(int args0, int args1, double args2);
        
        // CODEGEN: Parameter 'args0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:registerProduct")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void registerProduct(PackingClient.IWebServer.registerProduct request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:registerProduct")]
        System.Threading.Tasks.Task registerProductAsync(PackingClient.IWebServer.registerProduct request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:addProductContent")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void addProductContent(int args0, int args1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:addProductContent")]
        System.Threading.Tasks.Task addProductContentAsync(int args0, int args1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:registerAnimal")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void registerAnimal(double args0);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:registerAnimal")]
        System.Threading.Tasks.Task registerAnimalAsync(double args0);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getInfectedProducts", ReplyAction="urn:getInfectedProductsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PackingClient.IWebServer.getInfectedProductsResponse getInfectedProducts(PackingClient.IWebServer.getInfectedProductsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getInfectedProducts", ReplyAction="urn:getInfectedProductsResponse")]
        System.Threading.Tasks.Task<PackingClient.IWebServer.getInfectedProductsResponse> getInfectedProductsAsync(PackingClient.IWebServer.getInfectedProductsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:registerTray")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void registerTray(double args0);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:registerTray")]
        System.Threading.Tasks.Task registerTrayAsync(double args0);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registerProduct", WrapperNamespace="http://webserver", IsWrapped=true)]
    public partial class registerProduct {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webserver", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args0;
        
        public registerProduct() {
        }
        
        public registerProduct(string args0) {
            this.args0 = args0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getInfectedProducts", WrapperNamespace="http://webserver", IsWrapped=true)]
    public partial class getInfectedProductsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webserver", Order=0)]
        public int args0;
        
        public getInfectedProductsRequest() {
        }
        
        public getInfectedProductsRequest(int args0) {
            this.args0 = args0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getInfectedProductsResponse", WrapperNamespace="http://webserver", IsWrapped=true)]
    public partial class getInfectedProductsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webserver", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return")]
        public int[] @return;
        
        public getInfectedProductsResponse() {
        }
        
        public getInfectedProductsResponse(int[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebServerPortTypeChannel : PackingClient.IWebServer.IWebServerPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServerPortTypeClient : System.ServiceModel.ClientBase<PackingClient.IWebServer.IWebServerPortType>, PackingClient.IWebServer.IWebServerPortType {
        
        public WebServerPortTypeClient() {
        }
        
        public WebServerPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServerPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServerPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServerPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addTrayContent(int args0, int args1, double args2) {
            base.Channel.addTrayContent(args0, args1, args2);
        }
        
        public System.Threading.Tasks.Task addTrayContentAsync(int args0, int args1, double args2) {
            return base.Channel.addTrayContentAsync(args0, args1, args2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void PackingClient.IWebServer.IWebServerPortType.registerProduct(PackingClient.IWebServer.registerProduct request) {
            base.Channel.registerProduct(request);
        }
        
        public void registerProduct(string args0) {
            PackingClient.IWebServer.registerProduct inValue = new PackingClient.IWebServer.registerProduct();
            inValue.args0 = args0;
            ((PackingClient.IWebServer.IWebServerPortType)(this)).registerProduct(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task PackingClient.IWebServer.IWebServerPortType.registerProductAsync(PackingClient.IWebServer.registerProduct request) {
            return base.Channel.registerProductAsync(request);
        }
        
        public System.Threading.Tasks.Task registerProductAsync(string args0) {
            PackingClient.IWebServer.registerProduct inValue = new PackingClient.IWebServer.registerProduct();
            inValue.args0 = args0;
            return ((PackingClient.IWebServer.IWebServerPortType)(this)).registerProductAsync(inValue);
        }
        
        public void addProductContent(int args0, int args1) {
            base.Channel.addProductContent(args0, args1);
        }
        
        public System.Threading.Tasks.Task addProductContentAsync(int args0, int args1) {
            return base.Channel.addProductContentAsync(args0, args1);
        }
        
        public void registerAnimal(double args0) {
            base.Channel.registerAnimal(args0);
        }
        
        public System.Threading.Tasks.Task registerAnimalAsync(double args0) {
            return base.Channel.registerAnimalAsync(args0);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PackingClient.IWebServer.getInfectedProductsResponse PackingClient.IWebServer.IWebServerPortType.getInfectedProducts(PackingClient.IWebServer.getInfectedProductsRequest request) {
            return base.Channel.getInfectedProducts(request);
        }
        
        public int[] getInfectedProducts(int args0) {
            PackingClient.IWebServer.getInfectedProductsRequest inValue = new PackingClient.IWebServer.getInfectedProductsRequest();
            inValue.args0 = args0;
            PackingClient.IWebServer.getInfectedProductsResponse retVal = ((PackingClient.IWebServer.IWebServerPortType)(this)).getInfectedProducts(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PackingClient.IWebServer.getInfectedProductsResponse> PackingClient.IWebServer.IWebServerPortType.getInfectedProductsAsync(PackingClient.IWebServer.getInfectedProductsRequest request) {
            return base.Channel.getInfectedProductsAsync(request);
        }
        
        public System.Threading.Tasks.Task<PackingClient.IWebServer.getInfectedProductsResponse> getInfectedProductsAsync(int args0) {
            PackingClient.IWebServer.getInfectedProductsRequest inValue = new PackingClient.IWebServer.getInfectedProductsRequest();
            inValue.args0 = args0;
            return ((PackingClient.IWebServer.IWebServerPortType)(this)).getInfectedProductsAsync(inValue);
        }
        
        public void registerTray(double args0) {
            base.Channel.registerTray(args0);
        }
        
        public System.Threading.Tasks.Task registerTrayAsync(double args0) {
            return base.Channel.registerTrayAsync(args0);
        }
    }
}
