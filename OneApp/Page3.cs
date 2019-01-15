using System;
using System.IO;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Reflection;
using System.Globalization;

namespace OneApp
{
    public class Page3
    {

        public static void Exercise31()
        {
            Console.WriteLine("This app calculates monthly compound interest according to given duration, initial sum and interest rate");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {

                    Console.WriteLine("Enter the initial sum: ");
                    var initial = Console.ReadLine();

                    if (initial == "Exit")
                    {
                        break;
                    }
                    var initial_sum = double.Parse(initial, CultureInfo.InvariantCulture);

                    Console.WriteLine("Enter duration of rate (in year): ");
                    var duration = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Enter interest rate (per cent): ");
                    var interest_rate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    interest_rate = interest_rate / 100;
                    var compound_interest = initial_sum * Math.Pow((1 + (interest_rate / 12)), (12 * duration));
                    var interest_amount = compound_interest - initial_sum;

                    Console.WriteLine("Interest amount: {0:F2} \nTotal amount of money after {1} years: {2:F2}", interest_amount, duration, compound_interest);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }


            }
        }

        public static void Exercise32()
        {
            Console.WriteLine("This app calculates sum of digits of given integer");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {

                    Console.WriteLine("Enter the integer value: ");
                    var value = Console.ReadLine();
                    int sum = 0;
                    if (value == "Exit")
                    {
                        break;
                    }
                    value = value.TrimStart('-');
                    char[] chars = value.ToCharArray();
                    foreach (var number in chars)
                    {
                        sum += int.Parse(number.ToString());
                    }
                    Console.WriteLine("Sum of given integer: {0}", sum);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }
            }
        }

        public static void Exercise33()
        {
            Console.WriteLine("This app calculates the SHA-512 hash of a file as hexadecimal");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the full path of file: ");
                    string filepath = Console.ReadLine();
                    if (filepath == "Exit")
                    {
                        break;
                    }

                    HashAlgorithm cryptoService = new SHA512CryptoServiceProvider();
                    var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                    var hash = cryptoService.ComputeHash(fileStream);
                    var hashString = Convert.ToBase64String(hash);

                    Console.WriteLine("SHA512: {0}", hashString);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e);
                }
            }
        }

        public static void Exercise34()
        {
            Console.WriteLine("This app gives hostname of given URL");
            Console.WriteLine("For exiting to application type \"Exit\": \n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your URL: ");
                    var userurl = Console.ReadLine();
                    if (userurl == "Exit")
                    {
                        break;
                    }
                    Uri uri = new Uri(userurl);

                    Console.WriteLine("Hostname is: " + uri.DnsSafeHost);

                }
                catch (Exception)
                {
                    Console.WriteLine("\n kebab \n");
                    System.IO.Stream kebab = Properties.Resource1.recording_1;
                    SoundPlayer play = new SoundPlayer(kebab);
                    play.Play();

                }
            }
        }

        public static void Exercise36()
        {
            var day = DateTime.Now.Day;
            Console.WriteLine("Today's day is: " + day);
            Console.WriteLine("Fibonacci sequence according to today: ");

            if (day == 1)
            {
                Console.WriteLine(0);
            }
            else if (day == 2)
            {
                Console.Write(0 + " " + 1);
            }
            else
            {
                int[] list = new int[day];
                list[0] = 0;
                list[1] = 1;
                for (int i = 2; i <= day - 1; i++)
                {
                    list[i] = list[i - 1] + list[i - 2];
                }
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Press any key to back");
            Console.ReadKey();
        }
    }
}