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
    public partial class shop : Form
    {
        
        public static List<IWeapon> weapons = new List<IWeapon>()
        {
            new Knife() { name = "Knife1", damage = 120, price = 250 },
            new Bow() { name = "Bow1", damage = 200, price = 450 },
            new Gun() { name = "Gun1", damage = 350, price = 600 }
        };
        public shop()
        {

            InitializeComponent();

        }

        private void shop_Load(object sender, EventArgs e)
        {
            label_money.Text=Form1.h.Wallet.ToString();
            foreach (IWeapon weapon in weapons)
            {
                WeaponsList.Items.Add(weapon);
            }
        }
        public void PurchaseWeapon(Creature other, IWeapon w)
        {
            if (weapons.Contains(w))
            {
                if (other.Wallet >= w.GetPrice())
                {
                    other.Wallet -= w.GetPrice(); 
                    other.weapons.Add(w);
                    MessageBox.Show(other.weapons.Count.ToString());
                   
                    weapons.Remove(w); 
                    UpdateWeaponList();
                    label_money.Text= Form1.h.Wallet.ToString();

                    
                }
                else
                {
                    MessageBox.Show("Не хватает денег!");
                }
                
            }

        }
        private void UpdateWeaponList()
        {
            WeaponsList.Items.Clear();  
            


            foreach (IWeapon weapon in weapons)
            {
                WeaponsList.Items.Add(weapon);
            }
        }

        private void WeaponsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (WeaponsList.SelectedItem != null)
            {
                IWeapon selectedWeapon = (IWeapon)WeaponsList.SelectedItem;

                PurchaseWeapon(Form1.h, selectedWeapon);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите оружие для покупки.");
            }
        }
    }
}
