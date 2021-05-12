using Factory.Cannons.Type;
using Factory.Cannons;

namespace Factory
{
    public abstract class AbstractCannon : I_AbstractCannon
    {
        protected E_CannonType cannonType;
        protected int fireRate;
        protected int armor;
        protected int shotPower;
        protected int fireRange;
        protected float price;

        public int getArmor()
        {
            return armor;
        }

        public E_CannonType getCannonType()
        {
            return cannonType;
        }

        public int getFireRange()
        {
            return fireRange;
        }

        public int getFireRate()
        {
            return fireRate;
        }

        public float getPrice()
        {
            return price;
        }

        public int getShotPower()
        {
            return shotPower;
        }

        public override string ToString()
        {
            return "Cannon type: " + cannonType;
        }
    }
}