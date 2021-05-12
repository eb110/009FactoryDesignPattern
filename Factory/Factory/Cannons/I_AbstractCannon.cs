using System;
using System.Collections.Generic;
using System.Text;
using Factory.Cannons.Type;

namespace Factory.Cannons
{
    public interface I_AbstractCannon
    {
        E_CannonType getCannonType();
        int getFireRate();
        int getArmor();
        int getShotPower();
        int getFireRange();
        float getPrice();
    }
}
