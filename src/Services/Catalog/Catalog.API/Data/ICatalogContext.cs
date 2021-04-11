﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Entities;

namespace Catalog.API.Data
{
    interface ICatalogContext
    {
        IMongoCollection<Product> Products { get;  }
    }
}