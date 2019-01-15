using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OneApp
{
    class OneApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("This app has all C# exercises.  ");
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                Console.WriteLine("To see exercises enter the page number:\n1\n2\n3\n4\n");
                var pagenumber = Console.ReadLine();

                if (pagenumber == "Exit")
                {
                    break;
                }

                switch (pagenumber)
                {
                    case "1":
                        Page1Apps();
                        break;
                    case "2":
                        Page2Apps();
                        break;
                    case "3":
                        Page3Apps();
                        break;
                    case "4":
                        Page4Apps();
                        break;
                    default:
                        Console.WriteLine("Please Enter correct value of page");
                        Thread.Sleep(1000);
                        break;
                }
            }


        }

        private static void Page4Apps()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("For back to the other page type \"Exit\": \n");
                Console.WriteLine("List of the page one apps: ");
                Console.WriteLine("Enter the number to run app.");
                Console.WriteLine("1. String reverse isogram calculation");
                Console.WriteLine("2. Area calculator of right angle triangle");
                Console.WriteLine("3. Makes a zip archive out of a directory");
                Console.WriteLine("4. Makes a directory out of a zip archive");
                Console.WriteLine("5. Bubble Sort");
                Console.WriteLine("6. Download file from URL");
                var page4appnumber = Console.ReadLine();
                switch (page4appnumber)
                {
                    case "1":
                        Console.Clear();
                        Page4.Exercise41();
                        break;
                    case "2":
                        Console.Clear();
                        Page4.Exercise42();
                        break;
                    case "3":
                        Console.Clear();
                        Page4.Exercise43();
                        break;
                    case "4":
                        Console.Clear();
                        Page4.Exercise44();
                        break;
                    case "5":
                        Console.Clear();
                        Page4.Exercise45();
                        break;
                    case "6":
                        Console.Clear();
                        Page4.Exercise46();
                        break;
                    case "Exit":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number.");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }

        private static void Page3Apps()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("For back to the other page type \"Exit\": \n");
                Console.WriteLine("List of the page one apps: ");
                Console.WriteLine("Enter the number to run app.");
                Console.WriteLine("1. Compount Interest Calculator");
                Console.WriteLine("2. Sum of digits calculator");
                Console.WriteLine("3. SHA-512 hash of a file calculator");
                Console.WriteLine("4. URL Parser");
                Console.WriteLine("5. Fibonacci sequence according to the number");
                var page3appnumber = Console.ReadLine();
                switch (page3appnumber)
                {
                    case "1":
                        Console.Clear();
                        Page3.Exercise31();
                        break;
                    case "2":
                        Console.Clear();
                        Page3.Exercise32();
                        break;
                    case "3":
                        Console.Clear();
                        Page3.Exercise33();
                        break;
                    case "4":
                        Console.Clear();
                        Page3.Exercise34();
                        break;
                    case "5":
                        Console.Clear();
                        Page3.Exercise36();
                        break;
                    case "Exit":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number.");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }

        private static void Page2Apps()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("For back to the other page type \"Exit\": \n");
                Console.WriteLine("List of the page one apps: ");
                Console.WriteLine("Enter the number to run app.");
                Console.WriteLine("1. Delete biggest file");
                Console.WriteLine("2. Average, median and mode vaule calculator");
                Console.WriteLine("3. Split a sentence to multiple lines");
                var page2appnumber = Console.ReadLine();
                switch (page2appnumber)
                {
                    case "1":
                        Console.Clear();
                        Page2.Exercise21();
                        break;
                    case "2":
                        Console.Clear();
                        Page2.Exercise22();
                        break;
                    case "3":
                        Console.Clear();
                        Page2.Exercise26();
                        break;
                    case "Exit":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number.");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }

        private static void Page1Apps()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("For back to the other page type \"Exit\": \n");
                Console.WriteLine("List of the page one apps: ");
                Console.WriteLine("Enter the number to run app.");
                Console.WriteLine("1. Leap Year App");
                Console.WriteLine("2. How many times a word exists in a sentence");
                Console.WriteLine("3. Multiplication table");
                Console.WriteLine("4. Floyd’s Triangle ");
                var page1appnumber = Console.ReadLine();
                switch (page1appnumber)
                {
                    case "1":
                        Console.Clear();
                        Page1.Exercise13();
                        break;
                    case "2":
                        Console.Clear();
                        Page1.Exercise14();
                        break;
                    case "3":
                        Console.Clear();
                        Page1.Exercise15();
                        break;
                    case "4":
                        Console.Clear();
                        Page1.Exercise16();
                        break;
                    case "Exit":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number.");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }
    }
}
