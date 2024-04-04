using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitomnik
{
    internal abstract class AbstractAnimal(string name, string dateofbirth, string animalkind, string commands)
    {
        internal string Name { get; set; } = name;
        internal string DateOfBirth { get; set; } = dateofbirth;
        internal readonly string AnimalKind = animalkind;
        internal string Commands = commands;

        public override string ToString() => $"{AnimalKind} {Name}, дата рожения: {DateOfBirth}";

        internal void Train(string new_commands)
        {
            if (Commands == "" || new_commands == "") Commands += new_commands;
            else Commands += ", " + new_commands;
        }
    }
}
