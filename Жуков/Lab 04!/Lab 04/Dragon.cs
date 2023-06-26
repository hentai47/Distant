using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class Dragon
    {
        public int MaxHP = 10000;
        public int Hp = 8000;
        public int Strengh = 2000;

        public int Attack()
        {
            int attack = new Random().Next(Strengh);
            return attack;
        }

        public void KeepDm(int dmg)
        {
            Hp -= dmg;
            if (Hp < 0) { Hp = 0; }
        }

        public void Heal(int heal)
        {
            Hp += heal;
            if (Hp > MaxHP) { Hp = MaxHP; }
        }

    }
}
