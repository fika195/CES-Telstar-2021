namespace RouteCalculator
{
    class plane : vehicle
    {
        private string vehicleType = null;

        public plane()
        {
            setVehicleType("plane");
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