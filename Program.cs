using System;
using System.Collections.Generic;



namespace HW_28_02_2024
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("1. Add number");
                Console.WriteLine("2. Remove number");
                Console.WriteLine("3. Display numbers");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNumber(numbers);
                        break;
                    case "2":
                        RemoveNumber(numbers);
                        break;
                    case "3":
                        DisplayNumbers(numbers);
                        break;
                    case "4":
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }

        static void AddNumber(List<int> numbers)
        {
            Console.Write("Enter a number to add: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
                Console.WriteLine($"Number {number} added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static void RemoveNumber(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Error: Collection is empty.");
                return;
            }

            Console.Write("Enter the index of the number to remove: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index) && index >= 0 && index < numbers.Count)
            {
                int removedNumber = numbers[index];
                numbers.RemoveAt(index);
                Console.WriteLine($"Number {removedNumber} removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid index.");
            }
        }

        static void DisplayNumbers(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Collection is empty.");
                return;
            }

            Console.WriteLine("Numbers in the collection:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

}
