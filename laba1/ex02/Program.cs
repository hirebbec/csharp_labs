using System;

namespace ex02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            string command = "0";
            while (!command.Equals("8"))
            {
                menu.printMenu();
                command = Console.ReadLine();

                // Попытка преобразовать введенную строку в int
                if (int.TryParse(command, out int number))
                {
                    menu.execute(Convert.ToInt32(command));
                }
                else
                {
                    Console.WriteLine("Неверный формат числа.");
                }
            }
        }
    }
}
