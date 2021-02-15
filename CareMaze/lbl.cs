using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace CareMaze
{
    class lbl : Label
    {
        public static SoundPlayer Lose_effect = new SoundPlayer(@"Game_Over.wav");
        public static SoundPlayer win_effect = new SoundPlayer(@"level-win.wav");
        public static bool is_Game_started = false;
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
            if (coordiantes.Count==2 && is_Game_started)
            {
                win_effect.Play();
                MessageBox.Show("YOU WIN!","Congragulations");
                is_Game_started = false;
                Application.Restart();
            }
        }
        public void default_lbl_Mouse_Enter(object sender, EventArgs e)
        {
            if (is_Game_started)
            {
                Lose_effect.Play();
                MessageBox.Show("You Lose!", "Game Over");
                is_Game_started = false;
                Application.Restart();
            }
        }
    }
}
