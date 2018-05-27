using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Person rebel1 = new Person("Luke", "Skywalker", "Rebel");
            Person rebel2 = new Person("Leia", "Organa", "Rebel");
            Person rebel3 = new Person("Han", "Solo", "Rebel");
            Person imperial2 = new Person("Darth", "Vader", "Imperial");
            Person imperial1 = new Person("Emperor", "Palpatine", "Imperial");
            Ship falcon = new Ship("Rebel", "Smuggling", 3);
            Ship xWing1 = new Ship("Rebel", "Fighter", 2);
            Ship tie = new Ship("Imperial", "Fighter", 1);
            Station rebelStation = new Station("Rebel", "Rebel Space Station", 6);
            Station imperialStation = new Station("Imperial", "Death Star", 20);
            Console.WriteLine("This is not the ship you're looking for...");

        }
    }

    class Person
    {
        private string firstName;
        private string lastName;
        private string alliance;
        public Person(string firstName, string lastName, string alliance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.alliance = alliance;
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
            set
            {
                string [] names = value.Split(' ');
                this.firstName = names[0];
                this.lastName = names[1];
            }
        }
    }

    class Ship
    {
        private Person[] passengers;
        public Ship(string alliance, string type, int size)
        {
            this.Type = type;
            this.Alliance = alliance;
            this.passengers = new Person[size];
        }

        public string Type { get; set; }

        public string Alliance { get; set; }

        public string Passengers
        {
            get
            {
                foreach (var person in passengers)
                {
                    Console.WriteLine(String.Format("{0}", person.FullName));
                }
                return "That's Everybody!";
            }
        }

        public void EnterShip(Person person, int seat)
        {
            this.passengers[seat] = person;
        }
        public void ExitShip(Person person, int seat)
        {
            this.passengers[seat] = null;
        }
    }

    class Station
    {
        //names, how many ships can be held, roster of all people and thier ships
        private Ship[] spaces;
        private string stationName;
        public string Alliance { get; set; }
        public Station(string alliance, string name, int size)
        {
            this.Alliance = alliance;
            this.stationName = name;
            this.spaces = new Ship[size];
        }
        public void EnterStation(Ship ship, int spot)
        {
            this.spaces[spot] = ship;
        }
        public void ExitStation(Ship ship, int spot)
        {
            this.spaces[spot] = null;
        }

        public void Roster(string shipName)
        {
            foreach (var craft in spaces)
            {
                //Console.WriteLine(String.Format("{0}", craft.
                //maybe set the name of the ship first and then find out name
            }
        }
    }
}
