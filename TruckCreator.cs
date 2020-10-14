namespace FactoryMethod
{
    // El Concrete Creator sobrecarga el factory method para asi
    // poder cambiar el tipo de producto.
    class TruckCreator : Creator
    {
        /* Se usa el tipo de producto abstracto y retorna el concreto asi el Creator
        se puede mantener independiente de las clases producto concretas.*/
        public override ITransport FactoryMethod => new Trucks();
    }
}