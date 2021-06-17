namespace RouteCalculator
{
    class car : vehicle
    {
        private string vehicleType = null;

        public car()
        {
            setVehicleType("car");
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