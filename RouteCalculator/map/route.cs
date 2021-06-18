using System.Collections.Generic;
using RouteCalculatorCity;
using RouteCalculatorRoad;

namespace RouteCalculatorRoute
{
    public class route
    {
        private List<road> roads = new List<road>();
        private double totalPrice = -1;
        private string duration = null;
        private double totalTelstarEarnings = -1;


        public route(List<road> roads)
        {
            this.roads = roads;
        }

        public List<road> getRoads()
        {
            return this.roads;
        }

        public string getDuration()
        {
            return this.duration;
        }

        public void setDuration(string duration)
        {
            this.duration = duration;
        }

        public string getTotalPrice()
        {
            return this.duration;
        }

        public void setTotalPrice(double totalPrice)
        {
            this.totalPrice = totalPrice;
        }

        public double getTelstarEarnings()
        {
            return this.totalTelstarEarnings;
        }

        public void setTotalTelstarEarnings(double totalTelstarEarnings)
        {
            this.totalTelstarEarnings = totalTelstarEarnings;
        }

        public void addRoad(road newRoad)
        {
            this.roads.Add(newRoad);
        }

    }
}