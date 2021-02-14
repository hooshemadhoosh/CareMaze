using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace CareMaze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool is_Game_started = false;
        int high = 40*13 + 12;//number---high of each pixel---first y
        int width = 40*13 + 9;//number---width of each pixel---first x
        Stack<KeyValuePair<int, int>> coordiantes = new Stack<KeyValuePair<int, int>>(); // KeyValuePair<int,int>(x,y)
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand_start_x = rnd.Next(0, 40) * 13 + 9;
            int rand_start_y = rnd.Next(0, 40) * 13 + 12;
            coordiantes.Push(new KeyValuePair<int, int>( rand_start_x, rand_start_y ));//start point added
            //making coordinates...
            KeyValuePair<int, int> make_point(KeyValuePair<int, int> last_point)
            {
                List<KeyValuePair<int, int>> choices = new List<KeyValuePair<int, int>>(){ new KeyValuePair<int,int>(last_point.Key - 13 , last_point.Value ),
                                                                                           new KeyValuePair<int,int>(last_point.Key + 13 , last_point.Value ),
                                                                                           new KeyValuePair<int,int>(last_point.Key , last_point.Value - 13 ),
                                                                                           new KeyValuePair<int,int>(last_point.Key , last_point.Value + 13 ) };//List of choices(at max has 4 choice)
                foreach(KeyValuePair<int, int> i in choices.ToArray())//checking conditions
                {
                    //first condition
                    if (coordiantes.Contains(i))
                    {
                        choices.Remove(i);
                    }
                    //second condition
                    if (i.Key<9 || i.Value<12 || i.Key>width || i.Value > high)
                    {
                        choices.Remove(i);
                    }
                    //last condition
                    int counter = 0;
                    List<KeyValuePair<int, int>> neighbors = new List<KeyValuePair<int, int>>(){new KeyValuePair<int, int>( i.Key - 13, i.Value ),
                                                                                                new KeyValuePair<int, int>( i.Key + 13, i.Value ),
                                                                                                new KeyValuePair<int, int>( i.Key, i.Value - 13 ),
                                                                                                new KeyValuePair<int, int>( i.Key, i.Value + 13 ) };
                    for(int j = 0; j < 4; j++)
                    {
                        if (coordiantes.Contains(neighbors[j]))
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
            while ( (make_point(coordiantes.Peek())).ToString() != (new KeyValuePair<int, int>(-1,-1)).ToString())
            {
                coordiantes.Push(make_point(coordiantes.Peek()));
            }
            int rand_end_x = coordiantes.Peek().Key;
            int rand_end_y = coordiantes.Peek().Value;
            //colorize points...
            for (int x=9;x <=width; x += 13)
            {
                for(int y=12;y<=high; y += 13)
                {
                    lbl lbl_point = new lbl();
                    lbl_point.Location = new Point(x,y);
                    lbl_point.Size = new Size(13, 13);
                    lbl_point.BackColor = Color.White;
                    lbl_point.BorderStyle = BorderStyle.FixedSingle;
                    if (coordiantes.Contains(new KeyValuePair<int, int>(x,y)))
                    {
                        lbl_point.BackColor = Color.DeepSkyBlue;
                        lbl_point.BorderStyle = BorderStyle.None;
                        lbl_point.MouseEnter += new EventHandler(lbl_point.way_lbl_Mouse_Enter);

                    }
                    if (rand_start_x == x && rand_start_y == y)
                    {
                        lbl_point.BackColor = Color.Green;
                        lbl_point.BorderStyle = BorderStyle.None;
                        lbl_point.Cursor = Cursors.Hand;
                        lbl_point.Click += new EventHandler(start_lbl_Click);
                    }
                    if (rand_end_x == x && rand_end_y == y)
                    {
                        lbl_point.BackColor = Color.Red;
                        lbl_point.BorderStyle = BorderStyle.None;
                    }
                    this.Controls.Add(lbl_point);
                }
            }
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void start_lbl_Click(object sender, EventArgs e)
        {
            is_Game_started = true;
            MessageBox.Show("Game started!");
        }
        private void timer_Tick(object sender, EventArgs e)
        {

        }
        private void end_lbl_Mouse_Enter(object sender,EventArgs e)
        {
        }
    }
}