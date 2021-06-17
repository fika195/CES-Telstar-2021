using System.Collection.Generic;
using RouteCalculatorCity;
using RouteCalculatorVehicles;

namespace RouteCalculatorRoad
{
    class Road
    {
        private int id = null;
        private int segments = null;
        private city fromCity = null;
        private city toCity = null;
        private vehicle roadType = null;
        private double price = null;
        private double duration = null;



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