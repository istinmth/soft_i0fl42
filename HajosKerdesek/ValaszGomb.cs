using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajosKerdesek
{
    internal class ValaszGomb : TextBox
    {
        public Color DisabledColor { get; set; }
        private void ValaszGomb_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        private void ValaszGomb_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        public ValaszGomb()
        {
            this.DisabledColor = Color.Black; // Default color
            BackColor = System.Drawing.Color.LightGray;
            Multiline = true;
            ReadOnly = true;
            MouseEnter += ValaszGomb_MouseEnter;
            MouseLeave += ValaszGomb_MouseLeave;
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            Cursor = System.Windows.Forms.Cursors.Hand;
            TabStop = false;
            this.SelectionLength = 0;
        }
    }
}
