using RouteCalculatorRoad;
using System.Collection.Generic;

namespace RouteCalculatorCity
{
    class city
    {
        private string name = null;
        private List<Road> roadsGoingOut = new List<Road>();
        private List<Road> roadsGoingIn = new List<Road>();

        public city(string name, List<Road>  roadsGoingOut, List<Road>  roadsGoingIn)
        {
            this.name = name;
            this.roadsGoingOut = roadsGoingOut;
            this.roadsGoingOut = roadsGoingIn;
        }

        public string getRoadsGoingOut()
        {
            return this.roadsGoingOut;
        }

        public string getRoadsGoingIn()
        {
            return this.roadsGoingIn;
        }

        public string getName()
        {
            return this.roadsGoingIn;
        }
    }
}