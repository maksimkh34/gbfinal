using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pitomnik
{
    internal class Pet(string name, string dateofbirth, string animalkind, string commands) : AbstractAnimal(name, dateofbirth, animalkind)
    {
        internal string Commands = commands;

        public override string ToString()
        {
            return $"{AnimalKind} {Name}, дата рожения: {DateOfBirth}. Выполняет команды: {Commands}";
        }
    }

    internal class Cat(string name, string dateofbirth, string commands) : Pet(name, dateofbirth, "Cat", commands) { }
    internal class Dog(string name, string dateofbirth, string commands) : Pet(name, dateofbirth, "Dog", commands) { }
    internal class Hamster(string name, string dateofbirth, string commands) : Pet(name, dateofbirth, "Hamster", commands) { }
}
