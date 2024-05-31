using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Assassin : Hero//клас асасин, който наследява герой
    {
        public Assassin(string name, double armor, double strenght, IWeapon weapon) : //конструктор 
            base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()//метод за 
        {
            double damage = base.Attack();//

            double probability = random.NextDouble();//случайно число за възможност за critical damage
            if (probability < 0.10)//ако е по малко от това, да му направи damage по 3 
            {
                damage *= 3;
            }
            return damage;//връща получения резултат
        }

        //може би трябва да се допише нещо за defence 
    }
}
