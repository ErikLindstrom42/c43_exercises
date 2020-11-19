﻿using System;
using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        // Public Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsLocal { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public void ChangeFirstName(string firstName)
        {
            if (firstName.Length > 1)
            {
                FirstName = firstName;
            }
        }
    }

    public class DeliveryService
    {
        /*
          Properties
        */
        public string Name { get; set; }

        public string TransitType { get; set; }

        /*
          Methods
        */
        public void Deliver(Product product, Customer customer)
        {
            Console.WriteLine($"Product delivered by {TransitType} to {customer.FullName}");
        }
    }

    public class Product
    {
        /*
          Properties
        */
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; } = 1;

        /*
          Methods
        */
        public void Ship(Customer customer, DeliveryService service)
        {
            if (!customer.IsLocal)
            {
                service.Deliver(this, customer);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.ChangeFirstName("a");
            Console.Write(customer.FullName);



            Product tinkerToys = new Product()
            {
                Title = "Tinker Toys",
                Description = "You can build anything you want"


            };

            Customer marcus = new Customer()
            {
                FirstName = "Marcus",
                LastName = "Fulbright",
                IsLocal = false
            };

            Customer jane = new Customer();
            jane.FirstName = "Jane";
            jane.LastName = "Doe";
            jane.IsLocal = false;

            DeliveryService UPS = new DeliveryService()
            {
                Name = "UPS",
                TransitType = "train"
            };

            Console.WriteLine(tinkerToys.Quantity);

            //UPS.TransitType = "carrier pigeon";


            // Ship the tinker toys to Marcus using UPS
            tinkerToys.Ship(marcus, UPS);
        }
    }
}