using System.Collections.Generic;

namespace RobotVsDinosaurs
{
    public class Fleet
    {

        // MEMBER VARIABLES ( HAS A )
        // I want the created Robot objects in Fleet
        public List<Robot> fleet;
        public List<Weapon> weapons;
      
        public Robot robot1;
        public Robot robot2;
        public Robot robot3;
        

        // CONSTRUCTER (SPAWNER)
        public Fleet()
        {
            fleet = new List<Robot>();
            weapons = new List<Weapon>();
            
            //move the instantiation of the three robots in here
            //After instantiating, add them to the robots list

            weapons.Add(new Weapon("sword", 3));
            weapons.Add(new Weapon("Axe", 8));
            weapons.Add(new Weapon("sword", 8));

            robot1 = new Robot("Selçuk", weapons[1]);
            robot2 = new Robot("Kadir", weapons[2]);
            robot3 = new Robot("Mustafa", weapons[0]);

            fleet.Add(robot1);
            fleet.Add(robot2);
            fleet.Add(robot3);


        }

        //MEMBER METHODS
    }
}
