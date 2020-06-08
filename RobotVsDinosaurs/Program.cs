
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
            List<Dinosaur> dinosours = new List<Dinosaur>();
            dinosours.Add(new Dinosaur("Velociraptor", 3));
            dinosours.Add(new Dinosaur("Allosaurus", 5));
            dinosours.Add(new Dinosaur("Carnotaurus", 8));
            List<Robot> robots = new List<Robot>();
            robots.Add(new Robot("Terminator", weapons[0]));
            robots.Add(new Robot("Trone", weapons[1]));
            robots.Add(new Robot("ThorX", weapons[2]));

        }
    }
}
