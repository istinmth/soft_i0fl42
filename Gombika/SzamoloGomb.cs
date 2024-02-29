using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gombika
{
    internal class SzamoloGomb : Button
    {
        public int szam = 1;
        public SzamoloGomb()
        {
        Text = szam.ToString();
        MouseClick += SzamoloGomb_MouseClick;
        }
        private void SzamoloGomb_MouseClick(object sender, EventArgs e)
        {
            if (szam < 5)
            {
                Text = (szam + 1).ToString();
                szam++;
            }
            else
            {
                Text = "1";
                szam = 1;
            }
        }
    }
}