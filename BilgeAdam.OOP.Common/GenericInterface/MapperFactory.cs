using BilgeAdam.OOP.Common.GenericInterface.Mappers;
using System;

namespace BilgeAdam.OOP.Common.GenericInterface
{
    public class MapperFactory
    {
        public static IDataMapper<T> GetMapper<T>() where T : IEntity
        {
            var type = typeof(T).Name;
            switch (type)
            {
                case "Product":
                    return new ProductDataMapper() as IDataMapper<T>;
                case "Supplier":
                    return new SupplierDataMapper() as IDataMapper<T>;
                case "Category":
                    return new CategoryDataMapper() as IDataMapper<T>;

                default:
                    throw new Exception("veri okunamadı");
            }
        }
    }
}