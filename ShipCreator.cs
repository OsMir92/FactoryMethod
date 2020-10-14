namespace FactoryMethod
{
    class ShipCreator : Creator
    {
        public override ITransport FactoryMethod => new Ships();
    }
}