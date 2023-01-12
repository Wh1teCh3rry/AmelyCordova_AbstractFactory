using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmelyCordova_AbstractFactory
{
    //La clase AnimalFactory es la fábrica abstracta, que tiene un método abstracto llamado GetAnimals.
    //Toma un tipo de animal como parámetro y devuelve un objeto de la interfaz IAnimals.
    //Esta clase se encarga de definir la interfaz para crear objetos,
    //pero no se sabe que objetos se van a crear.
    abstract class AnimalFactory
    {
        public abstract IAnimals GetAnimals(string animalType);
    }

    //La interfaz IAnimals tiene un método llamado Speak,
    //que es implementado por las clases de animales: Dog, Cat, Lion y Elephant
    interface IAnimals
    {
        void Speak();
    }
}