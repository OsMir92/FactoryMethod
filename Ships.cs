namespace FactoryMethod
{
    class Ships : ITransport
    {
        public string GetDescription()
        {
            return "A super deee duper fly Ship!";
        }
    }
}