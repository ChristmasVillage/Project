﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChristmasVillageGUI.Proxies
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ChristmasVillageIFAC/VillageIFAC", ConfigurationName="ChristmasVillageGUI.Proxies.VillageIFAC")]
    public interface VillageIFAC
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/createVillage", ReplyAction="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/createVillageResponse")]
        void createVillage(ChristmasVillageBO.VillageBO village);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/createVillage", ReplyAction="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/createVillageResponse")]
        System.IAsyncResult BegincreateVillage(ChristmasVillageBO.VillageBO village, System.AsyncCallback callback, object asyncState);
        
        void EndcreateVillage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/findVillage", ReplyAction="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/findVillageResponse")]
        ChristmasVillageBO.VillageBO findVillage(string villageName);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/findVillage", ReplyAction="urn:ChristmasVillageIFAC/VillageIFAC/VillageIFAC/findVillageResponse")]
        System.IAsyncResult BeginfindVillage(string villageName, System.AsyncCallback callback, object asyncState);
        
        ChristmasVillageBO.VillageBO EndfindVillage(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VillageIFACChannel : ChristmasVillageGUI.Proxies.VillageIFAC, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VillageIFACClient : System.ServiceModel.ClientBase<ChristmasVillageGUI.Proxies.VillageIFAC>, ChristmasVillageGUI.Proxies.VillageIFAC
    {
        
        public VillageIFACClient()
        {
        }
        
        public VillageIFACClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public VillageIFACClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public VillageIFACClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public VillageIFACClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void createVillage(ChristmasVillageBO.VillageBO village)
        {
            base.Channel.createVillage(village);
        }
        
        public System.IAsyncResult BegincreateVillage(ChristmasVillageBO.VillageBO village, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegincreateVillage(village, callback, asyncState);
        }
        
        public void EndcreateVillage(System.IAsyncResult result)
        {
            base.Channel.EndcreateVillage(result);
        }
        
        public ChristmasVillageBO.VillageBO findVillage(string villageName)
        {
            return base.Channel.findVillage(villageName);
        }
        
        public System.IAsyncResult BeginfindVillage(string villageName, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginfindVillage(villageName, callback, asyncState);
        }
        
        public ChristmasVillageBO.VillageBO EndfindVillage(System.IAsyncResult result)
        {
            return base.Channel.EndfindVillage(result);
        }
    }
}
