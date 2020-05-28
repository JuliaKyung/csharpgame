using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextGametake2.gameclasses;

namespace TextGametake2
{
    public partial class Form1 : Form
    {
        Adventure adv;
        
        public Form1()
        {
            InitializeComponent();
            InitGame();
            StartGame();
        }

        private void InitGame()
        {
            adv = new Adventure();
            StartGame();
        }

        private void StartGame()
        {
            outputbox.Text = $"Yo you're at {adv.Player.Location.Name}. It is {adv.Player.Location.Description}\r\n";
            outputbox.AppendText($"Where Do you wanna go?\r\n");
            outputbox.AppendText($"Click N, S, E or W\r\n");
            ShowLocation();
        }

        private void Wr(String s)
        {
            outputbox.AppendText(s);
        }

        private void WrLn(String s)
        {
            Wr(s + "\r\n");
        }

        private void ShowLocation()
        {
            Wr(adv.Player.Name);
            Wr(" are currently in this location: ");
            WrLn(adv.Player.Location.Describe());
        }

        private void ShowInventory()
        {
            WrLn("Your items: " + adv.Player.Things.Describe());
        }

        private void LookBTN_Click(object sender, EventArgs e)
        {
            
            outputbox.Text = $"You are here: {adv.Player.Location.Name}\r\n";
            
        }

        private void MovePlayer(Dir direction)
        {
            outputbox.Text = adv.MovePlayerTo(direction);
        }

        private void North_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.NORTH);
        }

        private void South_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.SOUTH);
        }

        private void West_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.WEST);
        }

        private void East_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.EAST);
        }

        private void takebtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.TakeOb(objtextbox.Text));
        }

        private void dropbtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.DropOb(objtextbox.Text));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LookAt_Click(object sender, EventArgs e)
        {
            WrLn(adv.LookAtOb(objtextbox.Text));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((st = saveFileDialog1.OpenFile()) != null)
                {
                    //save to disk
                    binfmt = new BinaryFormatter();
                    binfmt.Serialize(st, adv);
                    st.Close();
                    WrLn("Saved!");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = openFileDialog1.OpenFile()) != null)
                {
                    binfmt = new BinaryFormatter();
                    adv = (Adventure)binfmt.Deserialize(st);
                    st.Close();
                }
            }
            outputbox.Clear();
            ShowLocation();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            ShowInventory();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
