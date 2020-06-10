using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVsDinosaurs
{
    public class Battlefield
    {
        // Only one robot and one dino will start fighting
        // winner will stay in the fight until his health reaches 0
        // whoever reaches zero from the teams will be changed automatically but that change will work only teams count
        // end of the battle last characters health points the winner team


        // MEMBER VARIABLES ( HAS A )

        public Fleet fleet;
        public Herd herd;



        // CONSTRUCTER (SPAWNER)
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //MEMBER METHODS

        public void Fight()
        {
            

            int currentRobotIndex = 0;
            int currentDinoIndex = 0;

            Robot robot = fleet.robots[currentRobotIndex];
            Dinosaur dino = herd.dinosaurs[currentDinoIndex];

            while (currentRobotIndex < 3 && currentDinoIndex < 3)
            {
                robot.RobotAttacksToDino(dino);
                dino.DinoAttacksToRobot(robot);

                if (robot.health == 0)
                {
                    currentRobotIndex++;
                    if (currentRobotIndex < 3)
                    {
                        robot = fleet.robots[currentRobotIndex];
                    }
                }

                if (dino.health == 0)
                {
                    currentDinoIndex++;
                    if (currentDinoIndex < 3)
                    {
                        dino = herd.dinosaurs[currentDinoIndex];
                    }
                }
            }

            if (robot.health > 0)
            {
                Console.WriteLine("Robots win the game!");
            }
            else if (dino.health > 0)
            {
                Console.WriteLine("Dinosaurs win the game!");
            }


            
        }
    }

}


//public void FightStops()
//{

//    while (robot.health != 0 && dinosaur.health != 0)
//    {
//        dinosaur.DinoAttacksToRobot(robot);
//        robot.RobotAttacksToDino(dinosaur);
//        if (dinosaur.health == 0)
//        {
//            Console.WriteLine($"{robot} Win this round!");
//        }
//        else if (dinosaur.health == 0)
//        {

//            Console.WriteLine($"{dinosaur} Win this round!");

//        }
//    }


//}
//public void RunGame()
//{


//}



