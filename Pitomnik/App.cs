using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitomnik
{
    internal class App
    {
        static List<AbstractAnimal> animals = [];
        public static void AddAnimal(string name, string dateofbirth, string kind, string commands)
        {
            switch (kind)
            {
                case "Cat":
                    animals.Add(new Cat(name, dateofbirth, commands));
                    return;
                case "Dog":
                    animals.Add(new Dog(name, dateofbirth, commands));
                    return;
                case "Hamster":
                    animals.Add(new Hamster(name, dateofbirth, commands));
                    return;
                case "Camel":
                    animals.Add(new Camel(name, dateofbirth, commands));
                    return;
                case "Donkey":
                    animals.Add(new Donkey(name, dateofbirth, commands));
                    return;
                case "Horse":
                    animals.Add(new Horse(name, dateofbirth, commands));
                    return;
                default:
                    throw new InvalidDataException("Invalid kind provided");
            }
        }
    }
}
