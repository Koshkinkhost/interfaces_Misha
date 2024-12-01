using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Creature
    {
        public string Name;
        private int health;
        private double max_weight;
        private double wallet;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public double Weight
        {
            get { return max_weight; }
            set { max_weight = value; }
        }
        public double Wallet
        {
            get { return wallet; }
            set { wallet = value; }
        }

        public List<Subject> subjects;
        public List<IWeapon> weapons=new List<IWeapon>();
        public IWeapon SelectedWeapon;

    }
}
