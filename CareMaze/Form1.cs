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
            Stack<int[]> coordiantes = new Stack<int[]>(); // int{x,y}
            coordiantes.Push(new int[]{ rand_start_x, rand_start_y });//start point added
            //making coordinates
            int[] make_point(int[] last_point)
            {
                List<int[]> choices = new List<int[]>(){new int[]{last_point[0]-13,last_point[1] },
                                                        new int[]{last_point[0]+13,last_point[1] },
                                                        new int[]{last_point[0],last_point[1]-13 },
                                                        new int[]{last_point[0],last_point[1]+13 } };//at max has 4 choice
                foreach(int[] i in choices.ToArray())
                {
                    //first condition
                    if (coordiantes.Contains(i))
                    {
                        reload_btn.Text = "Deleted!";
                        choices.Remove(i);
                    }
                    //second condition
                    if (i[0]<9 || i[1]<12 || i[0]>width || i[1] > high)
                    {
                        //reload_btn.Text = "Deleted!";
                        choices.Remove(i);
                    }
                    //last condition
                    int counter = 0;
                    List<int[]> neighbors = new List<int[]>(){new int[]{i[0]-13, i[1] } ,
                                    new int[]{i[0]+13, i[1] },
                                    new int[]{ i[0], i[1]-13 },
                                    new int[]{ i[0], i[1]+13 } };
                    for(int j = 0; j < 4; j++)
                    {
                        if (coordiantes.Contains(neighbors[j]))
                        {
                            counter += 1;
                        }
                    }
                    if (counter>1)
                    {
                        reload_btn.Text = "Deleted!";
                        choices.Remove(i);
                    }
                }
                return choices[rnd.Next(0, choices.Count - 1)];//returns a random element of choices
            }
            //adding coordinates and the last point of way
            int length_of_way = 70;
            for (int i = 1; i <=length_of_way ; i++)
            {
                coordiantes.Push(make_point(coordiantes.Peek()));
            }
            int rand_end_x = coordiantes.Peek()[0];
            int rand_end_y = coordiantes.Peek()[1];
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
                    int[][] coors = coordiantes.ToArray();
                    foreach (int[] item in coors)
                    {
                        if (item[0]==x && item[1]==y)
                        {
                            lbl.BackColor = Color.DodgerBlue;
                        }
                    }
                    if (rand_start_x == x && rand_start_y == y)
                    {
                        lbl.BackColor = Color.LightGreen;
                    }
                    if (rand_end_x == x && rand_end_y == y)
                    {
                        lbl.BackColor = Color.Red;
                    }
                    this.Controls.Add(lbl);
                }
            }
        }
    }
}
