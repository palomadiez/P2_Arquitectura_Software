namespace Practice1
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
        }


        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }
        //Implement interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}