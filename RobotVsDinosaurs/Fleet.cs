using System;
using System.Collections.Generic;

namespace RobotVsDinosaurs
{
    public class Fleet
    {

        // MEMBER VARIABLES ( HAS A )
        // I want the created Robot objects in Fleet
        public List<Robot> robots;
        public List<Weapon> weapons;
        public Random randomNum;
        public Random randomGun;

        // CONSTRUCTER (SPAWNER)
        public Fleet()
        {
            robots = new List<Robot>();
            weapons = new List<Weapon>();
            randomNum = new Random();
            

            //move the instantiation of the three robots in here
            //After instantiating, add them to the robots list

            weapons.Add(new Weapon("Sword",randomNum.Next(10)));
            weapons.Add(new Weapon("Axe", randomNum.Next(10)));
            weapons.Add(new Weapon("Gun", randomNum.Next(10)));


            Console.WriteLine($"Choose your weapon for Terminator: 1:{weapons[0].name} 2:{weapons[1].name} 3:{weapons[2].name}");
            int robotOneGun = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"You picked {weapons[robotOneGun].name} for your Terminator!");
            Console.WriteLine();

            robots.Add(new Robot("Terminator", weapons[robotOneGun]));

            Console.WriteLine($"Choose your weapon for ThroneX: 1:{weapons[0].name} 2:{weapons[1].name} 3:{weapons[2].name}");
            int robotTwoGun = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"You picked {weapons[robotTwoGun].name} for ThroneX!");
            Console.WriteLine();

            robots.Add(new Robot("ThroneX", weapons[robotTwoGun]));

            Console.WriteLine($"Choose your weapon for Mr. J: 1:{weapons[0].name} 2:{weapons[1].name} 3:{weapons[2].name}");
            int robotThreeGun = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"You picked {weapons[robotThreeGun].name} for Mr. J!");
            Console.WriteLine();

            robots.Add(new Robot("Mr. J", weapons[robotThreeGun]));
        }

        //MEMBER METHODS
    }
}
