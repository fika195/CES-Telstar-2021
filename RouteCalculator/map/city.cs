using RouteCalculatorRoad;
using System.Collections.Generic;

namespace RouteCalculatorCity
{
    class city
    {
        private string name = null;
        private List<road> roadsGoingOut = new List<road>();
        private List<road> roadsGoingIn = new List<road>();
        List<int> primeNumbers = new List<int>();

        public city(string name, List<road>  roadsGoingOut, List<road>  roadsGoingIn)
        {
            this.name = name;
            this.roadsGoingOut = roadsGoingOut;
            this.roadsGoingOut = roadsGoingIn;
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
    }
}