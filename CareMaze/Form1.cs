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
            int[] make_pointer(int[] last_point)
            {
                List<int[]> choices = new List<int[]>(){new int[]{last_point[0]-13,last_point[1] } ,
                                    new int[]{last_point[0]+13,last_point[1] },
                                    new int[]{last_point[0],last_point[1]-13 },
                                    new int[]{last_point[0],last_point[1]+13 } };//at max has 4 choice
                for(int i = 0; i < 4; i++)
                {
                    //first condition
                    if (coordiantes.Contains(choices[i]))
                    {
                        choices.Remove(choices[i]);
                    }
                    //second condition
                    if (choices[i][0]<9 || choices[i][1]<12 || choices[i][0]>width || choices[i][1] > high)
                    {
                        choices.Remove(choices[i]);
                    }
                    //last condition
                    
                }
            }
            //colorize...
            for (int x=9;x <=width; x += 13)
            {
                for(int y=12;y<=high; y += 13)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(x,y);
                    lbl.Size = new Size(13, 13);
                    lbl.BackColor = Color.White;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    if(rand_start_x == x && rand_start_y == y)
                    {
                        lbl.BackColor = Color.LightGreen;
                    }
                    this.Controls.Add(lbl);
                }
            }
        }
    }
}
