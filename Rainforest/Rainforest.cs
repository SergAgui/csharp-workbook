using System;
using System.Collections.Generic;

namespace Rainforest
{
    class Program
    {
        // wrappers around items, containers
        // if interface
        //make a dictionary and wrap the items

        static void Main(string[] args)
        {
            string[] items = System.IO.File.ReadAllLines(@"./items.txt");
            Company rainforest = new Company("Rainforest LLC");
            
            string[] cities = new string[] {"Austin", "Houston", "Dallas", "San Antonio"};            
            foreach (var city in cities)
            {
                Warehouse warehouse = new Warehouse(city, 1);
                rainforest.warehouses.Add(warehouse);
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++)
            {
                Warehouse warehouse = rainforest.warehouses[i];
                Container container = new Container ( $"{warehouse.location}- 1", i + 1);
                rainforest.warehouses[i].containers.Add(container);
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++)
            {
                Container container = rainforest.warehouses[i].containers[0];
                Item item = new Item (items[i], i);
                container.items.Add(item);
            }

            foreach (var thing in items)
            {
                Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            }

            Console.WriteLine("Hello World!");
        }
    }
    class Company
    {
        public string name;
        public List<Warehouse> warehouses = new List<Warehouse>();
        public Company(string name)
        {
            this.name = name;
        }

    }

    class Warehouse
    {
        public string location;
        public int size;
        public List<Container> containers;

        public Warehouse(string location, int size)
        {
            this.location = location;
            this.size = size;
            this.containers = new List<Container>();
        }

        public string AddContainer(Container container)
        {
            if (this.containers.Count < this.size)
            {
                this.containers.Add(container);
                return "";
            }
            return "No more room";
        }
    }
    
    class Container
    {
        public List<Item> items;
        public int size;
        public string id;

        public Container(string id, int size)
        {
            this.size = size;
            this.id = id;
            this.items = new List<Item>();
        }
    }
    
    class Item
    {
        public string name;
        public double price;

        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        } 
    }   
}