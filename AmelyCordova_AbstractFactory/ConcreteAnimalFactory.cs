using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmelyCordova_AbstractFactory
{
    //La clase ConcreteAnimalsFactory es una clase que hereda de AnimalsFactory e implementa el método GetAnimals,
    //para devolver instancias específicas de animales según el tipo especificado.
    //Es la clase concreta que se encarga de crear objetos específicos.
    class ConcreteAnimalsFactory : AnimalFactory
    {
        public override IAnimals GetAnimals(string animalType)
        {
            switch (animalType)
            {
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                case "Lion":
                    return new Lion();
                default:
                    throw new ArgumentException("Invalid animal type", nameof(animalType));
            }
        }
    }
}
