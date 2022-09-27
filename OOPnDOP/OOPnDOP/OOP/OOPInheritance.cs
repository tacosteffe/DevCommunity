using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnDOP.OOP
{
    public interface FoodType
    {
        public void Eat();
    }

    public struct Herbivore : FoodType
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats greens");
        }
    }

    public struct Carnivore : FoodType
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats meat");
        }
    }









    public interface IAnimal
    {
        public void Name();
        public void Eat();
    }

    public struct Horse<T> : IAnimal where T : struct, FoodType
    {
        public void Name()
        {
            Console.WriteLine("This is a horse");
        }

        public void Eat()
        {
            default(T).Eat();
        }
    }

    public struct Snake<T> : IAnimal where T : struct, FoodType
    {
        public void Name()
        {
            Console.WriteLine("This is a snake");
        }

        public void Eat()
        {
            default(T).Eat();
        }
    }








    public static class AnimalsShow
    {

        public static void NameTheAnimals()
        {

            List<IAnimal> animals = new List<IAnimal>();

            animals.Add(new Horse<Herbivore>());
            animals.Add(new Snake<Carnivore>());

            Console.WriteLine("\n");

            foreach (var animal in animals)
            {
                animal.Name();
                animal.Eat();
                Console.WriteLine("Name the next animal\n\n");
                Console.ReadKey();
            }
        }



    }




}
