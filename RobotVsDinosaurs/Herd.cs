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

        public List<Dinosaur> herd;
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;

        // CONSTRUCTER (SPAWNER)

        public Herd()
        {
            herd = new List<Dinosaur>();

            dino1 = new Dinosaur("Velociraptor", 3);
            dino2 = new Dinosaur("Allosaurus", 5);
            dino3 = new Dinosaur("Carnotaurus", 8);

            herd.Add(dino1);
            herd.Add(dino2);
            herd.Add(dino3);

        }

        //MEMBER METHODS
        public void AttackToRobot()
        {

        }

    }
}
