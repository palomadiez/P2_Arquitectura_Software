using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Scooter : VehicleWithoutPlate
    {
        private const string typeOfVehicle = "Scooter";
        private static float speed;

        public Scooter() : base(typeOfVehicle, speed)
        {
        }

        
    }
}