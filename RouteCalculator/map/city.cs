using RouteCalculatorRoad;
using System.Collections.Generic;

namespace RouteCalculatorCity
{
    class city
    {
        string name = null;
        List<road> roadsGoingOut = new List<road>();
        List<road> roadsGoingIn = new List<road>();
        city previousCity = null; // used to tell where the vehicle moved from, to this city
        double distance = -1; // distance from the start_city of a route


        public city(string name, List<road>  roadsGoingOut, List<road>  roadsGoingIn)
        {
            this.name = name;
            this.roadsGoingOut = roadsGoingOut;
            this.roadsGoingOut = roadsGoingIn;
        }

        public city(string name)
        {
            this.name = name;
        }

        public List<road> getRoadsGoingOut()
        {
            return this.roadsGoingOut;
        }

        public List<road> getRoadsGoingIn()
        {
            return this.roadsGoingIn;
        }

        public string getName()
        {
            return this.name;
        }


        public void addRoadGoingIn(road newRoad)
        {
            this.roadsGoingIn.Add(newRoad);
        }

        public void addRoadGoingout(road newRoad)
        {
            this.roadsGoingOut.Add(newRoad);
        }
    }
}