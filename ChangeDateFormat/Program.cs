using System;

namespace ChangeDateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] inputStringArr = new string[3];
            int[] inputNumArr = new int[3];
            int i;
            int day, month, year;
            string menu = "Now choose your preferred date format, type:\n -\"EN\" for english format (year/month/day) \n -\"CN\" for chinese format (month/day/year) -\"IT\" for italian format (day/month/year)";
            string convertMessage = "Here's your converted date: ";
            string convertDate;

            Console.Write("Please insert a date following the day/month/year format: ");
            userInput = Console.ReadLine();
            
            inputStringArr = userInput.Split("/");

            for (i = 0; i < inputStringArr.Length; i++)
            {
                inputNumArr[i] = Convert.ToInt32(inputStringArr[i]);
            }

            day = inputNumArr[0];
            month = inputNumArr[1];
            year = inputNumArr[2];

            Console.WriteLine(menu);
            userInput = Console.ReadLine();

            

            if (userInput == "EN")
            {
                convertDate = year + "/" + month + "/" + day;
                Console.WriteLine(convertMessage + convertDate);
            }
            else if (userInput == "CN")
            {
                convertDate = month + "/" + day + "/" + year;
                Console.WriteLine(convertMessage + convertDate);
            }
            


            switch(userInput)
            {
                case "EN":
                    convertDate = year + "/" + month + "/" + day;
                    Console.WriteLine(convertMessage + convertDate);
                    break;

                case "CN":
                    convertDate = month + "/" + day + "/" + year;
                    Console.WriteLine(convertMessage + convertDate);
                    break;

                case "IT":
                    Console.WriteLine("Date is already in italian format!");
                    break;

                default:
                    Console.WriteLine("Please choose a valid date format!");
                    break;

            }



        }
    }
}
