using System;

namespace ManejoDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            int height = 170;
            int age = 20;
            string name = "Lina Ureña";

            //string placeholderText = "The information you requested is:";
            //string information = "The information you requested is:" + name + placeholderText + age + height;

            string information = "The information you requested is: \nUser name " + name  + "\nUser age " + age + "\nUser height " + height;

            Console.WriteLine(information);


        }
    }
}
