

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        string input = "";

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Calculate average");
            Console.WriteLine("L - Find highest number");
            Console.WriteLine("S - Find smallest number");
            Console.WriteLine("F - Find a number's index");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("Q - Quit");

            input = Console.ReadLine().ToUpper();

            if (input == "Q")
            {
                Console.WriteLine("Exiting program");
                break;
            }

            else if (input == "P")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("List is empty.");
                }
                else
                {
                    Console.Write("Numbers in list: ");
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                    Console.WriteLine();
                }
            }

            else if (input == "A")
            {
                Console.Write("Enter a number to add: ");
                string addInput = Console.ReadLine();
                int newNumber = Convert.ToInt32(addInput); 

                bool exists = false;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == newNumber)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    Console.WriteLine("Number already exists in the list");
                }
                else
                {
                    numbers.Add(newNumber);
                    Console.WriteLine($"You added {newNumber}.");
                }
            }

            else if (input == "M")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("List is empty. Cannot calculate average.");
                }
                else
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    double average = (double)sum / numbers.Count;
                    Console.WriteLine("Average: " + average);
                }
            }

            else if (input == "L")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("List is empty.");
                }
                else
                {
                    int max = numbers[0];
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        if (numbers[i] > max)
                        {
                            max = numbers[i];
                        }
                    }
                    Console.WriteLine("Highest number: " + max);
                }
            }

            else if (input == "S")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("List is empty.");
                }
                else
                {
                    int min = numbers[0];
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        if (numbers[i] < min)
                        {
                            min = numbers[i];
                        }
                    }
                    Console.WriteLine("Smallest number: " + min);
                }
            }

            else if (input == "F")
            {
                Console.Write("Enter number to find: ");
                string searchInput = Console.ReadLine();
                int searchNumber = Convert.ToInt32(searchInput); 

                bool found = false;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == searchNumber)
                    {
                        Console.WriteLine($"Number {searchNumber} found at index {i}.");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Number does not exist in the list.");
                }
            }

            else if (input == "C")
            {
                numbers.Clear();
                Console.WriteLine("List cleared.");
            }

            else
            {
                Console.WriteLine("invalid option. try again.");
            }
        }
    }
}

