﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserOchObjekt
{
    class Runtime
    {
        public void Start()
        {
            // Nyckelordet "new" används för att göra en ny instans (kopia/objekt) av
            // klassen Person. 
            #region OldStuff
            //Person personOne = new Person
            //{
            //    Name = "Johan",
            //    Age = 33,
            //    City = "Bromma"
            //};

            //Person personTwo = new Person
            //{
            //    Name = "Niklas",
            //    Age = 46,
            //    City = "Södertälje"
            //};

            //Person personThree = new Person("Kim", 14, "Sundsvall");

            //Console.WriteLine(personOne.Name);
            //Console.WriteLine(personTwo.Name);
            //Console.WriteLine(personThree.Name);

            /*
            Random random = new Random();

            List<Person> people = new List<Person>()
            {
                new Person { Name = "Johan", Age = random.Next(0, 99), City = "Bromma" },
                new Person { Name = "Niklas", Age = random.Next(0, 99), City = "Södertälje" },
                new Person { Name = "Anna", Age = random.Next(0, 99), City = "Norrköping" },
                new Person { Name = "Frida", Age = random.Next(0, 99), City = "Härnösand" },
                new Person { Name = "Peter", Age = random.Next(0, 99), City = "Gävle" },
                new Person { Name = "Erik", Age = random.Next(0, 99), City = "Falun" }
            };

            people.Add(new Person { Name = "Steffo", Age = random.Next(0, 99), City = "Älandsbro" });

            foreach (var person in people)
            {
                // Old fashion
                //Console.WriteLine("Hej. Jag heter {0} och jag är {1} år gammal från {2}.", person.Name, person.Age, person.City );
                Console.WriteLine(person.Introduction());
            }

            */
            #endregion

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city = Console.ReadLine();

            Person newPerson = new Person
            {
                Name = name,
                Age = age,
                City = city
            };

            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Would you like to introduce yourself? (y/n)");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.Y: Console.WriteLine(newPerson.Introduction()); break;
                    case ConsoleKey.N: Console.WriteLine("Okay. Bye!"); break;
                    default: loop = true; break;
                }
            } while (loop);
            Console.ReadLine();
        }
    }
}
