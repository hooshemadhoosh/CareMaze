using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace CareMaze
{
    class lbl : Label
    {
        public static XmlDocument xmlDoc = new XmlDocument();
        public static SoundPlayer Lose_effect = new SoundPlayer(@"Game_Over.wav");
        public static SoundPlayer win_effect = new SoundPlayer(@"level-win.wav");
        public static int number_of_pixels{
            get
            {
                xmlDoc.Load("setting.xml");
                return int.Parse(xmlDoc.DocumentElement.SelectSingleNode("/root/Number_of_pixels").InnerText);
            }
            set
            {
                xmlDoc.Load("setting.xml");
                xmlDoc.DocumentElement.SelectSingleNode("/root/Number_of_pixels").InnerText = value.ToString();
                xmlDoc.Save("setting.xml");
            }
        }
        public static string wins
        {
            get
            {
                xmlDoc.Load("setting.xml");
                return xmlDoc.DocumentElement.SelectSingleNode("/root/win").InnerText;
            }
            set
            {
                xmlDoc.Load("setting.xml");
                xmlDoc.DocumentElement.SelectSingleNode("/root/win").InnerText = value;
                xmlDoc.Save("setting.xml");
            }
        }
        public static string loses
        {
            get
            {
                xmlDoc.Load("setting.xml");
                return xmlDoc.DocumentElement.SelectSingleNode("/root/lose").InnerText;
            }
            set
            {
                xmlDoc.Load("setting.xml");
                xmlDoc.DocumentElement.SelectSingleNode("/root/lose").InnerText = value;
                xmlDoc.Save("setting.xml");
            }
        }
        public static bool is_Game_started = false;
        public static List<KeyValuePair<int, int>> coordiantes = new List<KeyValuePair<int, int>>(); // KeyValuePair<int,int>(x,y)
        public static Color xmlColor_Maker(int index)
        {
            xmlDoc.Load("setting.xml");
            XmlNodeList Theme = xmlDoc.DocumentElement.SelectSingleNode("/root/Theme").ChildNodes;
            return Color.FromArgb(int.Parse(Theme[index].Attributes[0].Value),
                                  int.Parse(Theme[index].Attributes[1].Value),
                                  int.Parse(Theme[index].Attributes[2].Value));
        }

        public void way_lbl_Mouse_Enter(object sender, EventArgs e)
        {
            if (is_Game_started)
            {
                this.BackColor = xmlColor_Maker(3);
                coordiantes.Remove(new KeyValuePair<int, int>(this.Location.X, this.Location.Y));
            }
        }
        public void end_lbl_Mouse_Enter(object sender,EventArgs e)
        {
            if (coordiantes.Count==2 && is_Game_started)
            {
                win_effect.Play();
                MessageBox.Show("YOU WIN!","Congragulations");
                wins = (int.Parse(wins) + 1).ToString();
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
                loses = (int.Parse(loses) + 1).ToString();
                is_Game_started = false;
                Application.Restart();
            }

        }

    }

}
