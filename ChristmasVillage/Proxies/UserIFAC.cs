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
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ChristmasVillageIFAC/UserIFAC", ConfigurationName="ChristmasVillageGUI.Proxies.UserIFAC")]
    public interface UserIFAC
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/createUser", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/createUserResponse")]
        void createUser(ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/createUser", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/createUserResponse")]
        System.IAsyncResult BegincreateUser(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        void EndcreateUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkUniqueUsername", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkUniqueUsernameResponse")]
        bool checkUniqueUsername(ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkUniqueUsername", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkUniqueUsernameResponse")]
        System.IAsyncResult BegincheckUniqueUsername(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        bool EndcheckUniqueUsername(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/searchUser", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/searchUserResponse")]
        ChristmasVillageBO.UserBO searchUser(ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/searchUser", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/searchUserResponse")]
        System.IAsyncResult BeginsearchUser(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        ChristmasVillageBO.UserBO EndsearchUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/connexion", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/connexionResponse")]
        string connexion(ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/connexion", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/connexionResponse")]
        System.IAsyncResult Beginconnexion(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        string Endconnexion(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/disconnect", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/disconnectResponse")]
        void disconnect(ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/disconnect", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/disconnectResponse")]
        System.IAsyncResult Begindisconnect(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        void Enddisconnect(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/updateUser", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/updateUserResponse")]
        void updateUser(ChristmasVillageBO.UserBO user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/updateUser", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/updateUserResponse")]
        System.IAsyncResult BeginupdateUser(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState);
        
        void EndupdateUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkConnexion", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkConnexionResponse")]
        bool checkConnexion();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkConnexion", ReplyAction="urn:ChristmasVillageIFAC/UserIFAC/UserIFAC/checkConnexionResponse")]
        System.IAsyncResult BegincheckConnexion(System.AsyncCallback callback, object asyncState);
        
        bool EndcheckConnexion(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserIFACChannel : ChristmasVillageGUI.Proxies.UserIFAC, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserIFACClient : System.ServiceModel.ClientBase<ChristmasVillageGUI.Proxies.UserIFAC>, ChristmasVillageGUI.Proxies.UserIFAC
    {
        
        public UserIFACClient()
        {
        }
        
        public UserIFACClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public UserIFACClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public UserIFACClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public UserIFACClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void createUser(ChristmasVillageBO.UserBO user)
        {
            base.Channel.createUser(user);
        }
        
        public System.IAsyncResult BegincreateUser(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegincreateUser(user, callback, asyncState);
        }
        
        public void EndcreateUser(System.IAsyncResult result)
        {
            base.Channel.EndcreateUser(result);
        }
        
        public bool checkUniqueUsername(ChristmasVillageBO.UserBO user)
        {
            return base.Channel.checkUniqueUsername(user);
        }
        
        public System.IAsyncResult BegincheckUniqueUsername(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegincheckUniqueUsername(user, callback, asyncState);
        }
        
        public bool EndcheckUniqueUsername(System.IAsyncResult result)
        {
            return base.Channel.EndcheckUniqueUsername(result);
        }
        
        public ChristmasVillageBO.UserBO searchUser(ChristmasVillageBO.UserBO user)
        {
            return base.Channel.searchUser(user);
        }
        
        public System.IAsyncResult BeginsearchUser(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginsearchUser(user, callback, asyncState);
        }
        
        public ChristmasVillageBO.UserBO EndsearchUser(System.IAsyncResult result)
        {
            return base.Channel.EndsearchUser(result);
        }
        
        public string connexion(ChristmasVillageBO.UserBO user)
        {
            return base.Channel.connexion(user);
        }
        
        public System.IAsyncResult Beginconnexion(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.Beginconnexion(user, callback, asyncState);
        }
        
        public string Endconnexion(System.IAsyncResult result)
        {
            return base.Channel.Endconnexion(result);
        }
        
        public void disconnect(ChristmasVillageBO.UserBO user)
        {
            base.Channel.disconnect(user);
        }
        
        public System.IAsyncResult Begindisconnect(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.Begindisconnect(user, callback, asyncState);
        }
        
        public void Enddisconnect(System.IAsyncResult result)
        {
            base.Channel.Enddisconnect(result);
        }
        
        public void updateUser(ChristmasVillageBO.UserBO user)
        {
            base.Channel.updateUser(user);
        }
        
        public System.IAsyncResult BeginupdateUser(ChristmasVillageBO.UserBO user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginupdateUser(user, callback, asyncState);
        }
        
        public void EndupdateUser(System.IAsyncResult result)
        {
            base.Channel.EndupdateUser(result);
        }
        
        public bool checkConnexion()
        {
            return base.Channel.checkConnexion();
        }
        
        public System.IAsyncResult BegincheckConnexion(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BegincheckConnexion(callback, asyncState);
        }
        
        public bool EndcheckConnexion(System.IAsyncResult result)
        {
            return base.Channel.EndcheckConnexion(result);
        }
    }
}
