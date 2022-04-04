using System;

namespace CustomSubstringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int startIndex, lenght, i;
            string subString = string.Empty;
            string outputMessage;

            Console.Write("Please insert your string: ");
            message = Console.ReadLine();

            Console.Write("Please insert the starting index for the substring: ");
            startIndex = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please insert the lenght for the substring: ");
            lenght = Convert.ToInt32(Console.ReadLine());
            
            outputMessage = SubString(message, startIndex, lenght);
            Console.WriteLine(outputMessage);
        }

        public static string SubString(string message, int? startIndex, int lenght)
        {

            int i, finalIndex = 0;
            string subString = string.Empty;

            if (string.IsNullOrEmpty(message))
            {
                return "You have not inserted a message!";

            }
            else if(startIndex < 0 || lenght < 0 )
            {
                return "Start Index or lenght cannot be less than zero!";
            }

            int checkStartIndex = startIndex ?? 0;
            finalIndex = lenght + checkStartIndex; //null coalescing, if var has value, pass that value, else pass user defined value (in this case, zero)



            try
            {
              for (i = checkStartIndex; i < finalIndex; i++)
              {
                subString += message[i];
              }
            }
            catch(IndexOutOfRangeException ex)
            {
                return(ex.Message);
            }
            

            return subString;
        }
    }
}
