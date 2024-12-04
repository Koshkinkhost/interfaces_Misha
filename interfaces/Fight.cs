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
            WeaponSelect w = new WeaponSelect();
            w.ShowDialog();
        }

        private void UpdateHealth()
        {

            labelPlayerHealth.Text = $"Здоровье игрока: {Form1.h.Health}";
            labelEnemyHealth.Text = $"Здоровье противника: {Form1.en.Health}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Form1.h.SelectedWeapon is not null)
            {
                Form1.h.Attack(Form1.en, Form1.h.SelectedWeapon);
                Random r = new Random();
                Form1.en.SelectedWeapon = shop.weapons[r.Next(0,shop.weapons.Count)];
                Form1.en.Attack(Form1.h, Form1.en.SelectedWeapon);
                UpdateHealth();
            }
            
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
