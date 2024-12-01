using System.Diagnostics;
using System.Numerics;
using System.Security;

namespace interfaces
{




    public partial class Form1 : Form
    {
        static public Hero h = new Hero() { Weight = 200, Name = "Rob", Health = 1000, Wallet = 1000 };
        static public Enemy en = new Enemy() { Weight = 200, Name = "Bob", Health = 1000, Wallet = 1000 };
        public Form1()
        {
            InitializeComponent();

        }
        public void UpdateWeapons()
        {
            foreach (var t in h.weapons)
            {
                Lis_Items.Items.Add(t.ToString());
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            label_health.Text = h.Health.ToString();
            label_name.Text = h.Name;
            Trader t1 = new Trader();


          
            Gun gun = new Gun() { damage = 450 };




        }



        private void button1_Click(object sender, EventArgs e)
        {
            shop s = new shop();
            s.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fight s = new Fight();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           foreach(var t in h.weapons)
            {
                Lis_Items.Items.Add(t);
            }
        }
    }

    public class Subject
    {
        public int weight;
        public double price;

    }
    
    
   
   
    
    public class Enemy : Creature
    {

    }
   
}
