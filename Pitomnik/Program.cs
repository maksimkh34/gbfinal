// Console 
using Pitomnik;

while (true)
{
    Console.WriteLine("""

        Меню:
            1. Добавить животное
            2. Просмотреть список
            3. Обучить животное
            4. Выход

     """);
    Console.Write("Выбор: ");
    _ = int.TryParse(Console.ReadLine(), out int choice);
    switch (choice)
    {
        case 1:
            string? name = (string)Ask("Введите имя животного");
            string? dob = (string)Ask("Введите дату рождения животного");
            string? kind = null;
            switch (Ask("""

                Животное:
                    1. Кошка
                    2. Собака
                    3. Хомяк
                    4. Верблюд
                    5. Осёл
                    6. Лошадь
                    7. Отмена
                Выбор
                """, true))
            {
                case 1:
                    kind = "Cat";
                    break;
                case 2:
                    kind = "Dog";
                    break;
                case 3:
                    kind = "Hamster";
                    break;
                case 4:
                    kind = "Camel";
                    break;
                case 5:
                    kind = "Donkey";
                    break;
                case 6:
                    kind = "Horse";
                    break;
            }
            string? commands = (string)Ask("Какие команды умеет исполнять");
            if (commands is null || name is null || dob is null || kind is null)
                Console.WriteLine("Неверно введены данные. ");
            else
            {
                Pitomnik.App.AddAnimal(name, dob, kind, commands);
                Console.WriteLine($"{name} добавлен в базу! ");
            }
            break;
        case 2:
            int i = 1;
            foreach (AbstractAnimal animal in App.animals)
            {
                Console.WriteLine($"{i}: " + animal);
                i++;
            }
            break;
        case 3:
            Console.Write("Введите номер животного п/п (-1, 2 для просмотра списка): ");
            _ = int.TryParse(Console.ReadLine(), out choice);
            if (choice == -1 || !App.AnimalCounter.InRange(choice)) break;
            var current_animal = App.animals[choice - 1];
            Console.Write($"Обучаем животное \"{current_animal.Name}\". Новые команды через запятую: ");
            current_animal.Train(Console.ReadLine() ?? "");
            Console.Write($"Отлично! \"{current_animal.Name}\" теперь умеет: {current_animal.Commands}");
            break;
        case 4:
            Console.WriteLine("OK! ");
            return;
        default:
            Console.WriteLine("Команда не распознана! ");
            break;
    }
}

static object Ask(string question, bool isInt = false)
{
    Console.Write("\n" + question + ": ");
    string? str_out = Console.ReadLine();
    if (isInt)
    {
        _ = int.TryParse(str_out, out int out_);
        return out_;
    }
    return str_out ?? "$$$";
}
