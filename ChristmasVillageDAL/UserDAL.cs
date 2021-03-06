﻿using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    /*
     * User : Déclaration des statements (stored procédures Database)
     */

    public class UserDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public UserDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[User.Insert]")]
        public ISingleResult<UserBO> UserBO_Insert(
            [Parameter(Name = "@username", DbType = "varchar(20)")] string Username,
            [Parameter(Name = "@password", DbType = "varchar(20)")] string UserPassword,
            [Parameter(Name = "@email", DbType = "varchar(60)")] string UserMail,
            [Parameter(Name = "@capital", DbType = "int")] int UserCapital,
            [Parameter(Name = "@status", DbType = "varchar(5)")] string UserStatus
             )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()),
                Username, UserPassword, UserMail, UserCapital, UserStatus);
            return ((ISingleResult<UserBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[User.Update]")]
        public ISingleResult<UserBO> UserBO_Update(
            [Parameter(Name = "@id_user", DbType = "int")] int UserId,
            [Parameter(Name = "@username", DbType = "varchar(20)")] string Username,
            [Parameter(Name = "@password", DbType = "varchar(20)")] string UserPassword,
            [Parameter(Name = "@email", DbType = "varchar(60)")] string UserMail,
            [Parameter(Name = "@capital", DbType = "int")] int UserCapital,
            [Parameter(Name = "@status", DbType = "varchar(5)")] string UserStatus
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()),
                UserId, Username, UserPassword, UserMail, UserCapital, UserStatus);
            return ((ISingleResult<UserBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[User.FindById]")]
        public ISingleResult<UserBO> UserBO_FindById(
            [Parameter(Name = "@id_user", DbType = "int")] int UserId)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), UserId);
            return ((ISingleResult<UserBO>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[User.FindByName]")]
        public ISingleResult<UserBO> UserBO_FindByName(
            [Parameter(Name = "@name", DbType = "varchar(20)")] string Username)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), Username);
            return ((ISingleResult<UserBO>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[User.CloseAll]")]
        public ISingleResult<UserBO> UserBO_CloseAll()
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())));
            return ((ISingleResult<UserBO>)(result.ReturnValue));
        }
    }
}
