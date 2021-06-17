namespace RouteCalculator
{
    class Vehicle
    {
        private string vehicleType = null;

        public Vehicle(string vehicleType)
        {
            setVehicleType(vehicleType);
        }

        public string getVehicleType()
        {
            return this.vehicleType;
        }

        private void setVehicleType(string vehicleType)
        {
            return this.vehicleType;
        }
    }
}