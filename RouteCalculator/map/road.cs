using RouteCalculatorCity;
using TLPD.RouteCalculator.vehicles;

namespace RouteCalculatorRoad
{
    class road
    {
        private int id = -1;
        private int segments = -1;
        private city fromCity = null;
        private city toCity = null;
        private vehicle roadType = null;
        private double price = -1;
        private double duration = -1;



        public road(int id, int segments, city fromCity, city toCity, vehicle roadType)
        {

            this.id = id;
            this.segments = segments;
            this.fromCity = fromCity;
            this.toCity = toCity;
            this.roadType = roadType;
        }

        public road(int id, int segments, double price, city fromCity, city toCity, vehicle roadType)
        {

            this.id = id;
            this.segments = segments;
            this.price = price;
            this.fromCity = fromCity;
            this.toCity = toCity;
            this.roadType = roadType;
        }

        public city getFromCity()
        {
            return this.fromCity;
        }

        public city getToCity()
        {
            return this.toCity;
        }

        public vehicle getRoadType()
        {
            return this.roadType;
        }

        public int getId()
        {
            return this.id;
        }

        public int getSegments()
        {
            return this.segments;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public double getDuration()
        {
            return this.duration;
        }

        public void setDuration(double duration)
        {
            this.duration = duration;
        }

    }
}