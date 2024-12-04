using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface IFighter
    {
        void Attack(Creature c, IWeapon w);
    }
    public class Hero : Creature, IFighter
    {

        public void Attack(Creature c, IWeapon w)
        {
            int damage = w.GetDamage();
            c.Health -= damage;

        }



    }
    public class Enemy : Creature, IFighter
    {

        public void Attack(Creature c, IWeapon w)
        {
            int damage = w.GetDamage();
            c.Health -= damage;
        }
    }
}
