using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO.Compression;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace OneApp
{
    public class Page4
    {
        public static void Exercise41()
        {
            Console.WriteLine("This app gives determine isogram words");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the full path of string included txt file: ");
                    string filepath = Console.ReadLine();
                    if (filepath == "Exit")
                    {
                        break;
                    }
                    //Read The File Part
                    var directory = Path.GetDirectoryName(filepath);
                    var initialstring = File.ReadAllText(filepath);
                    IsogramCheck(initialstring);
                    ReverseFileCreate(initialstring, directory);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }
            }

        }

        private static void IsogramCheck(string initialstring)
        {
            //Isogram control part
            List<string> wordlist = new List<string>(initialstring.Split(' '));
            List<string> isogramList = new List<string>();
            var isogram = false;
            foreach (var word in wordlist)
            {
                var arrayOfWord = word.ToCharArray();
                Array.Sort(arrayOfWord);
                for (int i = 0; i < (arrayOfWord.Length - 1); i++)
                {
                    if (arrayOfWord[i] == arrayOfWord[i + 1])
                    {
                        isogram = true;
                        break;
                    }
                }
                if (isogram)
                {
                    isogramList.Add(word);
                    isogram = false;
                }
            }

            //Isogram output part
            if (isogramList.Count != 0)
            {
                Console.WriteLine("\nIsogram words found initial string. Here is the list: ");
                isogramList.ForEach(i => Console.WriteLine("{0}", i));
            }
            else
            {
                Console.WriteLine("No isogram word in the initial string.");
            }
        }

        private static void ReverseFileCreate(string initialstring, string directory)
        {
            //Reverse part
            var arrayofstring = initialstring.ToCharArray();
            char[] reversearray = new char[arrayofstring.Length];
            int counter = 0;
            for (int i = (arrayofstring.Length - 1); i >= 0; i--)
            {
                reversearray[counter] = arrayofstring[i];
                counter++;
            }

            //File creation part
            var outputfile = Path.Combine(directory, "reverse_string.txt");
            if (File.Exists(outputfile))
            {
                File.Delete(outputfile);
            }

            var outputfilestream = File.Create(outputfile);
            Byte[] output = new UTF8Encoding(true).GetBytes(reversearray);
            outputfilestream.Write(output, 0, output.Length);
            outputfilestream.Close();
            Console.WriteLine("\nOutput file is created: {0}\n", outputfile);
        }


        public static void Exercise42()
        {
            while (true)
            {
                Console.WriteLine("This app calculates are of right angle triangle");
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                try
                {

                    Console.WriteLine("Enter the first short side length: ");
                    string firstSide = Console.ReadLine();
                    if (firstSide == "Exit")
                    {
                        break;
                    }

                    Console.WriteLine("Enter the second short side length: ");
                    string secondSide = Console.ReadLine();
                    Console.WriteLine("The are is: {0}", (double.Parse(firstSide, CultureInfo.InvariantCulture) * double.Parse(secondSide, CultureInfo.InvariantCulture)) / 2);
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter in number format");
                }
            }
        }

        public static void Exercise43()
        {
            while (true)
            {
                Console.WriteLine("This app creates a zip archive");
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                try
                {
                    Console.WriteLine("Enter directory for archiving: ");
                    var archiveDirectory = Console.ReadLine();
                    if (archiveDirectory == "Exit")
                    {
                        break;
                    }
                    DirectoryInfo info = new DirectoryInfo(archiveDirectory);
                    var directoryname = info.Name;
                    if (!Directory.Exists(archiveDirectory))
                    {
                        Console.WriteLine("This directory is not exist");
                        break;
                    }

                    var defaultDirectory = info.Parent.FullName;
                    Console.WriteLine("Enter desired directory for output.");
                    Console.WriteLine("Default directory is {0}, press Enter to continue with default ", defaultDirectory);
                    string newDirectory = Console.ReadLine();
                    if (newDirectory != "")
                    {
                        defaultDirectory = newDirectory;
                    }

                    var outputfile = Path.Combine(defaultDirectory, directoryname + ".zip");
                    ZipFile.CreateFromDirectory(archiveDirectory, outputfile);
                    Console.WriteLine("Directory is zipped to " + outputfile);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }
            }
        }

        public static void Exercise44()
        {
            while (true)
            {
                Console.WriteLine("This app opens a zip archive");
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                try
                {
                    Console.WriteLine("Enter archive full path: ");
                    var archiveFile = Console.ReadLine();
                    if (archiveFile == "Exit")
                    {
                        break;
                    }

                    var fileName = Path.GetFileNameWithoutExtension(archiveFile);
                    var directory = Path.GetDirectoryName(archiveFile);
                    if (!Directory.Exists(directory))
                    {
                        Console.WriteLine("This directory is not exist");
                        break;
                    }
                    Console.WriteLine("Enter desired directory for output.");
                    Console.WriteLine("Default directory is {0}, press Enter to continue with default ", directory);
                    string newDirectory = Console.ReadLine();
                    if (newDirectory != "")
                    {
                        directory = newDirectory;
                    }
                    var zipArchive = ZipFile.Open(archiveFile, ZipArchiveMode.Update);
                    var outputDirectory = Path.Combine(directory, fileName);
                    zipArchive.ExtractToDirectory(outputDirectory);
                    Console.WriteLine("Zip file extracted to " + outputDirectory);
                    zipArchive.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }
            }
        }

        public static void Exercise45()
        {
            while (true)
            {
                Console.WriteLine("This app sorts given integers with using Bubble Sorting");
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                try
                {
                    Console.WriteLine("Enter Integers (max 100) with space: ");
                    var numbers = Console.ReadLine();
                    if (numbers == "Exit")
                    {
                        break;
                    }

                    var numberArray = numbers.Split(' ');

                    if (numberArray.Length > 100)
                    {
                        Console.WriteLine("Max acceptable size of integers are 100. Please try again.");
                        break;
                    }

                    var integerArray = new int[numberArray.Length];

                    for (int i = 0;i<=numberArray.Length-1;i++)
                    {
                        integerArray[i] = int.Parse(numberArray[i]); 
                    }

                    var buffer = 0;

                    for (int i = 0; i <= integerArray.Length - 1; i++)
                    {
                        for (int j = 1; j <= integerArray.Length - 1; j++)
                        {
                            if (integerArray[j - 1] > integerArray[j])
                            {
                                buffer = integerArray[j];
                                integerArray[j] = integerArray[j - 1];
                                integerArray[j - 1] = buffer;
                            }
                        }
                    }
                    Console.WriteLine("Sorted list: ");
                    foreach (var number in integerArray)
                    {
                        Console.Write(number + " ");
                    }
                    Console.Write("\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }
            }
        }

        public static void Exercise46()
        {
            while (true)
            {
                Console.WriteLine("This app downloads file from given URL");
                Console.WriteLine("For exiting to application type \"Exit\": \n");
                try
                {
                    Console.WriteLine("Enter file download URL: ");
                    var urlDownload = Console.ReadLine();
                    if (urlDownload == "Exit")
                    {
                        break;
                    }

                    var filename = urlDownload.Split('/');

                    var downloadPath = Directory.GetCurrentDirectory();
                    Console.WriteLine("Enter Download path: ");
                    Console.WriteLine("Default directory is {0}, press Enter to continue with default ", downloadPath);
                    var userDownloadPath = Console.ReadLine();
                    if (userDownloadPath != "")
                    {
                        downloadPath = userDownloadPath;
                    }
                    var downloadFilePath = Path.Combine(downloadPath, filename[filename.Length-1]);

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(urlDownload, downloadFilePath);
                    Console.WriteLine("File is downloaded to " + downloadFilePath);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }
            }
        }
    }
}