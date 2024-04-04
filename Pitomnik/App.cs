namespace Pitomnik
{
    internal class App
    {
        public static List<AbstractAnimal> animals = [];
        internal static Counter AnimalCounter = new();
        public static void AddAnimal(string name, string dateofbirth, string kind, string commands)
        {
            switch (kind)
            {
                case "Cat":
                    animals.Add(new Cat(name, dateofbirth, commands));
                    break;
                case "Dog":
                    animals.Add(new Dog(name, dateofbirth, commands));
                    break;
                case "Hamster":
                    animals.Add(new Hamster(name, dateofbirth, commands));
                    break;
                case "Camel":
                    animals.Add(new Camel(name, dateofbirth, commands));
                    break;
                case "Donkey":
                    animals.Add(new Donkey(name, dateofbirth, commands));
                    break;
                case "Horse":
                    animals.Add(new Horse(name, dateofbirth, commands));
                    break;
                default:
                    throw new InvalidDataException("Invalid kind provided");
            }
            AnimalCounter.Increment();
        }


        public static string TranslateAnimal(string? animal)
        {
            return animal switch
            {
                "Cat" => "Кот",
                "Dog" => "Собака",
                "Hamster" => "Хомяк",
                "Camel" => "Верблюд",
                "Donkey" => "Осёл",
                "Horse" => "Лошадь",
                _ => throw new NotImplementedException()
            };
        }
    }
}
