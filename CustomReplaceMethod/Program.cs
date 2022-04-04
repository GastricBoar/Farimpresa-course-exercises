using System;

namespace CustomReplaceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            string valueContainer = string.Empty;
            char oldChar, newChar;


            Console.WriteLine("Hi! Please digit a phrase: ");

            phrase = Console.ReadLine();


            Console.WriteLine("Please specify which character you want to replace: ");

            oldChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please specify the character you want to replace: ");

            newChar = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == oldChar)
                {
                    newChar = phrase[i];
                    valueContainer += newChar;
                    continue;
                }

                valueContainer += phrase[i];
            }

            Console.WriteLine(valueContainer);
        }
    }
}
