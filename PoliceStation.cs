using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class PoliceStation
    {
        private List<PoliceCar> policeCars;
        private bool alert;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
            this.alert = false;
        }

        public virtual string WriteMessage(string message)
        {
            return $"Police Station: {message}";
        }


        public void RegisterPoliceCars(PoliceCar policeCar)
        {
            if (policeCars.Contains(policeCar))
            {
                Console.WriteLine(WriteMessage($"Police car with plate {policeCar.GetPlate()} is already registered."));
            }
            else
            {
                policeCars.Add(policeCar);
                Console.WriteLine(WriteMessage($"Police car with plate {policeCar.GetPlate()} has been registered."));
            }
        }

        public void ActivateAlert(string plate)
        {
            alert = true;
            Console.WriteLine(WriteMessage($"The alert has been activated. Start chasing car with plate {plate}."));
            NotifyPoliceCars();
        }

        public void NotifyPoliceCars()
        {
            foreach (var policeCar in policeCars)
            {
                if (policeCar.IsPatrolling())
                {
                    policeCar.ReceiveAlert();
                }
            }
        }

        public void StopChasing()
        {
            foreach (PoliceCar police in policeCars)
            {
                if (police.IsChasing() == true)
                {
                    police.SetIsChasing(false);
                    Console.WriteLine(WriteMessage($"Police car with plate {police.GetPlate()} stopped chasing."));
                }
                else
                {
                    Console.WriteLine(WriteMessage($"Police car with plate {police.GetPlate()} is not chasing."));
                }
            }
        }

    }
}
