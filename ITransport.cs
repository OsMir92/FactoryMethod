namespace FactoryMethod
{
    public interface ITransport
    {
        /*La interface declara las operaciones que todos
         los productos concretos deben implementar.*/
        string GetDescription();
    }
}