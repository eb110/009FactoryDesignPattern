using Factory.Cannons.Type;

namespace Factory
{
    public class MachineCannon : AbstractCannon
    {
        internal MachineCannon()
        {
            this.cannonType = E_CannonType.MACHINE_CANNON;
            this.armor = 800;
            this.fireRange = 300;
            this.fireRate = 1000;
            this.shotPower = 10;
        }

        internal void setPrice(float price)
        {
            this.price = price;
        }
    }
}