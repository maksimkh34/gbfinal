﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitomnik
{
    internal class PackAnimal(string name, string dateofbirth, string animalkind, string commands) : AbstractAnimal(name, dateofbirth, animalkind)
    {
        internal string Commands = commands;

        public override string ToString()
        {
            return $"{AnimalKind} {Name}, дата рожения: {DateOfBirth}. Выполняет команды: {Commands}";
        }
    }

    internal class Horse(string name, string dateofbirth, string commands) : PackAnimal(name, dateofbirth, "Horse", commands) { }
    internal class Donkey(string name, string dateofbirth, string commands) : PackAnimal(name, dateofbirth, "Donkey", commands) { }
    internal class Camel(string name, string dateofbirth, string commands) : PackAnimal(name, dateofbirth, "Camel", commands) { }
}
