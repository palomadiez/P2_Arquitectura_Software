using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class VehicleWithPlate : Vehicle
    {
        private string plate;
        private string typeOfVehicle;
        private float speed;
        public VehicleWithPlate(string typeOfVehicle, string plate) : base(typeOfVehicle)
        {
            this.plate = plate;
            speed = 45f;
        }

        public string GetPlate()
        {
            return plate;
        }

        public float GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        
    }
}
