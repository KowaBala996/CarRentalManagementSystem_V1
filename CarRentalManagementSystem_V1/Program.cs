using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();
            Console.Clear();
            bool exit = false;
            

            while (!exit)
            {
                Console.WriteLine("Car Rental Management System:");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. View All Cars");
                Console.WriteLine("3. Update a Car");
                Console.WriteLine("4. Delete a Car");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        CreateCar(carManager);

                        break;
                    case 2:
                        carManager.ReadCars();
                        break;
                    case 3:
                        UpdateCar(carManager);
                        break;
                    case 4:
                        DeleteCar(carManager);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void CreateCar(CarManager mngr)
        {
            Console.WriteLine("Enter the carid");
            int carid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Brand");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the Model");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the RentalPrice");
            int rentalPrice = int.Parse(Console.ReadLine());
            mngr.CreateCar(carid, brand, model, rentalPrice);
        }
        static void UpdateCar(CarManager mngr)
        {
            Console.WriteLine("Enter the update carid");
            int upcarid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Brand");
            string upbrand = Console.ReadLine();

            Console.WriteLine("Enter the Model");
            string upmodel = Console.ReadLine();

            Console.WriteLine("Enter the RentalPrice");
            int uprentalPrice = int.Parse(Console.ReadLine());
            mngr.UpdateCar(upcarid, upbrand, upmodel, uprentalPrice);


        }
        static void DeleteCar(CarManager mngr)
        {
            Console.WriteLine("Enter the update carid");
            int deletecarid = int.Parse(Console.ReadLine());
            mngr.DeleteCar(deletecarid);
        }
    }
    
}
