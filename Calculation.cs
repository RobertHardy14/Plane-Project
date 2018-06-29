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
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }


         const  double basic = 0.5;
         const double premium = 1.0;
         const double platinum = 1.5;

         const double offPrice = 1.0;
          
          
            
          enum offSeason
          {
           February,
           August,
           September,
         };
          
         enum regularSeason
        {
            March,
            April,
            May,
            October
        };

        enum Holiday
        {
            January,
            June,
            July,
            November,
            December
        };

        private void cPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cPayment.SelectedIndex == 1)
                    tabControl1.Show();

                else

                if (cPayment.SelectedIndex == 2)
                    tabControl1.Show();

            }

            catch (Exception a)
            {
                MessageBox.Show("An Error Ocurred.");
            }
        }

        private void bSubmit_MouseClick(object sender, MouseEventArgs e)
        {
           
            int numPas;
            int totPas;

           
             
            // Displaying Number of passengers into Total of passengers checkbox
            numPas = int.Parse(tNumPas.Text);
            tTotPass.Text = numPas.ToString();
            tNumPas = tTotPass;
            //------------------------------------------------------------------

            // enums declaration
            offSeason August = offSeason.August;
            offSeason February = offSeason.February;
            offSeason September = offSeason.September;
            //------------------------------------------------------------------

            


            

        }
    }
}
