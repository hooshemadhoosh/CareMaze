using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CareMaze
{
    class lbl : Label
    {
        public static bool is_Game_started = false;
        public string type;
        public static List<KeyValuePair<int, int>> coordiantes = new List<KeyValuePair<int, int>>(); // KeyValuePair<int,int>(x,y)
        public void way_lbl_Mouse_Enter(object sender, EventArgs e)
        {
            if (is_Game_started)
            {
                this.BackColor = Color.Blue;
                coordiantes.Remove(new KeyValuePair<int, int>(this.Location.X, this.Location.Y));
            }
        }
        public void end_lbl_Mouse_Enter(object sender,EventArgs e)
        {
            if (coordiantes.Count==2)
            {
                MessageBox.Show("YOU WIN!","Congragulations");
            }
        }
        public void default_lbl_Mouse_Enter(object sender, EventArgs e)
        {
            if (is_Game_started)
            {
                Console.Beep();
                MessageBox.Show("YOU LOSE!");
            }
        }
    }
}
