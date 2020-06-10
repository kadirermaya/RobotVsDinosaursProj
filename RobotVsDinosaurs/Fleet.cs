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

            robots.Add(new Robot("Terminator", weapons[1]));
            robots.Add(new Robot("ThroneX", weapons[2]));
            robots.Add(new Robot("Mr. J", weapons[0]));
        }

        //MEMBER METHODS
    }
}
