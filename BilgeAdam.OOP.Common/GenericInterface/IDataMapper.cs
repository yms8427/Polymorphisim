using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Common.GenericInterface
{
    interface IDataMapper<T> where T: IEntity
    {
        List<T> ReadAll(string rawData);
    }
}
