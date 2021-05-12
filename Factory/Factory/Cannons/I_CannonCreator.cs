using Factory.Cannons.Type;
using Factory.Cannons;

namespace Factory
{
    public interface I_CannonCreator
    {
        I_AbstractCannon create(E_CannonType cannonType);
    }
}