﻿using Core.DataAccess.EntityFramework;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfUserDal: EfEntityRepositoryBase<User, RecaptProjectContext>,IUserDal
    {
       
       public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new RecaptProjectContext())
            {
                var result = from operationClaim in context.UserOperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, };
                return result.ToList();


            }
        }
    }
}
