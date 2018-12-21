using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Store: IStore
    {
        public Store(string name, string city)
        {
            Name = name;
            City = city;
        }
        public string Name { get; set; }

        public string City { get; set; }

        public CarPrice findCarInStore(Car car, List<CarPrice> list)
        {
            foreach(var elem in list)
            {
                if (elem.Car.Name.ToLower() == car.Name.ToLower() && elem.Car.Year == car.Year)
                    return elem;
            }
            return null;
        }
    }

    class CarPrice
    {
        public CarPrice(Car car, Store store, int price,int deliveryTime )
        {
            Car = car;
            Store = store;
            Price = price;
            DeliveryTime = deliveryTime;
        }

        public Car Car { get; set; }

        public Store Store { get; set; }

        public int Price { get; set; }

        public int DeliveryTime { get; set; }

    }

    class CarProblem
    {
        public CarProblem(string name)
        {
            Name = name;        
        }
        public CarProblem(string name, int time)
        {
            Name = name;
            Time = time;
        }
        public string Name { get; set; }

        public int Time { get; set; }

        public int TimeToFixProblem(string problem, List<CarProblem> lista)
        {
            foreach (var item in lista)
            {
                if(problem.ToLower()==item.Name.ToLower())
                {
                    return item.Time;
                }
            }
            return -1;
        }
    }
}
