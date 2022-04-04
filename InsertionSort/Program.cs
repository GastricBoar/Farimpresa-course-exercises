using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //START variable declaration
            int i, j; 
            string orderButton;
            Random rndNum = new Random();
            //END variable declaration

            //acquire array size from user input
            Console.WriteLine("Hello, let's start. First off, insert the desired size for your array:\n");
            int size = Convert.ToInt32(Console.ReadLine()); 
            int[] arr = new int[size];

            Console.WriteLine("\nHere's your initial array, filled with random generated numbers:");

            //fill array with random numbers
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rndNum.Next(1000); //generate random numbers, with max cap at 1000               
            }

            //display initial array
            for (i = 0; i < size; i++)
            {
               Console.WriteLine(arr[i]);
            }

            Console.WriteLine("\nPress > to display array in descending order, or < to view it in ascending order:");
            orderButton = Console.ReadLine();


            if (orderButton == "<") //ascending order
            {
                for (i = 1; i < arr.Length; ++i) //i starts from 1 leaving space for variable j
                {
                    int key = arr[i]; //key declaration, separates sorted side of the array from unsorted 
                    j = i - 1; //j variable, separates  
                    
                    while (j >= 0 && arr[j] > key) //while j >= 0, shift all elements to the right space, making space for the number  
                    {
                        arr[j + 1] = arr[j]; //moves element to the right side
                        j = j - 1; //
                    }
                    arr[j + 1] = key; //sets the number to order in place 
                }

                Console.WriteLine("------------------------------------------------\nHere's your array sorted in ascending order: ");

                for (i = 0; i < size; i++) //this loop outputs every element of the sorted array
                {
                    Console.WriteLine(arr[i]);
                }

            }

            else if (orderButton == ">") //descending order part, does the same thing the code before does, but operator < is switched to > inside while loop
            {
                for (i = 1; i < arr.Length; ++i) 
                {
                    int key = arr[i]; 
                    j = i - 1; 

                    
                    while (j >= 0 && arr[j] < key) 
                    {
                        arr[j + 1] = arr[j]; 
                        j = j - 1; 
                    }
                    arr[j + 1] = key;
                }

                Console.WriteLine("------------------------------------------------\nHere's your array sorted in descending order: ");

                for (i = 0; i < size; i++)
                {
                    Console.WriteLine(arr[i]);
                }

            }







        }
    }
}
