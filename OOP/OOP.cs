using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Person luke = new Person("Luke", "Skywalker", "Rebel");
            Person leia = new Person("Leia", "Organa", "Rebel");
            Person solo = new Person("Han", "Solo", "Rebel");
            Person vader = new Person("Darth", "Vader", "Imperial");
            Person emperor = new Person("Emperor", "Palpatine", "Imperial");
            Ship falcon = new Ship("Rebel", "Smuggling", 3);
            Ship xWing = new Ship("Rebel", "Fighter", 2);
            Ship tie = new Ship("Imperial", "Fighter", 1);
            Ship imperialTie = new Ship("Imperial", "Fighter", 2);
            Station rebelStation = new Station("Rebel", "Rebel Space Station", 6);
            Station imperialStation = new Station("Imperial", "Death Star", 20);

            rebelStation.EnterStation(falcon, 0);
            rebelStation.EnterStation(xWing, 1);
            imperialStation.EnterStation(tie, 0);
            imperialStation.EnterStation(imperialTie, 1);
            falcon.EnterShip(solo, 0);
            falcon.EnterShip(leia, 1);
            xWing.EnterShip(luke, 0);
            tie.EnterShip(vader, 0);
            imperialTie.EnterShip(emperor, 0);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("To see the roster of all ships and their passengers,");
            Console.WriteLine("please say, 'Roster'.");
            Console.WriteLine("To move a ship from one station to the other, say one of the following:");
            Console.WriteLine("Move Falcon, Move Tie, Move XWing, Move Imperial");
            // below is for debugging
            // Console.WriteLine("This is not the ship you're looking for...");


            do
            {
                string read = Console.ReadLine().ToLower();
                switch (read)
                {
                    case "roster":
                        // show ship names and their passengers
                        Console.WriteLine("The rebel station is holding the following:");
                        if(Array.Exists(rebelStation.spaces, element => element == falcon))
                        {
                            Console.WriteLine("The Millennium Falcon, whose passengers are:");
                            if (falcon.passengers[0] != null)
                            {
                                Console.WriteLine(falcon.passengers[0].FullName);
                            }
                            if (falcon.passengers[1] != null)
                            {
                                Console.WriteLine(falcon.passengers[1].FullName);
                            }
                            if (falcon.passengers[2] != null)
                            {
                                Console.WriteLine(falcon.passengers[2].FullName);
                            }
                        }
                        if (Array.Exists(rebelStation.spaces, element => element == xWing))
                        {
                            Console.WriteLine("An X Wing, whose passengers are:");
                            if (xWing.passengers[0] != null)
                            {
                                Console.WriteLine(xWing.passengers[0].FullName);
                            }
                            if (xWing.passengers[1] != null)
                            {
                                Console.WriteLine(xWing.passengers[1].FullName);
                            }
                            else if (xWing.passengers[0] == null && xWing.passengers[1] == null)
                            {
                                Console.WriteLine("No one yet");
                            }
                        }
                        if (Array.Exists(rebelStation.spaces, element => element == tie))
                        {
                            Console.WriteLine("A captured Tie Fighter, whose pilot is:");
                            if (tie.passengers[0] != null)
                            {
                                Console.WriteLine(tie.passengers[0].FullName);
                            }
                            else if (tie.passengers[0] == null)
                            {
                                Console.WriteLine("No one yet");
                            }
                        }
                        if (Array.Exists(rebelStation.spaces, element => element == imperialTie))
                        {
                            Console.WriteLine("A captured Imperial Fighter, whose passengers are:");
                            if (imperialTie.passengers[0] != null)
                            {
                                Console.WriteLine(imperialTie.passengers[0].FullName);
                            }
                            if (imperialTie.passengers[1] != null)
                            {
                                Console.WriteLine(imperialTie.passengers[1].FullName);
                            }
                            else if (imperialTie.passengers[0] == null && imperialTie.passengers[1] == null)
                            {
                                Console.WriteLine("No one yet");
                            }
                        }
                        Console.WriteLine("And that's it.");
                        Console.WriteLine(" ");
                        Console.WriteLine("The Imperial Station is holding the following:");
                        if(Array.Exists(imperialStation.spaces, element => element == falcon))
                        {
                            Console.WriteLine("The now captured Millennium Falcon, whose passengers are:");
                            if (falcon.passengers[0] != null)
                            {
                                Console.WriteLine(falcon.passengers[0].FullName);
                            }
                            if (falcon.passengers[1] != null)
                            {
                                Console.WriteLine(falcon.passengers[1].FullName);
                            }
                            if (falcon.passengers[2] != null)
                            {
                                Console.WriteLine(falcon.passengers[2].FullName);
                            }
                        }
                        if (Array.Exists(imperialStation.spaces, element => element == xWing))
                        {
                            Console.WriteLine("A captured X Wing, whose passengers are:");
                            if (xWing.passengers[0] != null)
                            {
                                Console.WriteLine(xWing.passengers[0].FullName);
                            }
                            if (xWing.passengers[1] != null)
                            {
                                Console.WriteLine(xWing.passengers[1].FullName);
                            }
                            else if (xWing.passengers[0] == null && xWing.passengers[1] == null)
                            {
                                Console.WriteLine("No one yet");
                            }
                        }
                        if (Array.Exists(imperialStation.spaces, element => element == tie))
                        {
                            Console.WriteLine("A Tie Fighter, whose pilot is:");
                            if (tie.passengers[0] != null)
                            {
                                Console.WriteLine(tie.passengers[0].FullName);
                            }
                            else if (tie.passengers[0] == null)
                            {
                                Console.WriteLine("No one yet");
                            }
                        }
                        if (Array.Exists(imperialStation.spaces, element => element == imperialTie))
                        {
                            Console.WriteLine("An Imperial Fighter, whose passengers are:");
                            if (imperialTie.passengers[0] != null)
                            {
                                Console.WriteLine(imperialTie.passengers[0].FullName);
                            }
                            if (imperialTie.passengers[1] != null)
                            {
                                Console.WriteLine(imperialTie.passengers[1].FullName);
                            }
                            else if (imperialTie.passengers[0] == null && imperialTie.passengers[1] == null)
                            {
                                Console.WriteLine("No one yet");
                            }
                        }
                        Console.WriteLine("And that's it.");
                        continue;
                    case "move falcon":
                        // move ship from station to station
                        if(Array.Exists(rebelStation.spaces, element => element == falcon))
                        {
                            // if the falcon exists in the rebel station, then Exit Station
                            rebelStation.ExitStation(null, (Array.IndexOf(rebelStation.spaces, falcon)));
                            // Find a null in the imperial station and Enter Station
                            imperialStation.EnterStation(falcon, Array.IndexOf(imperialStation.spaces, null));
                            Console.WriteLine("The Falcon has been captured!!");
                        }
                        else if(Array.Exists(imperialStation.spaces, element => element == falcon))
                        {
                            // if the falcon exists in the rebel station, then Exit Station
                            imperialStation.ExitStation(null, (Array.IndexOf(imperialStation.spaces, falcon)));
                            // Find a null in the imperial station and Enter Station
                            rebelStation.EnterStation(falcon, Array.IndexOf(rebelStation.spaces, null));
                            Console.WriteLine("The Falcon has returned to the rebel station.");
                        }
                            continue;
                    case "move tie":
                        if(Array.Exists(rebelStation.spaces, element => element == tie))
                        {
                            rebelStation.ExitStation(null, (Array.IndexOf(rebelStation.spaces, tie)));
                            imperialStation.EnterStation(tie, Array.IndexOf(imperialStation.spaces, null));
                            Console.WriteLine("The Tie Fighter has returned to the Imperial Station.");
                        }
                        else if(Array.Exists(imperialStation.spaces, element => element == tie))
                        {
                            imperialStation.ExitStation(null, (Array.IndexOf(imperialStation.spaces, tie)));
                            rebelStation.EnterStation(tie, Array.IndexOf(rebelStation.spaces, null));
                            Console.WriteLine("The Tie Fighter has been captured by the rebels!!");
                        }
                            continue;
                    case "move xwing":
                        if(Array.Exists(rebelStation.spaces, element => element == xWing))
                        {
                            rebelStation.ExitStation(null, (Array.IndexOf(rebelStation.spaces, xWing)));
                            imperialStation.EnterStation(xWing, Array.IndexOf(imperialStation.spaces, null));
                            Console.WriteLine("The X Wing has been captured!!");
                        }
                        else if(Array.Exists(imperialStation.spaces, element => element == xWing))
                        {
                            imperialStation.ExitStation(null, (Array.IndexOf(imperialStation.spaces, xWing)));
                            rebelStation.EnterStation(xWing, Array.IndexOf(rebelStation.spaces, null));
                            Console.WriteLine("The X Wing has retunred to the rebel Station.");
                        }
                            continue;
                    case "move imperial":
                        if(Array.Exists(rebelStation.spaces, element => element == imperialTie))
                        {
                            rebelStation.ExitStation(null, (Array.IndexOf(rebelStation.spaces, imperialTie)));
                            imperialStation.EnterStation(imperialTie, Array.IndexOf(imperialStation.spaces, null));
                            Console.WriteLine("The Imperial Fighter has returned to the Imperial Station.");
                        }
                        else if(Array.Exists(imperialStation.spaces, element => element == imperialTie))
                        {
                            imperialStation.ExitStation(null, (Array.IndexOf(imperialStation.spaces, imperialTie)));
                            rebelStation.EnterStation(imperialTie, Array.IndexOf(rebelStation.spaces, null));
                            Console.WriteLine("The Imperial Fighter has been captured!!");
                        }
                            continue;
                    default:
                        Console.WriteLine("This is not the command you are looking for");
                        continue;
                }
            }
            while (Console.ReadLine().ToLower() != "done");

        }
    }

    class Person
    {
        string firstName;
        string lastName;
        string alliance;
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
        public Person[] passengers;
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
                    Console.WriteLine(person.FullName);
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
        public Ship[] spaces;
        string stationName;
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
    }
}
