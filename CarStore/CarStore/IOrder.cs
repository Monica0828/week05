using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    interface IOrder
    {
        int timeToRepair();

        int timeToWait();

        void cancelOrder();
    }
}
