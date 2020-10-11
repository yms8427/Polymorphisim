using System.Collections.Generic;

namespace BilgeAdam.OOP.Common.GenericInterface
{
    public interface IDataMapper<T> where T: IEntity
    {
        List<T> ReadAll();
    }
}
