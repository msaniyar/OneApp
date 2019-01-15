using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace OneApp
{
    public class Page1
    {
        public static void Exercise13()
        {
            while (true)
            {
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                Console.WriteLine("Enter the year: \n");
                var year = Console.ReadLine();
                try
                {
                    if (year == "Exit")
                    {
                        break;
                    }

                    var yearint = Convert.ToInt32(year);
                    var leapcontroller = yearint % 4;

                    if (leapcontroller != 0)
                    {
                        yearint = yearint + (4 - leapcontroller);
                        Console.WriteLine("Year is not leapyear. Next leap year is: " + yearint);
                    }
                    else if (yearint % 100 != 0)
                    {
                        Console.WriteLine("Year is leapyear");
                    }
                    else if (yearint % 400 != 0)
                    {
                        yearint = yearint + 4;
                        Console.WriteLine("Year is not leapyear. Next leap year is: " + yearint);
                    }
                    else
                    {
                        Console.WriteLine("Year is leapyear");
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Enter in number format");
                }
            }

        }

        public static void Exercise14()
        {
            while (true)
            {
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                Console.WriteLine("Enter your sentence: \n");

                try
                {
                    var sentence = Console.ReadLine();
                    if (sentence == "Exit")
                    {
                        break;
                    }

                    Console.WriteLine("Enter the searched word: \n");
                    var word = Console.ReadLine();

                    var count = 0;

                    List<string> wordlist = new List<string>(sentence.Split(' '));


                    foreach (string words in wordlist)
                    {
                        if (words == word)
                        {
                            count++;
                        }
                    }

                    if (count > 0)
                    {
                        Console.WriteLine("There are " + count + " matching words in the sentence \n");
                    }
                    else
                    {
                        Console.WriteLine("No matching words in the sentence \n");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occured. Try again. \n");
                }

            }
        }

        public static void Exercise15()
        {
            int cursorposition = 0;
            int rowoffset = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                {
                    cursorposition = 0;
                    rowoffset = 12;
                }

                for (int j = 1; j <= 10; j++)
                {
                    Console.SetCursorPosition(cursorposition, (j - 1) + rowoffset);
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }

                cursorposition = cursorposition + 13;
            }
            Console.WriteLine("Press any key to back");
            Console.ReadKey();
        }

        public static void Exercise16()
        {
            Console.WriteLine("Floyd’s Triangle App \n");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the row number of Floyd’s Triangle: \n");
                    var rows = Console.ReadLine();
                    if (rows == "Exit")
                    {
                        break;
                    }

                    var row_count = Convert.ToInt32(rows);
                    int counter = 1;
                    for (int i = 1; i <= row_count; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(counter + " ");
                            counter++;
                        }
                        Console.Write("\n");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter in number format");
                }

            }
        }
    }
}