using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gombika
{
    internal class FlashingButton : Button
    {
        public FlashingButton()
        {
            MouseEnter += FlashingButton_MouseEnter;
            MouseLeave += FlashingButton_MouseLeave;
            
        }
        private void FlashingButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
        private void FlashingButton_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(10).Wait();
            BackColor = Color.Transparent;
        }
    }
}
