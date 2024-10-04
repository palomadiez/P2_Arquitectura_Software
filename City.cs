using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class City : IMessageWritter
    {
        private PoliceStation policeStation = new PoliceStation();
        private List<Taxi> taxis = new List<Taxi>();

        public virtual string WriteMessage(string message)
        {
            return $"City: {message}";
        }
        

        public void RegisterTaxi(Taxi taxi)
        {
            if (taxis.Contains(taxi))
            {
                Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} is already registered."));
            }
            else
            {
                taxis.Add(taxi);
                Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} has been registered."));
            }
            
        }

        public void RemoveTaxi(Taxi taxi)
        {
            if (taxis.Contains(taxi))
            {
                taxis.Remove(taxi);
                Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} has been removed."));
            }
            else
            {
                Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} has already been removed."));
            }
        }
    }
}
