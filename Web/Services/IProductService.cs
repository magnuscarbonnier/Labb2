﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IProductService
    {
        Task<Product> GetById(Guid Id);
        Task<List<Product>> GetAll();
    }
}
