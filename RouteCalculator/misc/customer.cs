namespace RouteCalculatorCustomer
{
    class customer
    {
        private string name = null;
        private double discount = null;

        public customer(string name, double discount)
        {
            this.name = name;
            this.discount = discount;
        }

        public string getName()
        {
            return this.name;
        }

        public string getdiscount()
        {
            return this.discount;
        }

    }
}