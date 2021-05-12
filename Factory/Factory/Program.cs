using System;
using Factory.Cannons;
using Factory.Cannons.Type;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CannonsCreator cannonsCreator = CannonsCreator.getInstance();
            I_AbstractCannon laserCannon = cannonsCreator.create(E_CannonType.LASER_CANNON);

            Console.WriteLine(laserCannon.ToString());
        }
    }
}
