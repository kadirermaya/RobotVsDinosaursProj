using System.Collections.Generic;

namespace RobotVsDinosaurs
{
    public class Fleet
    {

        // MEMBER VARIABLES ( HAS A )
        // I want the created Robot objects in Fleet
        public List<Robot> robots;
        public List<Weapon> weapons;
        public Fleet fleet;
        public Robot robot1;
        public Robot robot2;
        public Robot robot3;
        

        // CONSTRUCTER (SPAWNER)
        public Fleet()
        {
            robots = new List<Robot>();
            weapons = new List<Weapon>();
            fleet = new Fleet();
            //move the instantiation of the three robots in here
            //After instantiating, add them to the robots list

            weapons.Add(new Weapon("sword", 3));
            weapons.Add(new Weapon("Axe", 8));
            weapons.Add(new Weapon("sword", 8));

            robot1 = new Robot("Selçuk", weapons[1]);
            robot2 = new Robot("Kadir", weapons[2]);
            robot3 = new Robot("Mustafa", weapons[0]);

            fleet.robots.Add(robot1);
            fleet.robots.Add(robot2);
            fleet.robots.Add(robot3);


        }

        //MEMBER METHODS
    }
}
