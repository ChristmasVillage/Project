﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChristmasVillageGUI.Proxies
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ChristmasVillageIFAC/FactoryIFAC", ConfigurationName="ChristmasVillageGUI.Proxies.FactoryIFAC")]
    public interface FactoryIFAC
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/createFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/createFactoryResponse")]
        void createFactory(ChristmasVillageBO.FactoryBO factory);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/createFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/createFactoryResponse")]
        System.IAsyncResult BegincreateFactory(ChristmasVillageBO.FactoryBO factory, System.AsyncCallback callback, object asyncState);
        
        void EndcreateFactory(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/getLastFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/getLastFactoryResponse")]
        ChristmasVillageBO.FactoryBO getLastFactory();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/getLastFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/getLastFactoryResponse")]
        System.IAsyncResult BegingetLastFactory(System.AsyncCallback callback, object asyncState);
        
        ChristmasVillageBO.FactoryBO EndgetLastFactory(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/deleteFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/deleteFactoryResponse")]
        void deleteFactory(int id_Factory);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/deleteFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/deleteFactoryResponse")]
        System.IAsyncResult BegindeleteFactory(int id_Factory, System.AsyncCallback callback, object asyncState);
        
        void EnddeleteFactory(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/findFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/findFactoryResponse")]
        ChristmasVillageBO.FactoryBO findFactory(int id_factory);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/findFactory", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/findFactoryResponse")]
        System.IAsyncResult BeginfindFactory(int id_factory, System.AsyncCallback callback, object asyncState);
        
        ChristmasVillageBO.FactoryBO EndfindFactory(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/productToys", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/productToysResponse")]
        void productToys(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/productToys", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/productToysResponse")]
        System.IAsyncResult BeginproductToys(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        void EndproductToys(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/salesProduct", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/salesProductResponse")]
        void salesProduct(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/salesProduct", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/salesProductResponse")]
        System.IAsyncResult BeginsalesProduct(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        void EndsalesProduct(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/checkStatus", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/checkStatusResponse")]
        bool checkStatus(ChristmasVillageBO.FactoryBO factory);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/checkStatus", ReplyAction="urn:ChristmasVillageIFAC/FactoryIFAC/FactoryIFAC/checkStatusResponse")]
        System.IAsyncResult BegincheckStatus(ChristmasVillageBO.FactoryBO factory, System.AsyncCallback callback, object asyncState);
        
        bool EndcheckStatus(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FactoryIFACChannel : ChristmasVillageGUI.Proxies.FactoryIFAC, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FactoryIFACClient : System.ServiceModel.ClientBase<ChristmasVillageGUI.Proxies.FactoryIFAC>, ChristmasVillageGUI.Proxies.FactoryIFAC
    {
        
        public FactoryIFACClient()
        {
        }
        
        public FactoryIFACClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public FactoryIFACClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public FactoryIFACClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public FactoryIFACClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void createFactory(ChristmasVillageBO.FactoryBO factory)
        {
            base.Channel.createFactory(factory);
        }
        
        public System.IAsyncResult BegincreateFactory(ChristmasVillageBO.FactoryBO factory, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegincreateFactory(factory, callback, asyncState);
        }
        
        public void EndcreateFactory(System.IAsyncResult result)
        {
            base.Channel.EndcreateFactory(result);
        }
        
        public ChristmasVillageBO.FactoryBO getLastFactory()
        {
            return base.Channel.getLastFactory();
        }
        
        public System.IAsyncResult BegingetLastFactory(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegingetLastFactory(callback, asyncState);
        }
        
        public ChristmasVillageBO.FactoryBO EndgetLastFactory(System.IAsyncResult result)
        {
            return base.Channel.EndgetLastFactory(result);
        }
        
        public void deleteFactory(int id_Factory)
        {
            base.Channel.deleteFactory(id_Factory);
        }
        
        public System.IAsyncResult BegindeleteFactory(int id_Factory, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegindeleteFactory(id_Factory, callback, asyncState);
        }
        
        public void EnddeleteFactory(System.IAsyncResult result)
        {
            base.Channel.EnddeleteFactory(result);
        }
        
        public ChristmasVillageBO.FactoryBO findFactory(int id_factory)
        {
            return base.Channel.findFactory(id_factory);
        }
        
        public System.IAsyncResult BeginfindFactory(int id_factory, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginfindFactory(id_factory, callback, asyncState);
        }
        
        public ChristmasVillageBO.FactoryBO EndfindFactory(System.IAsyncResult result)
        {
            return base.Channel.EndfindFactory(result);
        }
        
        public void productToys(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user)
        {
            base.Channel.productToys(factory, user);
        }
        
        public System.IAsyncResult BeginproductToys(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginproductToys(factory, user, callback, asyncState);
        }
        
        public void EndproductToys(System.IAsyncResult result)
        {
            base.Channel.EndproductToys(result);
        }
        
        public void salesProduct(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user)
        {
            base.Channel.salesProduct(factory, user);
        }
        
        public System.IAsyncResult BeginsalesProduct(ChristmasVillageBO.FactoryBO factory, ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginsalesProduct(factory, user, callback, asyncState);
        }
        
        public void EndsalesProduct(System.IAsyncResult result)
        {
            base.Channel.EndsalesProduct(result);
        }
        
        public bool checkStatus(ChristmasVillageBO.FactoryBO factory)
        {
            return base.Channel.checkStatus(factory);
        }
        
        public System.IAsyncResult BegincheckStatus(ChristmasVillageBO.FactoryBO factory, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegincheckStatus(factory, callback, asyncState);
        }
        
        public bool EndcheckStatus(System.IAsyncResult result)
        {
            return base.Channel.EndcheckStatus(result);
        }
    }
}
