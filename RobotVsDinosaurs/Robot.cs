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

        public string name;
        public int health;
        public int powerLevel;
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

        public void RobotAttacksToDino(Dinosaur dinosaur)
        {

            
            dinosaur.health -= weapon.attackPower;

            if (dinosaur.health < 0)
            {
                dinosaur.health = 0;
                
            }
            
            
        }
    }
}










