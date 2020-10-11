using BilgeAdam.OOP.Common.GenericInterface.Managers;
using BilgeAdam.OOP.Common.GenericInterface.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BilgeAdam.OOP.Common.GenericInterface.Mappers
{
    internal class CategoryDataMapper : IDataMapper<Category>
    {
        public List<Category> ReadAll()
        {
            var json = FileManager.Read<Category>();
            return JsonConvert.DeserializeObject<List<Category>>(json);
        }
    }
}
