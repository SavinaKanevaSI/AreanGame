using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface IHero//в интерфейса няма логика, а само е зададено какво да се ползва
    {
        double Attack();//метод
        double Defend(double damage);//метод
    }
}
