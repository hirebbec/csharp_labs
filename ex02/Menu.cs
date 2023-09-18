using System;
namespace ex02
{
    public class Menu
    {
        private Set s1;
        private Set s2;

        public Menu()
        {
            s1 = new Set();
            s2 = new Set();
        }

        public void printMenu()
        {
            Console.Write("\nМножество 1 = ");
            s1.printAll();
            Console.Write("Множество 2 = ");
            s2.printAll();
            Console.Write("1 - добавить элемент в первое множество\n" +
                "2 - добавить элемент в первое множество\n" +
                "3 - удалить элемент из первого множества\n" +
                "4 - удалить элемент из первого множества\n" +
                "5 - найти пересечение множеств\n" +
                "6 - найти объеденение множеств\n" +
                "7 - найти разность множесвт\n" +
                "8 - выход\n");
        }

        public void execute(int command)
        {
            string input;
            switch (command)
            {
                case 1:
                    Console.WriteLine("Введите число для добавления в первое множество:");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int number))
                    {
                        s1.add(Convert.ToInt32(input));
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат числа.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите число для добавления во второе множество:");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out number))
                    {
                        s2.add(Convert.ToInt32(input));
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат числа.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите число, которое хотите удалить из первого множества:");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out number))
                    {
                        s1.del(Convert.ToInt32(input));
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат числа.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите число, которое хотите удалить из второго множества:");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out number))
                    {
                        s2.del(Convert.ToInt32(input));
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат числа.");
                    }
                    break;
                case 5:
                    Console.Write("Пересечение множеств -> ");
                    s1.crossing(s2).printAll();
                    break;
                case 6:
                    Console.Write("Объедение множеств -> ");
                    s1.union(s2).printAll();
                    break;
                case 7:
                    Console.Write("Множество 1 - Множесвто 2 = ");
                    (s1 - s2).printAll();
                    Console.Write("Множество 2 - Множесвто 1 = ");
                    (s2 - s1).printAll();
                    break;
                default:
                    Console.Write("Неправильная команда!");
                    break;
            }
        }
    }
}
