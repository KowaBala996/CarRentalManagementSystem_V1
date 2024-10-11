using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class ElectricCar:Car
    {
            public int BatteryCapacity { get; set; }
            public int MotorPower { get; }

            public ElectricCar(int carId, string brand, string model, decimal rentalPrice, int batteryCapacity, int motorPower) : base(carId, brand, model, rentalPrice)
            {
                BatteryCapacity = batteryCapacity;
                MotorPower = motorPower;
            }
            public string DisplayElectricCarInfo()
            {
                return $"BatteryCapacity:{BatteryCapacity},MotorPower:{MotorPower}";
            }
            public override string DidplayCarInfo()
            {
                return base.DidplayCarInfo() + this.DisplayElectricCarInfo();
            }
        }
    
    }
}
