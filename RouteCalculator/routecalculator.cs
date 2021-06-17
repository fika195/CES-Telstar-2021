using System.Collections.Generic;
using RouteCalculatorCity;
using RouteCalculatorRoad;
using TLPD.RouteCalculator.vehicles;
using RouteCalculatorRoute;

namespace routecalculator
{
    class routecalculator
    {
        city startCity = null;
        city endCity = null;
        List<city> map = new List<city>();
        route optimalRoute = null;
        package packageToDeliver = null;
        double telstarLogicEarnings = -1;
        double totalPrice = -1;
        customer customer = null;
        List<String> WaterCityNames = new List<String>().Add("St. Helena").Add("Kap Guardafui").Add("Amatave").add("De Kanariske �er");

        List<road> initializeMap(string filepath)
        {
            List<road> roadList = createRoadList(filepath);

            List<roads> outgoingRoads = new List<roads>();
            List<roads> ingoingRoads = new List<roads>();
            nameofLastCity = "";
            city currentCity = null;

            List<city> cityList = new List<city>();
            foreach (road r in roadList)
            {
                if (!cityList.Contains(r.getFromCity()))
                {
                    cityList.Add(new city(r.getFromCity()));
                }
             
            }

                foreach (city c in cityList)
            {
                foreach (road r in roadList)
                {
                    if (r.getFromCity() == c.getName())
                    {
                        c.addRoadGoingOut(r);
                    }
                    if (r.getToCity() == c.getName())
                    {
                        c.addRoadGoingIn(r);
                    }
                }
            }
        }

        private List<road> createRoadList(string filepath)
        {
            List<road> roads = new List<road>();

            using (var reader = new StreamReader(@"data\CES_Case_Logical_Datamodel.xlsx"))
            {
                oldCityName = "";

                List<string> fromList = new List<string>();
                List<string> toList = new List<string>();
                List<string> SegmentsList = new List<string>();
                List<string> typeList = new List<string>();
                List<string> PriceList = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    string fromCity = (values[0]);
                    string toCity = (values[1]);

                    SegmentsList.Add(values[2]);
                    string vehicleType = values[3];
                    PriceList.Add(values[4]);


                    if (vehicleType = "Plane")
                    {
                        plane vehicle = new plane();
                    }
                    if (vehicleType = "Boat")
                    {
                        boat vehicle = new boat();
                    }
                    else
                    {
                        car vehicle = new Car();
                    }

                    roads.Add(new road(0, values[2], fromCity, toCity, vehicle));
                }
            }


            return roads;
        }



        public static void InitializeSingleSource(city[] cities, city startCity)
        {
            foreach (city c in cities)
            {
                c.distance = int.MaxValue;
                c.previousCity = null;
            }
            startCity.distance = 0;
        }

        public static void Relax(city u, city v, int weight)
        {
            if (v.distance > u.distance + weight)
            {
                v.distance = u.distance + weight;
                v.prevous_city = u;
            }
        }



        public static List<city> ModifiedDijkstra(city[] cities, int[][] graph, city startCity)
        {
            InitializeSingleSource(cities, startCity);
            List<route> allPossibleRoutes = new List<route>();



            //adding all cities to priority queue
            PriorityQueue.PriorityQueue<city> queue = new PriorityQueue.PriorityQueue<city>(true);
            for (int i = 0; i < cities.Length; i++)
                queue.Enqueue(cities[i].distance, cities[i]);

            //traversing to all cities
            while (queue.Count > 0)
            {
                var u = queue.Dequeue();
                result.Add(u);
                //again traversing to all cities
                for (int v = 0; v < graph[Convert.ToInt32(u.Name)].Length; v++)
                {
                    if (graph[Convert.ToInt32(u.Name)][v] > 0)
                    {
                        Relax(u, cities[v], graph[Convert.ToInt32(u.Name)][v]);
                        //updating priority value since distance is changed
                        queue.UpdatePriority(cities[v], cities[v].D);
                    }
                }
            }
            return result;
        }




        private road getBestRoute(city currentCity, city TargetCity, route currentRoute, List<rout> allRoutes)
        {
           
            int leastSegments = 9999; // magic = bad
            foreach (road r in currentCity.getOutgoingRoads())
            {
                if (r.getSegments() < leastSegments)
                {
                    BestRoad = r;
                    leastSegments = r.getSegments();
                }
            }
            return BestRoad;
        }
        




        private void createMap(string filepath)
        {

        }

        public void updatePrice(double newPrice)
        {
            
        }



    }
}