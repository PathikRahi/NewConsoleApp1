using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp1
{
    internal class Program : Class1
    {
         static int a = 10;
        static void Main(string[] args)
        {
            //Added Comment
            //Add another Comment
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("https://www.amazon.com/");
            //driver.Close();


            /*Console.WriteLine("First C# Program");
           Console.WriteLine(a);
            Console.WriteLine(8 % 3);
            Console.WriteLine(5 / 2.0);
            Console.WriteLine(Math.Pow(4,3));*/


            /*Console.Write("Enter Your Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.Write("Enter Your Age ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " You are " +age);*/

            /*int num = Convert.ToInt32("55");
             string num = Console.ReadLine();
             int num2= Convert.ToInt32(num);
             Console.WriteLine(num2 + 6);*/

            /*Console.Write("Enter a Number ");
            
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a Number ");
           
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);*/

            //Arrays:
            //
            /*int[] a = { 5, 6, 8, 45, 35 };
            Console.WriteLine(a.Average());*/
            // Program pg = new Program();
            //SayHi("Pathik");
            // Console.WriteLine(cube(5));

            //Console.WriteLine(Class1.q);

            bool isMale = true;
            bool isTall = false;
            if (isMale || isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else
            {
                Console.WriteLine("You are not male or not tall");
            }

            Console.ReadLine();
        }

          static void SayHi(string name)
        {
            Console.WriteLine("Hello "+name);
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }

    
}
