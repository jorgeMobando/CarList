using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarList
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Car> list = new List<Car>();

            Car car1 = new Car();
            car1.Brand = "Chevrolet";
            car1.Model = 2022;
            car1.Color = "Black";
            list.Add(car1);

            Car car2 = new Car();
            car2.Brand = "Renault";
            car2.Model = 2016;
            car2.Color = "Blue";
            list.Add(car2);

            Car car3 = new Car();
            car3.Brand = "Ford";
            car3.Model = 2015;
            car3.Color = "Green";
            list.Add(car3);

            var listFilter = list.Where(x => x.Model >= 2017);

            if (listFilter == null || !listFilter.Any())
            {
                Console.WriteLine("No hay carros de maximo hace 5 años");
            }
            else
            {
                foreach (var car in listFilter)
                {
                    Console.WriteLine(car.Brand);
                }
            }
                      

            Console.ReadLine();

           
        }
    }

}
