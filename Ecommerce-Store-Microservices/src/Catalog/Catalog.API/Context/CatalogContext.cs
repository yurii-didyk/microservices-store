using Catalog.API.Context.Interfaces;
using Catalog.API.Context.Settings;
using Catalog.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Context
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(CatalogContextSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Products = database.GetCollection<Product>(settings.CollectionName);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
