using BilgeAdam.OOP.Common.GenericInterface;
using BilgeAdam.OOP.Common.GenericInterface.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BilgeAdam.Northwind.App.Managers
{
    internal static class FileManager
    {
        static FileManager()
        {
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
        }

        public static string Read<T>() where T: IEntity
        {
            var path = $@"data\{typeof(T).Name.ToLower()}.json";
            return File.ReadAllText(path);
        }

        public static void SaveCategories(List<Category> categories)
        {
            var path = @"data\category.json";
            var json = JsonConvert.SerializeObject(categories);
            WriteToFile(path, json);
        }

        public static void SaveProducts(List<Product> products)
        {
            var path = @"data\product.json";
            var json = JsonConvert.SerializeObject(products);
            WriteToFile(path, json);
        }

        public static void SaveSuppliers(List<Supplier> suppliers)
        {
            var path = @"data\supplier.json";
            var json = JsonConvert.SerializeObject(suppliers);
            WriteToFile(path, json);
        }

        private static void WriteToFile(string path, string data)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, data);
            }
        }
    }
}