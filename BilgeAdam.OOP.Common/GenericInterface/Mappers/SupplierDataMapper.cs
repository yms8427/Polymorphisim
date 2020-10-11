using BilgeAdam.OOP.Common.GenericInterface.Managers;
using BilgeAdam.OOP.Common.GenericInterface.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BilgeAdam.OOP.Common.GenericInterface.Mappers
{
    internal class SupplierDataMapper : IDataMapper<Supplier>
    {
        public List<Supplier> ReadAll()
        {
            var json = FileManager.Read<Supplier>();
            return JsonConvert.DeserializeObject<List<Supplier>>(json);
        }
    }
}
