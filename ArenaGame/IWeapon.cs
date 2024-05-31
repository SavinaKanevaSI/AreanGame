using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface IWeapon//интерфейс за оръжието 
    {
        string Name { get; set; }
        double AttackDamage { get; } 
        double BlockingPower { get; }
    }
}
