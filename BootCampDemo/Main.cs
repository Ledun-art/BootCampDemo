using System;

namespace BootCampDemo
{
    //Engin Demiroğ Project 2020 - Simple C# Quiz -
    internal class Program : Customer
    {
        static void Main(string[] args)
        {
            Customer customerManager = new Program();
            customerManager.Id = 1;
            customerManager.FirstName = "Tarık";
            customerManager.LastName = "Soğukpınar";

            string[] manager = {customerManager.FirstName + " " + customerManager.LastName + " " + customerManager.Id};

            foreach (var items in manager)
            {
                Console.WriteLine(items);
            }

            customerManager.Add();
            customerManager.Delete();
            customerManager.Update();
        }
    }
}