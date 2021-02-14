using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CareMaze
{
    class lbl : Label
    {
        public void way_lbl_Mouse_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}
