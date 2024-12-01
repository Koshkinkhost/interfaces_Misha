using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces
{
    public partial class Fight : Form
    {
        private int playerHealth = 100;  // Здоровье игрока
        private int enemyHealth = 100;   // Здоровье противника
        private List<IWeapon> weapons;   

        public Fight()
        {
            InitializeComponent();


            weapons = Form1.h.weapons;
            
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            UpdateHealth();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   выбора оружия
          WeaponSelect w=new WeaponSelect();
            w.ShowDialog();
        }

        private void UpdateHealth()
        {
            
            labelPlayerHealth.Text = $"Здоровье игрока: {playerHealth}";
            labelEnemyHealth.Text = $"Здоровье противника: {enemyHealth}";
        }
    }

    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public override string ToString()
        {
            return $"{Name} (Урон: {Damage})";
        }
    }

   
}
