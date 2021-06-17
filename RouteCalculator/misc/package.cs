namespace RouteCalculatorPackage
{
    public class package
    {
        double length = -1;
        double height = -1;
        double width = -1;
        double weight = -1;
        bool reccommended = false;


        public package(double length, double height, double width, double weight, bool reccommended)
        {
            this.length = length;
            this.height = height;
            this.width = width;
            this.weight = weight;
            this.reccommended = reccommended;
        }

        public double getlength()
        {
            return this.length;
        }

        public double getheight()
        {
            return this.height;
        }

        public double getweight()
        {
            return this.weight;
        }

        public bool getReccommended()
        {
            return this.reccommended;
        }



    }
}