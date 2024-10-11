using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class PetrolCar: Car
    {



            public string FuelTankCapacity { get; set; }
            public string EngineCapacity { get; set; }
            public PetrolCar(int carId, string brand, string model, decimal rentalPrice, string fuelTankCapacity, string engineCapacity) : base(carId, brand, model, rentalPrice)
            {
                FuelTankCapacity = fuelTankCapacity;
                EngineCapacity = engineCapacity;
            }

            public string DisplayPetrolCarInfo()
            {
                return $"FuelTankCapacity:{FuelTankCapacity},EngineCapacity:{EngineCapacity}";
            }
            public override string DidplayCarInfo()
            {
                return base.DidplayCarInfo() + this.DisplayPetrolCarInfo();

            }
        
    }
}
