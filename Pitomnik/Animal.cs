using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitomnik
{
    internal abstract class AbstractAnimal(string name, string dateofbirth, string animalkind)
    {
        internal string? Name { get; set; } = name;
        internal string? DateOfBirth { get; set; } = dateofbirth;
        internal readonly string? AnimalKind = animalkind;

        public override string ToString()
        {
            return $"{AnimalKind} {Name}, дата рожения: {DateOfBirth}";
        }
    }
}
