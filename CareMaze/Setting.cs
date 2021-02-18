using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CareMaze
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            //trb_R.BackColor = Color.Transparent;
        }

        private void cmb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmb_color.SelectedIndex;
            Object selectedItem = cmb_color.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());
        }


        private void trb_R_Scroll(object sender, EventArgs e)
        {
            int R = trb_R.Value;
            int G = trb_G.Value;
            int B = trb_B.Value;
            Color RGB = Color.FromArgb(R, G, B);
            this.BackColor = RGB;
        }
        private void trb_G_Scroll(object sender, EventArgs e)
        {
            int R = trb_R.Value;
            int G = trb_G.Value;
            int B = trb_B.Value;
            Color RGB = Color.FromArgb(R, G, B);
            this.BackColor = RGB;
        }

        private void trb_B_Scroll(object sender, EventArgs e)
        {
            int R = trb_R.Value;
            int G = trb_G.Value;
            int B = trb_B.Value;
            Color RGB = Color.FromArgb(R, G, B);
            this.BackColor = RGB;
        }

        
    }
}
