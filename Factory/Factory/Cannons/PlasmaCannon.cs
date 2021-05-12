using Factory.Cannons.Type;

namespace Factory
{
    public class PlasmaCannon : AbstractCannon
    {
        internal PlasmaCannon()
        {
            this.cannonType = E_CannonType.PLASMA_CANNON;
            this.armor = 1000;
            this.fireRange = 1000;
            this.fireRate = 10;
            this.shotPower = 100;
        }

        internal void setPrice(float price)
        {
            this.price = price;
        }
    }
}