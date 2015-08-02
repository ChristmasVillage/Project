﻿using ChristmasVillageBO;
using ChristmasVillageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBL
{
    public class FactoryTypeBL
    {
        public static List<FactoryTypeBO> selectAll ()
        {
            try
            {
                List<FactoryTypeBO> listFactories = new List<FactoryTypeBO>();
                FactoryTypeDAL dal = new FactoryTypeDAL(CUtil.GetConnexion());
                listFactories = dal.FactoryTypeBO_SelectAll().ToList();
                return listFactories;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static FactoryTypeBO FindById(int factoryTypeId)
        {
            try
            {
                List<FactoryTypeBO> listResult = new List<FactoryTypeBO>();
                FactoryTypeBO result = new FactoryTypeBO();
                FactoryTypeDAL dal = new FactoryTypeDAL(CUtil.GetConnexion());
                listResult = dal.FactoryTypeBO_FindById(factoryTypeId).ToList();
                result = listResult.FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
