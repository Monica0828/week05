using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Customer
    {
        public Customer(string name)
        {
            Name = name;
            PriceRangeMin = 12000;
            PriceRangeMax = 15000;

        }
        public string Name { get; set; }

        public int PriceRangeMin { get; set; }

        public int PriceRangeMax { get; set; }

        public CarPrice MakeDecision(List<CarPrice> list)
        {
            foreach (var item in list)
            {
                if (list.First().DeliveryTime < list.Last().DeliveryTime && list.First().Price < list.Last().Price)
                {
                    return list.First();
                }
                else

                if (list.First().DeliveryTime < list.Last().DeliveryTime &&
                        list.First().Price > list.Last().Price)
                {
                    return list.First();
                }
                else

                if (list.First().DeliveryTime > list.Last().DeliveryTime &&
                        list.First().Price < list.Last().Price)
                {
                    return list.First();
                }

                else
                {
                    return list.Last();
                    
                }                 
            }
            return null;
        }
    }
}
