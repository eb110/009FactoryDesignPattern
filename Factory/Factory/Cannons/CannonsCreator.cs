using System;
using Factory.Cannons;
using Factory.Cannons.Type;

namespace Factory
{
    public class CannonsCreator : I_CannonCreator
    {
        private static readonly CannonsCreator instance = new CannonsCreator();

        private CannonsCreator()
        {
            Console.WriteLine("Singleton created");
        }

        public static CannonsCreator getInstance()
        {
            return instance;
        }

        public I_AbstractCannon create(E_CannonType cannonType)
        {
            I_AbstractCannon cannon;

            switch (cannonType)
            {
                case E_CannonType.LASER_CANNON:
                    LaserCannon laserCannon = new LaserCannon();
                    laserCannon.setPrice(3000);
                    cannon = laserCannon;
                    break;
                case E_CannonType.PLASMA_CANNON:
                    PlasmaCannon plasmaCannon = new PlasmaCannon();
                    plasmaCannon.setPrice(5000);
                    cannon = plasmaCannon;
                    break;
                case E_CannonType.MACHINE_CANNON:
                    MachineCannon machineCannon = new MachineCannon();
                    machineCannon.setPrice(1000);
                    cannon = machineCannon;
                    break;
                default:
                    cannon = null;
                    break;
            }

            return cannon;
        }
    }
}