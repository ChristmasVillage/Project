﻿using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    /*
     * Déclaration Interface des méthode pour Factory
     */

    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/FactoryIFAC")]
    public interface FactoryIFAC
    {
        [OperationContract]
        void createFactory(FactoryBO factory);

        [OperationContract]
        void updateFactory(FactoryBO factory);

        [OperationContract]
        FactoryBO getLastFactory();

        [OperationContract]
        void deleteFactory(int id_Factory);

        [OperationContract]
        FactoryBO findFactory(int id_factory);

        [OperationContract]
        void productToys(FactoryBO factory, UserBO user);

        [OperationContract]
        void salesProduct(FactoryBO factory, UserBO user);

        [OperationContract]
        bool checkStatus(FactoryBO factory);
    }
}
