using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Order : IOrder
    {

        public Order(CarPrice foundCar)
        {
            FoundCar = foundCar;
        }
        public CarPrice FoundCar { get; set; }

        public void cancelOrder()
        { 

        }

        public int timeToRepair()
        {
            return 0;
        }

        public int timeToWait()
        {
            return 1;
        }


    }
}
