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
        int high = 40*13 + 12;//number---high of each pixel---first y
        int width = 40*13 + 9;//number---width of each pixel---first x
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand_start_x = rnd.Next(0, 40) * 13 + 9;
            int rand_start_y = rnd.Next(0, 40) * 13 + 12;
            Stack<KeyValuePair<int,int>> coordiantes = new Stack<KeyValuePair<int, int>>(); // KeyValuePair<int,int>(x,y)
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
                    Label lbl = new Label();
                    lbl.Location = new Point(x,y);
                    lbl.Size = new Size(13, 13);
                    lbl.BackColor = Color.White;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    if (coordiantes.Contains(new KeyValuePair<int, int>(x,y)))
                    {
                        lbl.BackColor = Color.DeepSkyBlue;
                        lbl.BorderStyle = BorderStyle.None;
                    }
                    if (rand_start_x == x && rand_start_y == y)
                    {
                        lbl.BackColor = Color.Green;
                        lbl.BorderStyle = BorderStyle.None;
                    }
                    if (rand_end_x == x && rand_end_y == y)
                    {
                        lbl.BackColor = Color.Red;
                        lbl.BorderStyle = BorderStyle.None;
                    }
                    this.Controls.Add(lbl);
                }
            }
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
