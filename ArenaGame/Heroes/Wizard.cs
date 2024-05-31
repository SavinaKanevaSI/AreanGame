using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Wizard : Hero
    {
        private double hitCount;
        public Wizard(string name, double armor, double strenght, IWeapon weapon) : //конструктор 
        base(name, armor, strenght, weapon)
        {
            hitCount = 0;
        }

        //да може да ползва пръчката и за атака и за защита 
        public override double Attack()
        {
            hitCount++;
            double dmg = base.Attack();
            if(hitCount == 3) {
                return dmg * 2;
            }
            return dmg;
        }
        public override double Defend(double damage)
        {
            Random defend = new Random();
            if (defend.Next(1, 6) == 1)
                return base.Defend(0);
            return base.Defend(damage);
        }
        //на всеки три нанесени удъра да удвоява силата на атаката (атака)
        //да има възможност да се избегне атаката (защита)




    }
}
