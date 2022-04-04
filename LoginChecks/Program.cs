using System;

namespace LoginChecks
{
    class Program
    {
        static void Main(string[] args)
        {
            //START variable declaration
            string email;
            string password;
            const string mailErrorMessage = "Email is not valid!\nRemember:\n + Email must contain @\n + Email name must be 3 characters or longer\n + Email domain must end in .it";
            const string passwordErrorMessage = "Password is not valid!\nRemember:\n + Password must be longer than 10 characters\n + Password must contain at least one number, one uppercase character and one special character";
            char[] numbers = "0123456789".ToCharArray();
            char[] chars = "!£$%&/()=?^*°§#".ToCharArray();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            bool isLengthAccepted = false;
            bool containsNum = false;
            bool containsChar = false;
            bool containsUppercase = false;
            string output;
            
            
            //END variable declaration


            Console.Write("Hello, to login please insert your email: ");
            email = Console.ReadLine(); //acquire input email

            //START email check
            if (email.Contains("@")) //check for @ with .contains() method
            {
                string[] nameAndDomain = email.Split("@"); //email is split into username (index 0 of the array) and domain (index 1) using @ as separator
               
                output = nameAndDomain[0].Length >= 3 && nameAndDomain[1].EndsWith(".it") ? "Email is valid" : mailErrorMessage;

                Console.WriteLine(output);

            }
            else
            {
                Console.WriteLine(mailErrorMessage);
            }
            //END email check

            Console.WriteLine("\nNow insert your password: ");

            password = Console.ReadLine(); //acquire input password

            //START password check
            if (password.Length > 10) { isLengthAccepted = true; } //password must be longer than 10 characters, condition is met for length > 10
            
            for (int i = 0; i < numbers.Length; i++) //password must contain at least one number, for loop iterates through the elements
            {
                if (password.Contains(numbers[i]) == true) //each character of password is compared to each number of the number array
                {
                    containsNum = true; //if condition is met, boolean is true 
                }
            }

            for (int i = 0; i < chars.Length; i++) //password must contain special character, same procedure as above
            {
                if (password.Contains(chars[i]) == true)
                {
                    containsChar = true;
                }
            }

            for (int i = 0; i < letters.Length; i++) //password must contain at least one uppercase letter, same procedure as above
            {
                if (password.Contains(letters[i]) == true)
                {
                    containsUppercase = true;
                }
            }

            //if all condition specified are true, login is completed, else password is rejected
            output = containsChar == true && containsUppercase == true && containsNum == true && isLengthAccepted == true ? "\nLogin completed, welcome user!" : passwordErrorMessage;

        }


        public bool GetEmail()
        {
            string email;
            bool emailIsCorrect;
            

            Console.Write("Hello, to login please insert your email: ");
            email = Console.ReadLine(); //acquire input email

            if (email.Contains("@")) //check for @ with .contains() method
            {
                string[] nameAndDomain = email.Split("@"); //email is split into username (index 0 of the array) and domain (index 1) using @ as separator

                emailIsCorrect = nameAndDomain[0].Length >= 3 && nameAndDomain[1].EndsWith(".it") ? true : false;

                return emailIsCorrect;

                
            }
            else
            {
                return false;
            }

            
        }





        
    }
}
