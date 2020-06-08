using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVsDinosaurs
{
    public class Robot
    {

        //MEMBER VARIABLES(HAS A)

        string name;
        int health;
        int powerLevel;
        Weapon weapon;




        // CONSTRUCTER (SPAWNER)

        public Robot(string name, Weapon weapon)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            this.weapon = weapon;

        }


        //MEMBER METHODS
    }
}










