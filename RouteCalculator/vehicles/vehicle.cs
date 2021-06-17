namespace TLPD.RouteCalculator.vehicles
{
    class vehicle
    {
        private string vehicleType = null;

        public string getVehicleType()
        {
            return this.vehicleType;
        }

        private void setVehicleType(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }
    }

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
            this.vehicleType = vehicleType;
        }
    }

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
            this.vehicleType = vehicleType;
        }
    }

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
            this.vehicleType = vehicleType;
        }
    }
}