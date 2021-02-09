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
            for(int x=9;x <=width; x += 13)
            {
                for(int y=12;y<=high; y += 13)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(x,y);
                    lbl.Size = new Size(13, 13);
                    lbl.BackColor = Color.Green;
                    lbl.ForeColor = Color.Brown;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(lbl);
                }
            }
        }
    }
}
