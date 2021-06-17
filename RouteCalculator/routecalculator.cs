using System.Collections.Generic;
using RouteCalculatorCity;
using RouteCalculatorRoad;
using TLPD.RouteCalculator.vehicles;
using RouteCalculatorRoute;
using RouteCalculatorPackage;
using RouteCalculatorCustomer;
using System.IO;
using System;
using TLPD.RouteCalculator;

namespace TLPD.routecalculator
{
    public class routecalculator
    {
        city startCity = null;
        city endCity = null;
        city[] map = new city[32]; // number of cities
        route optimalRoute = null;
        package packageToDeliver = null;
        double telstarLogicEarnings = -1;
        double totalPrice = -1;
        customer customer = null;
        public double[][] cityMatrix = null;
        public string[][] cityNameMatrix = null;
        List<string> WaterCityNames = createWaterCities();

       static private List<string> createWaterCities()
        {
            List<string> WaterCityNames = new List<string>();
            WaterCityNames.Add("Amatave");
            WaterCityNames.Add("De Kanariske Øer");
            WaterCityNames.Add("St. Helena");
            WaterCityNames.Add("Kap Guardafui");
            return WaterCityNames;
        }

        public routecalculator(double price)
        {
            this.totalPrice = price;
        }

        private void initializeMap()
        {
            List<road> roadList = createRoadList();

            List<road> outgoingRoads = new List<road>();
            List<road> ingoingRoads = new List<road>();
            string nameofLastCity = "";
            city currentCity = null;

            List<city> cityList = new List<city>();
            foreach (road r in roadList)
            {
                if (!cityList.Contains(new city(r.getFromCity())))
                {
                    cityList.Add(new city(r.getFromCity()));
                }
            }
            int i = 0;
            int j = 0;
            foreach (city c in cityList)
            {
                foreach (road r in roadList)
                {
                    if (r.getFromCity().Equals(c.getName()))
                    {
                        cityMatrix[i][j] = r.getDuration();
                        cityNameMatrix[i][j] = c.getName();
                        c.addRoadGoingout(r);
                    }
                    j++;
                }
                i++;
            }
        }

        private List<road> createRoadList()
        {
            List<road> roads = new List<road>();

            using (var reader = new StreamReader(@"data\CES_Case_Logical_Datamodel.xlsx"))
            {
                string oldCityName = "";

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

                    vehicle currentvehicle = null;
                    if (vehicleType.Equals("Plane"))
                    {
                        currentvehicle = new plane();
                    }
                    if (vehicleType.Equals("Boat"))
                    {
                        currentvehicle = new boat();
                    }
                    else
                    {
                        currentvehicle = new car();
                    }

                    roads.Add(new road(0, Int32.Parse(values[2]), fromCity, toCity, currentvehicle));
                }
            }


            return roads;
        }



        public void InitializeSingleSource(city[] cities, city startCity)
        {
            foreach (city c in cities)
            {
                c.distance = int.MaxValue;
                c.previousCity = null;
            }
            startCity.distance = 0;
        }

        public void Relax(city u, city v, double weight)
        {
            if (v.distance > u.distance + weight)
            {
                v.distance = u.distance + weight;
                v.previousCity = u;
            }
        }


        public List<city> Dijkstra(city[] vertices, double[][] graph, int source)
        {
            InitializeSingleSource(vertices, vertices[source]);
            List<city> result = new List<city>();
            //adding all vertex to priority queue
            PriorityQueue<city> queue = new PriorityQueue<city>(true);
            for (int i = 0; i < vertices.Length; i++)
                queue.Enqueue(Convert.ToInt32(vertices[i].distance), vertices[i]);

            //treversing to all vertices
            while (queue.Count > 0)
            {
                        int i = 0;
                var u = queue.Dequeue();
                result.Add(u);
                //again traversing to all vertices
                for (int v = 0; v < graph[i].Length; v++)
                {
                    if (graph[i][v] > 0)
                    {
                        Relax(u, vertices[v], graph[i][v]);
                        //updating priority value since distance is changed
                        queue.UpdatePriority(vertices[v], Convert.ToInt32(vertices[v].distance));
                    }
                }
            }
            return result;
        }

        private int getindeces(string cityName)
        {
            for (int i = 0;  i < 32; i++)
            {
                if (cityNameMatrix[i][0] == cityName)
                {
                    return i;
                }
            }
            return -1;
        }


        private void createMap(string filepath)
        {

        }

        public void updatePrice(double newPrice)
        {
            
        }

        public void PrintPath(city u, city v, List<city> vertices)
        {
            if (v != u)
            {
                PrintPath(u, v.previousCity, vertices);
                Console.WriteLine("city {0} weight: {1}", v.getName(), v.distance);
            }
            else
                Console.WriteLine("Vertax {0} weight: {1}", v.getName(), v.distance);
        }

        public double runRouteCalc(string startCityName, string endCityName, double price, package packageToDeliver)
        {
            initializeMap();

            int index = getindeces(startCityName);
            if (index == -1)
            {
                return -1; // city does not exist
            }

            List<city> res = Dijkstra(this.map, cityMatrix, index);

            city startresCity = null;
            city endresCity = null;

            foreach (city c in res)
            {
                if (c.getName() == startCityName)
                {
                    startresCity = c;
                }
                if (c.getName() == endCityName)
                {
                    endCity = c;
                }
            }

            PrintPath(startresCity, endresCity, res);

            return endCity.distance;
        }
    }
}