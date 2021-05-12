using Factory.Cannons.Type;

namespace Factory
{
    public class LaserCannon : AbstractCannon
    {
        internal LaserCannon()
        {
            this.cannonType = E_CannonType.LASER_CANNON;
            this.armor = 500;
            this.fireRange = 600;
            this.fireRate = 100;
            this.shotPower = 40;
        }

        internal void setPrice(float price)
        {
            this.price = price;
        }
    }
}