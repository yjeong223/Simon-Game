using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simon_Part_1
{
    public partial class NewPlayer : Form
    {
        List<Player> playerList = new List<Player>();
        public NewPlayer()
        {
            InitializeComponent();
        }

        private void NewPlayer_Load(object sender, EventArgs e)
        {
            //Needing hole 1 of Playerlist to be initialized 
            //so that the the loginExists property has something
            //to compare the input of the 1st new account created. 
            Player aPlayer = new Player("i", "i", "i", "i", 1, 1);
            playerList.Add(aPlayer);
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            //RETRIEVAL of the lines in text file into a list. 
            StreamReader currentPlayerFile;
            currentPlayerFile = File.OpenText("PlayerData.txt");
            char[] delim = { ',' }; 

            while (!currentPlayerFile.EndOfStream)
            {
                string playerInfo = currentPlayerFile.ReadLine();

                string [] tokens = playerInfo.Split(delim);

                Player p = new Player(tokens[0], tokens[1], tokens[2],tokens[3], 
                    int.Parse(tokens[4]), int.Parse(tokens[5]));

                playerList.Add(p);

            }
            currentPlayerFile.Close();

            //USING Player cLass properties as the CHECK GATES for the creation of new FN, LN, logName, pw; 

            bool loginExists = false;
            int i = 0; 
            while (loginExists ==false && i < playerList.Count)
            {
                if (playerList[i].loginExists(logNametextBox.Text))
                {
                    loginExists = true;
                }
                i++; 
            }

            Player newPlayer = new Player();

            bool validFullName = (!(newPlayer.fNHasDigit(fNametextBox.Text) && newPlayer.lNameHasDigit(lNametextBox.Text)));
            bool validLoginName = (!(newPlayer.hasWhiteSpace(logNametextBox.Text) && loginExists)); 

            bool validPassword = (!newPlayer.isInvalidPW(passWordTextBox.Text)); 
       
           //If the CHECK GATES are passed...
            if (validFullName && validLoginName && validPassword)
            {
                StreamWriter playerFile;

                playerFile = File.AppendText("PlayerData.txt");

                playerFile.WriteLine(fNametextBox.Text + "," + lNametextBox.Text + ","
                        + logNametextBox.Text + "," + passWordTextBox.Text + "," + 0 + "," + 1);

                playerFile.Close();

                //clearing textboxes
                fNametextBox.Clear();
                lNametextBox.Clear();
                logNametextBox.Clear();
                passWordTextBox.Clear();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
