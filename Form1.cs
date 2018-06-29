using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Calculation C2 = new Calculation();

        private void bEnter_Click(object sender, EventArgs e)
        {
           
            C2.Show();
        }
    }
}
