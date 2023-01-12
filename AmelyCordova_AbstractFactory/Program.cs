using AmelyCordova_AbstractFactory;

class Program
{
    //Este ejemplo muestra cómo utilizar el patrón de diseño Abstract Factory para crear
    //objetos de diferentes tipos de una manera desacoplada, permitiendo cambiar fácilmente
    //las clases concretas de los objetos creados sin afectar al código cliente.
    static void Main(string[] args)
    {
        //Se crea una instancia de ConcreteAnimalsFactory
        //y se utiliza para crear instancias de diferentes tipos de animales.
        AnimalFactory factory = new ConcreteAnimalsFactory();

        //Luego, se llama al método Speak de cada animal para verificar que
        //se estén imprimiendo los sonidos correctos.
        IAnimals dog = factory.GetAnimals("Dog");
        dog.Speak();

        IAnimals cat = factory.GetAnimals("Cat");
        cat.Speak();

        IAnimals lion = factory.GetAnimals("Lion");
        lion.Speak();

        Console.ReadLine();
    }
}