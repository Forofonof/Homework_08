using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string userMessage;
        bool isWordCheckExit = true;

        while (true == isWordCheckExit)
        {
            Console.WriteLine("Для выхода из цикла, напишите: exit");
            userMessage = Console.ReadLine();

            if (userMessage == "exit")
            {
                isWordCheckExit = false;
            }
        }
    }
}