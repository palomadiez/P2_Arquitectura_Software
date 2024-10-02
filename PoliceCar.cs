using System.Diagnostics.Metrics;

namespace Practice1
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private bool isChasing;
        private PoliceStation policeStation;

        public PoliceCar(string plate, PoliceStation policeStation, SpeedRadar? speedRadar = null) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            this.speedRadar = speedRadar;
            isChasing = false;
            this.policeStation = policeStation;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                if (speedRadar != null)
                {
                    string plate = speedRadar.TriggerRadar(vehicle);
                    (string, bool) meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement.Item1}"));
                    if (meassurement.Item2 == true)
                    {
                        policeStation.ActivateAlert(plate);
                        StartChasing();
                    }
                }
                else
                {
                    Console.WriteLine(WriteMessage($"not equipped with a radar."));
                }
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public bool IsChasing()
        {
            return isChasing;
        }

        public void SetIsChasing(bool chasing)
        {
            isChasing=chasing;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void StartChasing()
        {

            if (isChasing == false)
            {
                isChasing = true;
                Console.WriteLine(WriteMessage("started chasing."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already chasing."));
            }
        }   

         public void ReceiveAlert()
        {
            StartChasing();
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            if (speedRadar != null)
            {
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
        }
    }
}