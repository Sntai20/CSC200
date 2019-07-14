using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Assignment4Competition1
{
    
    public struct Coffee
    {
        // This is the custom constructor.
        public Coffee(int strength, string bean, string countryOfOrigin)
        {
            this.e = null;
            this.currentStockLevel = 5;
            this.OutOfBeans = null;
            this.minimumStockLevel = 3;


            this.Strength = strength;
            this.Bean = bean;
            this.CountryOfOrigin = countryOfOrigin;
        }
        // These statements declare the struct fields and set the default values.
        public int Strength;
        public string Bean;
        public string CountryOfOrigin;
        // Other methods, fields, properties, and events.

        public EventArgs e;
        public delegate void OutOfBeansHandler(Coffee coffee, EventArgs args);
        public event OutOfBeansHandler OutOfBeans;

        int currentStockLevel;
        int minimumStockLevel;
        public void MakeCoffee()
        {
            // Decrement the stock level.
            currentStockLevel--;
            // If the stock level drops below the minimum, raise the event.
            if (currentStockLevel < minimumStockLevel)
            {
                // Check whether the event is null.
                if (OutOfBeans != null)
                {
                    // Raise the event.
                    OutOfBeans(this, e);
                }
            }
        }
    }

    public class Inventory
    {
        Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");

        public void HandleOutOfBeans(Coffee sender, EventArgs args)
        {
            string coffeeBean = sender.Bean;
            //Reorder the coffee bean.
            Console.WriteLine("Reorder Coffee Beans for: " + coffeeBean);
        }
        public void SubscribeToEvent()
        {
            coffee1.OutOfBeans += HandleOutOfBeans;
            //also test this (uncomment the following lines of code)
            //coffee1.OutOfBeans += HandleOutOfBeans;
            //coffee1.OutOfBeans += HandleOutOfBeans;
            //coffee1.OutOfBeans -= HandleOutOfBeans;
        }

        public void MakeCoffee()
        {
            coffee1.MakeCoffee();
        }
    }

    public class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        private static void Main(string[] args)
        {
            Inventory myinv = new Inventory();
            myinv.SubscribeToEvent();
            myinv.MakeCoffee();
            myinv.MakeCoffee();
            myinv.MakeCoffee();
        }
    }
}
