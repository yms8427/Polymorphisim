using BilgeAdam.OOP.Common.GenericInterface.Models;
using System.Collections.Generic;

namespace BilgeAdam.OOP.Common.GenericInterface.Mappers
{
    public class ProductDataMapper : IDataMapper<Product>
    {
        public List<Product> ReadAll(string rawData)
        {
            return new List<Product>();
        }
    }
}
