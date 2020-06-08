
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVsDinosaurs
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(new Weapon("sword", 3));
            weapons.Add(new Weapon("Axe", 8));
            weapons.Add(new Weapon("sword", 8));


            var robot1 = new Robot("Selçuk", weapons[1]);
            var robot2 = new Robot("Kadir", weapons[2]);
            var robot3 = new Robot("Mustafa", weapons[0]);

            var dino1 = new Dinosaur("Velociraptor", 3);
            var dino2 = new Dinosaur("Allosaurus", 5);
            var dino3 = new Dinosaur("Carnotaurus", 8);

            Fleet fleet = new Fleet();
            fleet.robots.Add(robot1);
            fleet.robots.Add(robot2);
            fleet.robots.Add(robot3);

            Herd herd = new Herd();
            herd.dinosaurs.Add(dino1);
            herd.dinosaurs.Add(dino2);
            herd.dinosaurs.Add(dino3);
        }
    }
}
