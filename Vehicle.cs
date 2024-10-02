namespace Practice1
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        private float speed;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            speed = 0f;
        }

        public virtual string GetPlate()
        {
            return null;
        }

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        //Implement interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()}";
        }
    }
}