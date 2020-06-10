using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVsDinosaurs
{
    public class Herd
    {

        // MEMBER VARIABLES ( HAS A )

        public List<Dinosaur> dinosaurs;
        public Random randomNumb; 
        // CONSTRUCTER (SPAWNER)

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            randomNumb = new Random();
            

            dinosaurs.Add(new Dinosaur("Velociraptor", randomNumb.Next(10)));
            dinosaurs.Add(new Dinosaur("Allosaurus", randomNumb.Next(10)));
            dinosaurs.Add(new Dinosaur("Carnotaurus", randomNumb.Next(10)));

            
        }

        //MEMBER METHODS
        public void AttackToRobot()
        {

        }

    }
}
