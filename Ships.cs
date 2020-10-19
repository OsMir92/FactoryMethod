namespace FactoryMethod
{
    class Ships : ITransport
    {
        public string GetDescription()
        {
            return "A super imposing Ship! It's on it's way to deliver the assigned package.";
        }
    }
}