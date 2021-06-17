using System.Collection.Generic;
using RouteCalculatorCity;
using RouteCalculatorRoad;

namespace RouteCalculatorRoute
{
    class route
    {
        private List<Road> roads = new List<Road>();
        private double totalPrice = null;
        private String Duration = null;
        private double totalTelstarEarnings = null;


        public route(List<Road> roads)
        {
            this.roads = roads;
        }

        public List<Road> getRoads()
        {
            return this.roads;
        }

        public String getDuration()
        {
            return this.duration;
        }

        public void setDuration(string duration)
        {
            this.duration = duration;
        }

        public String getTotalPrice()
        {
            return this.duration;
        }

        public void setTotalPrice(string totalPrice)
        {
            this.totalPrice = totalPrice;
        }

        public String getTelstarEarnings()
        {
            return this.duration;
        }

        public void setTotalTelstarEarnings(string totalTelstarEarnings)
        {
            this.totalTelstarEarnings = totalTelstarEarnings;
        }

    }
}