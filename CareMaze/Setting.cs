using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CareMaze
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }   
        public static int R, G, B = 0;
        Color RGB = Color.FromArgb(R, G, B);
        private void trb_R_Scroll(object sender, EventArgs e)
        {
            R = trb_R.Value;
            G = trb_G.Value;
            B = trb_B.Value;
            RGB = Color.FromArgb(R, G, B);
            lbl_test_color.BackColor = RGB;

        }
        private void trb_G_Scroll(object sender, EventArgs e)
        {
            R = trb_R.Value;
            G = trb_G.Value;
            B = trb_B.Value;
            RGB = Color.FromArgb(R, G, B);
            lbl_test_color.BackColor = RGB;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.BackColor = lbl.xmlColor_Maker(11);
            btn_save.BackColor = lbl.xmlColor_Maker(12);
        }
        private void trb_B_Scroll(object sender, EventArgs e)
        {
            R = trb_R.Value;
            G = trb_G.Value;
            B = trb_B.Value;
            RGB = Color.FromArgb(R, G, B);
            lbl_test_color.BackColor = RGB;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (radb_easy.Checked)
            {
                lbl.number_of_pixels = 26;
            }
            else if(radb_medium.Checked)
            {
                lbl.number_of_pixels = 40;
            }
            else if (radb_hard.Checked)
            {
                lbl.number_of_pixels = 50;
            }
            try
            {
                int selectedIndex = cmb_color.SelectedIndex;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("setting.xml");
                XmlNodeList Theme = xmlDoc.DocumentElement.SelectSingleNode("/root/Theme").ChildNodes;

                Theme[selectedIndex].Attributes[0].Value = RGB.R.ToString();
                Theme[selectedIndex].Attributes[1].Value = RGB.G.ToString();
                Theme[selectedIndex].Attributes[2].Value = RGB.B.ToString();
                xmlDoc.Save("setting.xml");
            }
            catch (Exception)
            {

                //MessageBox.Show("please choose an element to change at first!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
