namespace RouteCalculatorPackage
{
    class package
    {
        double length = null;
        double height = null;
        double width = null;
        double weight = null;
        bool reccommended = null;


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

        public double getReccommended()
        {
            return this.reccommended;
        }



    }
}