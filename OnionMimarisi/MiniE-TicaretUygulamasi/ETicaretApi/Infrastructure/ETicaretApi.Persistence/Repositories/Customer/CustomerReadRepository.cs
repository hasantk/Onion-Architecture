﻿using ETicaretApi.Application.Repositories;
using ETicaretApi.Domain.Entities;
using ETicaretApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Custemor>,ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
