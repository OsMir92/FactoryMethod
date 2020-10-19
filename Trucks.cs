namespace FactoryMethod
{
    // EN: Concrete Products provide various implementations of the Product
    // interface.
    class Trucks : ITransport
    {
        public string GetDescription()
        {
            return "A really nice Truck, in fact it's the nicest Truck you will ever see." +
                "\nAnd it's on route with the assigned package.";
        }
    }
}