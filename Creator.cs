namespace FactoryMethod
{
    /*La clase Creator declara el metodo que se supone debe retornar
    un objeto de una clase Producto. Las subclases de Creator
    usualmente proveen la implementacion de este metodo*/

    abstract class Creator
    {
        /*La clase Creator tambien puede proveer una 
        implementacion por default de factory method.*/

        public abstract ITransport FactoryMethod { get; }

        /*El Creator pese al nombre no tiene como responsabilidad primaria crear prductos. 
        Usualmente tiene logica que depende en objetos Producto retornados por el Factory Method. 
        Las subclases pueden cambiar esa logica por medio de sobrecarga y asi retornando un tipo distinto de producto.*/

        public string SomeDescription()
        {
            //Llama FactoryMethod para crear un objeto producto(Transporte).
            var product = FactoryMethod;
            //Usa el producto.
            var result = "The Creator class just made: "
                + product.GetDescription();
            return result;
        }
    }
}