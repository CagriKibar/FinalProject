﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.AbstractValidator
{
   public interface IBrandService
    {
        List<Brand> GetAll();
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);

    }
}
