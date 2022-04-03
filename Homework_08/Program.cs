using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string userMessage;
        bool wordCheckExit = true;

        while (!false == wordCheckExit)
        {
            Console.WriteLine("Для выхода из цикла, напишите: exit");
            userMessage = Console.ReadLine();

            if (userMessage == "exit")
            {
                wordCheckExit = !true;
            }
        }
    }
}