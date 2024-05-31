using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Hero : IHero// публичен клас герой, който наследява интерфейса герой
    {
        protected Random random = new Random();//произволно число; private set  за да може да се достъпва само от метод или конструкут само в класа Герой
        public string Name { get; private set; }//име на героя
        public double Health { get; private set; }//живота на героя
        public double Armor { get; private set; }//бронята на героя
        public double Strenght { get; private set; }//силата на героя
        public IWeapon Weapon { get; private set; }
        public bool IsAlive//ако героя е жив, изписва живота, който е по-голям от 0
        {
            get
            {
                return Health > 0;
            }
        }

        public Hero(string name, double armor, double strenght, IWeapon weapon)//конструктур на героя
        {
            Health = 100;//първоначална стойност на живота 

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = weapon;
        }


        // returns actual damage
        public virtual double Attack()//virtual - метод, който може да се override-ва в дъщерен клас
        {
            double totalDamage = Strenght + Weapon.AttackDamage;//общият демидж, който може да се нанесе = 
            //=силата + демиджа на оръжието на героя
            double coef = random.Next(80, 120 + 1); //демиджа на атаката да е между 80% или 120%
            double realDamage = totalDamage * (coef / 100);//демиджа, който се нанася = общия демидж умножен по процента от предния ред
            return realDamage;//връща демиджа от предния ред
        }

        public virtual double Defend(double damage)// ако не се override-не, ще пише това тука, ако се - ще пише другото от новия метод
        {
            double coef = random.Next(80, 120 + 1);//отново случаен коефициент 
            double defendPower = (Armor + Weapon.BlockingPower) * (coef / 100);//бронята + блокиращата сила на оръжието умножено 
            //по процента (дали ще блокира 80 или повече до 120% от атаката)
            double realDamage = damage - defendPower;//нанесения демидж = демиджа без защитата
            if (realDamage < 0)//ако нанесения демидж е по-малък от 0, казваш че не е нанесен демидж
                realDamage = 0;
            Health -= realDamage;//живовта се намаля с нанесения демидж
            return realDamage;//връща се финалният резултат
        }

        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health,2)}";
        }
    }
}
