using System;
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
            int rand_start_x = rnd.Next(0, 40)*13 + 9;
            int rand_start_y = rnd.Next(0, 40)*13 + 12;
            int rand_end_x = rnd.Next(0, 40)*13 + 9;
            int rand_end_y = rnd.Next(0, 40)*13 + 12;
            Stack <int> coordiantes = new Stack<int>();
            //making coordinates
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
