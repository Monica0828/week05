using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Order 
    {

        public Order(CarPrice foundCar)
        {
            FoundCar = foundCar;
        }
        public CarPrice FoundCar { get; set; }


    }
}
