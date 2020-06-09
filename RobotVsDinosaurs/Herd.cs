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
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;

        // CONSTRUCTER (SPAWNER)

        public Herd()
        {
           dinosaurs = new List<Dinosaur>();

            dino1 = new Dinosaur("Velociraptor", 3);
            dino2 = new Dinosaur("Allosaurus", 5);
            dino3 = new Dinosaur("Carnotaurus", 8);

            dinosaurs.Add(dino1);
            dinosaurs.Add(dino2);
            dinosaurs.Add(dino3);

        }

        //MEMBER METHODS
        public void AttackToRobot()
        {

        }

    }
}
