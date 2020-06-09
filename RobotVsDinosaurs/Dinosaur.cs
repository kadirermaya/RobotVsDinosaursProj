using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVsDinosaurs
{
    public class Dinosaur
    {


        // MEMBER VARIABLES ( HAS A )
        public string type;
        public int health;
        public int energy;
        public int attackPower;



        // CONSTRUCTER (SPAWNER)

        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackPower = attackPower;
        }
        
        //MEMBER METHODS

        public void DinoAttacksToRobot(Robot robot)
        {
            robot.health = attackPower;
            Console.WriteLine($"{type} attacked to {robot}. And {robot} new health is {robot.health}.");
        }
    }
}









//type = "Jurassic";
//            health = 100;
//            energy = 100;
//            attackPower = 100;