using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
    /// <summary>
    /// With interfaces I know you can declare them like classes as much as you want.
    /// But with classes can inherit from interfaces and use the varibles/functions inside it.
    /// Equipment, Damage, TakeDamage, Health?, Skills
    /// public by default? 
    /// </summary>

    public interface Damage // outgoing damage
    {
        int damage { get; }
    }

    public interface TakeDamage // incoming damage
    {
        int takeDamage(int amountDamage);
    }
}
