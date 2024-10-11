using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    public class CarManager
    {



        public List<Car> Carslist = new List<Car>();

        public void CreateCar(int carId, string brand, string model, decimal rentalPrice)
        {
            Car car = new Car(carId, brand, model, rentalPrice);
            Carslist.Add(car);
            Console.WriteLine("Car added successfully");
        }

        public void ReadCars()
        {
            if (Carslist.Count > 0)
            {
                foreach (Car car in Carslist)
                {
                    Console.WriteLine("View all car");
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("There are no car abailable");
            }
        }
        public void UpdateCar(int carId, string upbrand, string upmodel, decimal uprentalPrice)
        {
            Car car = Carslist.FirstOrDefault(c => c.CarId == carId);
            if (car != null)
            {
                car.Brand = upbrand;
                car.Model = upmodel;
                car.RentalPrice = uprentalPrice;
                Console.WriteLine("Car update successfully");
            }
            else
            {
                Console.WriteLine("There are no car abailable");
            }


        }
        public void DeleteCar(int carId)
        {
            Car car = Carslist.FirstOrDefault(c => c.CarId == carId);
            if (car != null)
            {
                Carslist.Remove(car);
                Console.WriteLine("Car delete successfully");
            }
            else
            {
                Console.WriteLine("There are no car abailable");
            }

        }
        public decimal ValidateCarRentalPrice()
        {
            decimal price;
            while (true)
            {
                Console.WriteLine(" Enter the Rental price");
                if (decimal.TryParse(Console.ReadLine(), out price) && price > 0)
                {
                    return price;
                }
                Console.WriteLine("Invalid price!! please enter positive number value");
            }

        }
    }
}
