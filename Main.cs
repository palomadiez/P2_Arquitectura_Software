namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            City city = new City();
            PoliceStation policeStation = new PoliceStation();
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            SpeedRadar speedRadar = new SpeedRadar();
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", policeStation, speedRadar);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", policeStation, speedRadar);
            PoliceCar policeCar3 = new PoliceCar("0003 CNP", policeStation);
            Scooter scooter = new Scooter();
            
            Console.WriteLine(city.WriteMessage("Created"));
            Console.WriteLine(policeStation.WriteMessage("Created"));
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            Console.WriteLine(policeCar3.WriteMessage("Created"));
            Console.WriteLine(scooter.WriteMessage("Created"));

            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);
            policeStation.RegisterPoliceCars(policeCar1);
            policeStation.RegisterPoliceCars(policeCar2);
            policeStation.RegisterPoliceCars(policeCar3);

            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi2);

            policeCar3.StartPatrolling();
            policeCar3.UseRadar(taxi1);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();
            policeStation.StopChasing();

            city.RemoveTaxi(taxi2);
            city.RemoveTaxi(taxi2);

            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();

        }
    }
}
    

