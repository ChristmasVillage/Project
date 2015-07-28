﻿using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/FactoryTypeIFAC")]
    public interface FactoryTypeIFAC
    {
        [OperationContract]
        List<FactoryTypeBO> selectAll();
    }
}
