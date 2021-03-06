﻿using BilgeAdam.OOP.Common.GenericInterface.Managers;
using BilgeAdam.OOP.Common.GenericInterface.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BilgeAdam.OOP.Common.GenericInterface.Mappers
{
    internal class ProductDataMapper : IDataMapper<Product>
    {
        public List<Product> ReadAll()
        {
            var json = FileManager.Read<Product>();
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }
    }
}
