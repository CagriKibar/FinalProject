﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.AbstractValidator
{
   public interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
