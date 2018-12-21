using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Program
    {
        public static void InitializeStore1(Store store, List<CarPrice> list)
        {
            list.Add(new CarPrice(new Car("Ford Focus", 2015), store, 15000, 4));
            list.Add(new CarPrice(new Car("Ford Focus", 2017), store, 11000, 5));
            list.Add(new CarPrice(new Car("Ford Mondeo", 2000), store, 14000, 2));
            list.Add(new CarPrice(new Car("Opel Astra", 2015), store, 14000, 1));
            list.Add(new CarPrice(new Car("Golf VI", 2011), store, 14000, 0));
        }

        public static void InitializeStore2(Store store, List<CarPrice> list, List<CarProblem> list2)
        {
            list.Add(new CarPrice(new Car("Ford Focus", 2015), store, 13000, 3));
            list.Add(new CarPrice(new Car("Ford Focus", 2017), store, 20000, 5));
            list.Add(new CarPrice(new Car("Ford Mondeo", 2000), store, 14000, 4));
            list.Add(new CarPrice(new Car("Opel Astra", 2015), store, 10000, 0));
            list.Add(new CarPrice(new Car("Golf VI", 2011), store, 16000, 1));

            list2.Add(new CarProblem("small problem on spoiler", 2));
            list2.Add(new CarProblem("big problem on spoiler", 10));
        }

        static void Main(string[] args)
        {
            var customer = new Customer("Alex");
            var listOfCarsFromStore1 = new List<CarPrice>();
            var listOfCarsFromStore2 = new List<CarPrice>();
            var listOfOrders = new List<CarPrice>();
            var listOfProblems2 = new List<CarProblem>();
            
            Console.WriteLine("What car do you want to buy?");
            var model1 = Console.ReadLine();
            Console.WriteLine("What should be the year of the car?");
            var year1 = Convert.ToInt32(Console.ReadLine());
            var car1 = new Car(model1, year1);

            Console.WriteLine("From what shop do you want to buy the car?");
            var shop1 = Console.ReadLine();
            var store1 = new Store(shop1, "Bucuresti");

            InitializeStore1(store1, listOfCarsFromStore1);           
            CarPrice foundCar = store1.findCarInStore(car1, listOfCarsFromStore1);
            if(foundCar!=null)
            {
                listOfOrders.Add(foundCar);
            }
            Console.WriteLine("Car was found in store. Order was placed.You should search your option in another store.");
            Console.WriteLine();
            Console.WriteLine("From what shop do you want to buy the car?");
            var shop2 = Console.ReadLine();
          
            var store2 = new Store(shop2, "Bucuresti");
            InitializeStore2(store2, listOfCarsFromStore2, listOfProblems2);
            foundCar = store1.findCarInStore(car1, listOfCarsFromStore2);
            if (foundCar != null)
            {
                listOfOrders.Add(foundCar);
            }

            CarPrice decision = customer.MakeDecision(listOfOrders);
            if(decision!=null)
            {
                Console.WriteLine("Your decision is:");
                Console.WriteLine("Store is: " + decision.Store.Name);
                Console.WriteLine("Delivery time is: " + decision.DeliveryTime);
                Console.WriteLine("Price is: " + decision.Price);
            }

            CarProblem carProblems = new CarProblem("small problem on spoiler");
            int time = carProblems.TimeToFixProblem(carProblems.Name, listOfProblems2);
            if (time >= 0)
            {
                Console.WriteLine("Time resolve the problem - " + carProblems.Name +" is " + time+" days");
            }
            else
            {
                Console.WriteLine("Problem - " + carProblems.Name + " can't be resolved in this store: " + store2.Name);
            }
            Console.WriteLine("Congrats! You have a new car");
            Console.ReadKey();
        }


    }
}
