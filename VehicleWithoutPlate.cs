namespace Practice1
{
    abstract class VehicleWithoutPlate : Vehicle
    {
        private string typeOfVehicle;
        private float speed;

        public VehicleWithoutPlate(string typeOfVehicle, float speed) : base(typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            speed = 0f;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()}";
        }
    }
}
