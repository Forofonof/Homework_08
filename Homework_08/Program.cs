using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string userMessage;
        bool wordOutputCheck = false;

        while (!wordOutputCheck) 
        {
            Console.WriteLine("Для выхода из цикла, напишите: exit");
            userMessage = Console.ReadLine();

            if (userMessage == "exit")
            {
                wordOutputCheck = true;
                break;
            }
        }
        Console.WriteLine("Вы успешно вышли из цикла!");
    }
}