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
        }
        public string Name { get; set; }


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
