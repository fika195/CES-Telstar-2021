namespace RouteCalculator
{
    class boat : vehicle
    {
        private string vehicleType = null;

        public boat()
        {
            setVehicleType("boat");
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