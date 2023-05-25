using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace ConsoleApp3
{
    class SingleInheritance
    {
        static void Main(String[] args)
        {
            Dog d = new Dog("Dog", 4, "Labrador");
            Console.WriteLine($"Species is {d.Species} and Age is {d.Age} and Breed is {d.Breed}");
            d.AnimalSounds();
            d.Bark();
            Console.ReadLine();
        }
    }

    class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }

        public Animal(string species, int age)
        {
            Species = species;
            Age = age;
        }

        public void AnimalSounds()
        {
            Console.WriteLine("The animal makes sounds");
        }
    }

    class Dog : Animal
    {
        public string Breed{get;set;}

        public Dog(string species, int age,string breed):base( species, age)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("The dog barks");
        }
    }
}

    */