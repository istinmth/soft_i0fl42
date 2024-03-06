using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGomb
{
    internal class RandomButton: Button
    {
        Random rnd = new Random();
        public RandomButton()
        {
            this.Location = new System.Drawing.Point(rnd.Next(0, 200), rnd.Next(0, 200));
            this.Size = new System.Drawing.Size(rnd.Next(10, 100), rnd.Next(10, 100));
            this.BackColor = System.Drawing.Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
    }
}
