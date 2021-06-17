namespace RouteCalculatorCustomer
{
    class customer
    {
        private string name = null;
        private double discount = -1;

        public customer(string name, double discount)
        {
            this.name = name;
            this.discount = discount;
        }

        public string getName()
        {
            return this.name;
        }

        public double getdiscount()
        {
            return this.discount;
        }

    }
}