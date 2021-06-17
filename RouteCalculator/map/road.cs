using RouteCalculatorCity;
using TLPD.RouteCalculator.vehicles;

namespace RouteCalculatorRoad
{
    public class road
    {
        private int id = -1;
        private int segments = -1;
        private string fromCity = "";
        private string toCity = "";
        private vehicle roadType = null;
        private car fisk = new car();
        private double price = -1;
        private double duration = -1;



        public road(int id, int segments, string fromCity, string toCity, vehicle roadType)
        {

            this.id = id;
            this.segments = segments;
            this.fromCity = fromCity;
            this.toCity = toCity;
            this.roadType = roadType;

        }

        public road(int id, int segments, double price, string fromCity, string toCity, vehicle roadType)
        {

            this.id = id;
            this.segments = segments;
            this.price = price;
            this.fromCity = fromCity;
            this.toCity = toCity;
            this.roadType = roadType;
        }

        public string getFromCity()
        {
            return this.fromCity;
        }

        public string getToCity()
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