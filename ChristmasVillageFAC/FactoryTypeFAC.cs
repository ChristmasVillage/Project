﻿using ChristmasVillageBL;
using ChristmasVillageIFAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageFAC
{
    public class FactoryTypeFAC : FactoryTypeIFAC
    {
        // Implémentation méthode selectAll Interface FactoryType
        public List<ChristmasVillageBO.FactoryTypeBO> selectAll()
        {
            try
            {
                return FactoryTypeBL.selectAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
