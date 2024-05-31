using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Fairy : Hero
    {
        public Fairy(string name, double armor, double strenght, IWeapon weapon) : //конструктор 
        base(name, armor, strenght, weapon)
        {

        }

        public override double Attack()
        {
            double totalDamage = Strenght + Weapon.AttackDamage +WingsStrike(0.5);//общият демидж, който може да се нанесе = 
            //=силата + демиджа на оръжието на героя
            double coef = random.Next(80, 120 + 1); //демиджа на атаката да е между 80% или 120%
            double realDamage = totalDamage * (coef / 100);//демиджа, който се нанася = общия демидж умножен по процента от предния ред
            return realDamage;//връща демиджа от предния ред
        }

        public double WingsStrike(double probability)//probability - число между 0 и 1; шанса метода да проработи (за двойна атака)
        {
            if (new Random().NextDouble() <= probability)
            {
                return this.Weapon.AttackDamage;//
            }
            return 0;
        }




    }
}
