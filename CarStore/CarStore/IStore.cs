using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    interface IStore
    {
        CarPrice findCarInStore(Car car, List<CarPrice> list);
    }
}
