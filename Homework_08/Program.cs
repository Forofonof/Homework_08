using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string userMessage;
        bool wordOutputCheck = true;

        while (!false == wordOutputCheck)
        {
            Console.WriteLine("Для выхода из цикла, напишите: exit");
            userMessage = Console.ReadLine();

            if (userMessage == "exit")
            {
                wordOutputCheck = !true;
            }
        }
    }
}