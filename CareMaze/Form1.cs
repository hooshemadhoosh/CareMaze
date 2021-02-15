using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
namespace CareMaze
//this Game is made by HMH group...
{
    public partial class Form1 : Form
    {
        SoundPlayer load_effect = new SoundPlayer(@"data-scroll-progress-bar-fast-chirp.wav");
        public Form1()
        {
            InitializeComponent();
        }
        static int number_of_pixels = 40;
        static int pixel_size = 13;
        int high = number_of_pixels * pixel_size + 22;//number---high of each pixel---first y
        int width = number_of_pixels * pixel_size + 9;//number---width of each pixel---first x
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand_start_x = rnd.Next(0, number_of_pixels) * pixel_size + 9;
            int rand_start_y = rnd.Next(0, number_of_pixels) * pixel_size + 22;
            lbl.coordiantes.Add(new KeyValuePair<int, int>( rand_start_x, rand_start_y ));//start point added
            //making coordinates...
            KeyValuePair<int, int> make_point(KeyValuePair<int, int> last_point)
            {
                List<KeyValuePair<int, int>> choices = new List<KeyValuePair<int, int>>(){ new KeyValuePair<int,int>(last_point.Key - pixel_size , last_point.Value ),
                                                                                           new KeyValuePair<int,int>(last_point.Key + pixel_size , last_point.Value ),
                                                                                           new KeyValuePair<int,int>(last_point.Key , last_point.Value - pixel_size ),
                                                                                           new KeyValuePair<int,int>(last_point.Key , last_point.Value + pixel_size) };//List of choices(at max has 4 choice)
                foreach(KeyValuePair<int, int> i in choices.ToArray())//checking conditions
                {
                    //first condition
                    if (lbl.coordiantes.Contains(i))
                    {
                        choices.Remove(i);
                    }
                    //second condition
                    if (i.Key<9 || i.Value<22 || i.Key>width || i.Value > high)
                    {
                        choices.Remove(i);
                    }
                    //last condition
                    int counter = 0;
                    List<KeyValuePair<int, int>> neighbors = new List<KeyValuePair<int, int>>(){new KeyValuePair<int, int>( i.Key - pixel_size, i.Value ),
                                                                                                new KeyValuePair<int, int>( i.Key + pixel_size, i.Value ),
                                                                                                new KeyValuePair<int, int>( i.Key, i.Value - pixel_size),
                                                                                                new KeyValuePair<int, int>( i.Key, i.Value + pixel_size ) };
                    for(int j = 0; j < 4; j++)
                    {
                        if (lbl.coordiantes.Contains(neighbors[j]))
                        {
                            counter += 1;
                        }
                    }
                    if (counter>1)
                    {
                        choices.Remove(i);
                    }
                }
                if (choices.Count == 0)
                {
                    return new KeyValuePair<int, int>(-1,-1);
                }
                return choices[rnd.Next(0, choices.Count - 1)];//returns a random element of choices
            }
            //adding coordinates and the last point of way
            while ( (make_point(lbl.coordiantes[lbl.coordiantes.Count-1])).ToString() != (new KeyValuePair<int, int>(-1,-1)).ToString())
            {
                lbl.coordiantes.Add(make_point(lbl.coordiantes[lbl.coordiantes.Count - 1]));
            }
            int rand_end_x = lbl.coordiantes[lbl.coordiantes.Count - 1].Key;
            int rand_end_y = lbl.coordiantes[lbl.coordiantes.Count - 1].Value;
            //colorize points...
            for (int x=9;x <=width; x += pixel_size)
            {
                for(int y=22;y<=high; y += pixel_size)
                {
                    lbl lbl_point = new lbl();
                    lbl_point.Location = new Point(x,y);
                    lbl_point.Size = new Size(pixel_size,pixel_size);
                    lbl_point.BackColor = Color.White;
                    lbl_point.BorderStyle = BorderStyle.FixedSingle;
                    lbl_point.MouseEnter += new EventHandler(lbl_point.default_lbl_Mouse_Enter);
                    if (lbl.coordiantes.Contains(new KeyValuePair<int, int>(x,y)))//deciding for way points
                    {
                        lbl_point.BackColor = Color.DeepSkyBlue;
                        lbl_point.BorderStyle = BorderStyle.None;
                        lbl_point.MouseEnter += new EventHandler(lbl_point.way_lbl_Mouse_Enter);
                        lbl_point.MouseEnter -= lbl_point.default_lbl_Mouse_Enter;

                    }
                    if (rand_start_x == x && rand_start_y == y)//deciding for start point
                    {
                        lbl_point.BackColor = Color.Green;
                        lbl_point.BorderStyle = BorderStyle.None;
                        lbl_point.Cursor = Cursors.Hand;
                        lbl_point.Click += new EventHandler(start_lbl_Click);
                        lbl_point.MouseEnter -= lbl_point.way_lbl_Mouse_Enter;
                        lbl_point.MouseEnter -= lbl_point.default_lbl_Mouse_Enter;
                    }
                    if (rand_end_x == x && rand_end_y == y)//deciding for end point
                    {
                        lbl_point.BackColor = Color.Red;
                        lbl_point.BorderStyle = BorderStyle.None;
                        lbl_point.MouseEnter -= lbl_point.way_lbl_Mouse_Enter;
                        lbl_point.MouseEnter += new EventHandler(lbl_point.end_lbl_Mouse_Enter);
                        lbl_point.MouseEnter -= lbl_point.default_lbl_Mouse_Enter;
                    }
                    this.Controls.Add(lbl_point);
                }
            }
            load_effect.Play();//plays scrolleffect
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();//resets the Game
        }
        private void start_lbl_Click(object sender, EventArgs e)
        {
            lbl.is_Game_started = true;//click
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
            if (this.Opacity == 100)
            {
                timer.Enabled = false;
                MessageBox.Show(this.Opacity.ToString());
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (lbl.is_Game_started)
            {
                lbl.Lose_effect.Play();
                MessageBox.Show("You Lose!", "Game Over");
                lbl.is_Game_started = false;
                Application.Restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Help().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}