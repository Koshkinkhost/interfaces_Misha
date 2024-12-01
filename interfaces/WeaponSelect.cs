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
    public partial class WeaponSelect : Form
    {
        public WeaponSelect()
        {
            InitializeComponent();
        }

        private void WeaponSelect_Load(object sender, EventArgs e)
        {
            foreach (var t in Form1.h.weapons)
            {
                listBox1.Items.Add(t);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
