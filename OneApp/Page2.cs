using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OneApp
{
    public class Page2
    {
        public static void Exercise21()
        {

            Console.WriteLine("This app deletes biggest file in given directory");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {

                    Console.WriteLine("Enter the directory: ");
                    var directory = Console.ReadLine();

                    if (directory == "Exit")
                    {
                        break;
                    }

                    long biggestsize = 0;
                    string filename = "";
                    DirectoryInfo info = new DirectoryInfo(@directory);

                    if (!Directory.Exists(directory))
                    {
                        Console.WriteLine("This directory is not exist");
                        break;
                    }

                    FileInfo[] files = info.GetFiles();


                    for (int i = 0; i < files.Length; i++)
                    {
                        if (files[i].Length > biggestsize)
                        {
                            biggestsize = files[i].Length;
                            filename = files[i].Name;
                        }

                    }

                    System.IO.File.Delete(Path.Combine(directory, filename));
                    Console.WriteLine("Biggest file is deleted. Deleted filename is: " + filename);
                    Console.WriteLine("Size of the deleted file is: " + biggestsize);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occured. Please try again.");
                    Console.WriteLine(e);
                }
            }

        }

        public static void Exercise22()
        {
            //Exercise 2.2 2.3 2.4 2.5
            bool programcontinue = true;

            Console.WriteLine("This app calculates average, median and mode of given values. Press Enter after every number input ");
            Console.WriteLine("When you are done Type \"OK\"");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (programcontinue)
            {
                try
                {

                    Console.WriteLine("Enter the number");
                    List<int> numbers = new List<int> { };
                    string number;
                    while (programcontinue)
                    {
                        number = Console.ReadLine();
                        if (number == "OK") break;
                        if (number == "Exit")
                        {
                            programcontinue = false;
                        }

                        numbers.Add(int.Parse(number));
                    }

                    //Average calculation
                    double average = numbers.Average();

                    //Median calculation
                    int count = numbers.Count;
                    int median = 0;
                    var sortedNumbers = numbers.OrderBy(a => a);
                    if (count % 2 == 0)
                    {
                        median = (sortedNumbers.ElementAt(count / 2) + sortedNumbers.ElementAt(count / 2 - 1)) / 2;
                    }
                    else
                    {
                        median = sortedNumbers.ElementAt(count / 2);
                    }

                    //Mode calculation
                    var mode = numbers.GroupBy(n => n).
                        OrderByDescending(x => x.Count()).
                        Select(x => x.Key).FirstOrDefault();

                    Console.WriteLine("Avarage of the numbers: " + average);
                    Console.WriteLine("Median of the numbers: " + median);
                    Console.WriteLine("Mode of the numbers: " + mode);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occured. Please try again.");
                    Console.WriteLine(e);
                }
            }
        }

        public static void Exercise26()
        {

            Console.WriteLine("This app that splits a sentence to multiple lines, if the charachter length is smaller than max char input");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your sentence to split: \n");
                    var sentence = Console.ReadLine();
                    if (sentence == "Exit")
                    {
                        break;
                    }

                    Console.WriteLine("Enter max character count: \n");
                    var character_count = int.Parse(Console.ReadLine());
                    sentence = sentence.Trim('?', '.', '!', ';', ',', '\'', '"');
                    List<string> wordlist = new List<string>(sentence.Split(' '));
                    List<string> outputlist = new List<string>();
                    foreach (var word in wordlist)
                    {
                        if (word.Length <= character_count)
                        {
                            outputlist.Add(word);
                        }
                    }

                    if (outputlist.Count != 0)
                    {
                        outputlist.ForEach(i => Console.Write("{0}\n", i));
                    }
                    else
                    {
                        Console.WriteLine("There is no word smaller than {0} character.",character_count);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occured. Please try again.");
                    Console.WriteLine(e);
                }

            }
        }
        

    }
}