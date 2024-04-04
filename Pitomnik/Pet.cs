namespace Pitomnik
{
    internal class Pet(string name, string dateofbirth, string animalkind, string commands) : AbstractAnimal(name, dateofbirth, animalkind, commands)
    {
        public override string ToString() => $"{App.TranslateAnimal(AnimalKind)} {Name}, дата рожения: {DateOfBirth}. Выполняет команды: {Commands}";
    }

    internal class Cat(string name, string dateofbirth, string commands) : Pet(name, dateofbirth, "Cat", commands) { }
    internal class Dog(string name, string dateofbirth, string commands) : Pet(name, dateofbirth, "Dog", commands) { }
    internal class Hamster(string name, string dateofbirth, string commands) : Pet(name, dateofbirth, "Hamster", commands) { }
}
