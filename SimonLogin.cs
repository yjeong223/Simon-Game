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
    public partial class SimonLogin : Form
    {
        List <Player> playerList = new List <Player> ();
        public SimonLogin()
        {
            InitializeComponent();
        }

        private void SimonLogin_Load(object sender, EventArgs e)
        {

        }

        private void newPlayerButton_Click(object sender, EventArgs e)
        {
           NewPlayer newPlayer = new NewPlayer();

           newPlayer.ShowDialog();

        }

        private void cLogInbutton_Click(object sender, EventArgs e)
        {
            
            //Retrieving the information into the CLASS
            StreamReader playerFile;
            playerFile = File.OpenText("PlayerData.Txt");
            string account;

            char[] delim = { ',' }; 

            while (!playerFile.EndOfStream)
            {
                account = playerFile.ReadLine(); 

                string [] tokens = account.Split(delim);

                Player aPlayer = new Player(tokens[0], tokens[1], tokens[2], tokens[3],
                    int.Parse(tokens[4]), int.Parse(tokens[5]));

                playerList.Add(aPlayer);

            }
            playerFile.Close();

            //Make the comparison between input and playerList

            bool loginMatches = false;
            int i = 0;
            int loginMatchesIndex = 0; 

            while (loginMatches==false && i< playerList.Count)
            //foreach (Player p in playerlist)
            {
                //not case sensitive
                foreach (char c in cLogNameTextBox.Text)
                {
                    if (char.IsUpper(c))
                    {
                        char.ToLower(c);
                    }
                }

                foreach (char c in playerList[i].LoginName)
                {
                    if (char.IsUpper(c))
                    {
                        char.ToLower(c);
                    }
                }

                bool loginNameMatches = cLogNameTextBox.Text == playerList[i].LoginName;

                //case sensitive
                bool passwordMatches = cPasswordTexBox.Text == playerList[i].Password;

                if (loginNameMatches && passwordMatches)
                {
                    loginMatches = true;
                    //loginMatchesIndex remembers which index made loginMatches to be true; 
                    loginMatchesIndex = i;
                }

                i++; 
                
            }

            if (loginMatches)
            {
                Simon simonGamePage = new Simon(playerList[loginMatchesIndex]);
                simonGamePage.ShowDialog();
            }
            else
            {
                ErrorForm errorPage = new ErrorForm();
                errorPage.showErrorType("Login or password is invalid"); 
                errorPage.ShowDialog();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
