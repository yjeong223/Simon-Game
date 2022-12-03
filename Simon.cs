using System.Media;

namespace Simon_Part_1
{
    public partial class Simon : Form
    {

        Player currentPlayer = new Player();

        List<int> gameNumList = new List<int>();
        List<int> playerNumList = new List<int>();

        int roundNum = 1;
        int numClicks = 0;
        int numTicks = 0;


        public Simon()
        {
            InitializeComponent();
        }

        //This is picking the Player class from SimonLogin form
        public Simon(Player aPlayer)
        {
            InitializeComponent();
            currentPlayer = aPlayer;
        }

        private void Simon_Load(object sender, EventArgs e)
        {
            playerNameLabel.Text = "Welcome: " + currentPlayer.FirstName + " " + currentPlayer.LastName;
            currentLevelLabel.Text = "Current Level " + (currentPlayer.Level + 1);

            //if a user is continuing a game, then show the start button as "Continue Game";
            if (currentPlayer.Level > 0)
            {
                startGameButton.Text = "Continue Game"; 
            }

            //setting the timer intervals to appropriate to the level
            timer1.Interval -= currentPlayer.Level * 300;
            timer2.Interval -= currentPlayer.Level * 300;
            timer3.Interval -= currentPlayer.Level * 300;

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

            //clearing both lists and counters
            gameNumList.Clear();
            playerNumList.Clear();
            numClicks = 0;
            numTicks = 0;
            roundNum = 1;

            //Initializing the tag of each pictureBox. 
            greenButtonPictureBox.Tag = "Green";
            redButtonPictureBox.Tag = "Red";
            blueButtonPictureBox.Tag = "Blue";
            yellowButtonPictureBox.Tag = "Yellow";

            //restarting from Level 1
            if (startGameButton.Text == "Restart from Level 1?")
            {
                currentPlayer.Level = 0;
                currentLevelLabel.Text = "Current Level " + (currentPlayer.Level + 1);
                startGameButton.Text = "";

                timer1.Interval = 1100;
                timer2.Interval = 1100;
                timer3.Interval = 1100;
            }

            //start round1Timer
            timer1.Start();
        }


        //Machine makes a pattern
        //Machine pattern: 1st button light up
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random random = new Random();

            //level 1 
            if (currentPlayer.Level == 0)
            {
                if (roundNum == 1)
                {
                    int num = random.Next(1, 5);
                    gameNumList.Add(num);
                }

                if (roundNum == 2)
                {
                    int num2 = random.Next(1, 5);
                    gameNumList.Add(num2);
                }


                if (roundNum == 3)
                {
                    int num3 = random.Next(1, 5);
                    gameNumList.Add(num3);

                }

                lightUpButton(gameNumList[0]);
                timer1.Stop();

                timer2.Start();
            }

            //level 2
            if (currentPlayer.Level == 1)
            {

                if (roundNum == 1 && numTicks == 0)
                {
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                }

                if (roundNum == 2 && numTicks == 0)
                {
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                }

                if (roundNum == 3 && numTicks == 0)
                {
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                }

                //regardless of round in LEVEL 2, light up the first 2 buttons
                if (numTicks == 0)
                {
                    lightUpButton(gameNumList[0]);
                }

                if (numTicks == 1)
                {
                    returnButtonToNormal(gameNumList[0]);
                    lightUpButton(gameNumList[1]);

                    //starting timer2 to prevent delay
                    if (roundNum >= 2)
                    {
                        timer2.Start();
                    }
                }

                if (numTicks == 2)
                {

                    returnButtonToNormal(gameNumList[1]);

                    timer1.Stop();

                }
                numTicks++;
            }

            //level 3
            if (currentPlayer.Level == 2)
            {
                if (roundNum == 1 && numTicks == 0)
                {
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                }

                if (roundNum == 2 && numTicks == 0)
                {
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                }

                if (roundNum == 3 && numTicks == 0)
                {
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                    gameNumList.Add(random.Next(1, 5));
                }

                if (numTicks == 0)
                {
                    lightUpButton(gameNumList[0]);
                }
                if (numTicks == 1)
                {
                    returnButtonToNormal(gameNumList[0]);
                    lightUpButton(gameNumList[1]);
                }
                if (numTicks == 2)
                {
                    returnButtonToNormal(gameNumList[1]);
                    lightUpButton(gameNumList[2]);

                    //starting timer2 early to reduce delay
                    if (roundNum >= 2)
                    {
                        timer2.Start();
                    }
                }
                if (numTicks == 3)
                {
                    returnButtonToNormal(gameNumList[2]);
                    timer1.Stop();
                }

                numTicks++;
            }

        }

        //Machine pattern: 2nd button light up

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            //Level 1
            if (currentPlayer.Level == 0)
            {
                returnButtonToNormal(gameNumList[0]);

                if (roundNum == 1 && currentPlayer.Level == 0)
                {
                    timer2.Stop();
                }
                if (roundNum >= 2 && roundNum <= 4 && currentPlayer.Level == 0)
                {

                    lightUpButton(gameNumList[1]);

                    timer2.Stop();

                    timer3.Start();
                }
            }


            //Level 2
            //For both round 2 & round 3, the next 2 lights will lightup
            if (currentPlayer.Level == 1)
            {
                if (numTicks == 3)
                {
                    lightUpButton(gameNumList[2]);

                }

                if (numTicks == 4)
                {
                    returnButtonToNormal(gameNumList[2]);
                    lightUpButton(gameNumList[3]);

                    //starting timer3 early to reduce delay between timers
                    if (roundNum == 3)
                    {
                        timer3.Start();
                    }

                }

                if (numTicks == 5)
                {
                    returnButtonToNormal(gameNumList[3]);
                    timer2.Stop();

                    
                }
                numTicks++;
            }

            //Level 3
            if (currentPlayer.Level == 2)
            {
                if (numTicks == 4)
                {
                    lightUpButton(gameNumList[3]);

                }
                if (numTicks == 5)
                {
                    returnButtonToNormal(gameNumList[3]);
                    lightUpButton(gameNumList[4]);
                }
                if (numTicks == 6)
                {
                    returnButtonToNormal(gameNumList[4]);
                    lightUpButton(gameNumList[5]);

                    //starting timer3 early to prevent delay
                    if (roundNum == 3)
                    {
                        timer3.Start();
                    }
                }
                if (numTicks == 7)
                {
                    returnButtonToNormal(gameNumList[5]);
                    timer2.Stop();
                }

                numTicks++;
            }
        }

        //Machine pattern: 3rd button light up
        private void timer3_Tick(object sender, EventArgs e)
        {

            //Level 1 
            if (currentPlayer.Level == 0)
            {
                returnButtonToNormal(gameNumList[1]);

                if (roundNum == 2)
                {
                    timer3.Stop();
                }
                if (roundNum >= 3)
                {
                    lightUpButton(gameNumList[2]);

                    timer3.Stop();

                    timer4.Start();
                }

            }

            //level 2
            if (currentPlayer.Level == 1)
            {
                if (numTicks == 6)
                {
                    lightUpButton(gameNumList[4]);
                }

                if (numTicks == 7)
                {
                    returnButtonToNormal(gameNumList[4]);
                    lightUpButton(gameNumList[5]);
                }

                if (numTicks == 8)
                {
                    returnButtonToNormal(gameNumList[5]);
                    timer3.Stop();
                }

                numTicks++;
            }

            //level 3
            if (currentPlayer.Level == 2)
            {
                if (numTicks == 8)
                {
                    lightUpButton(gameNumList[6]);
                }
                if (numTicks == 9)
                {
                    returnButtonToNormal(gameNumList[6]);
                    lightUpButton(gameNumList[7]);
                }
                if (numTicks == 10)
                {
                    returnButtonToNormal(gameNumList[7]);
                    lightUpButton(gameNumList[8]);
                }
                if (numTicks == 11)
                {
                    returnButtonToNormal(gameNumList[8]);
                    timer3.Stop();
                }

                numTicks++;
            }

        }

        //Machine pattern: 4th button light up
        private void timer4_Tick(object sender, EventArgs e)
        {

            returnButtonToNormal(gameNumList[2]);

            if (roundNum == 3 && currentPlayer.Level == 0)
            {
                timer4.Stop();
            }

        }

        // WAY 2 (MouseUp & MouseDown): User attempts problem
        private void ButtonPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            SoundPlayer buttonSound;

            string colorOfButton = clickedPictureBox.Tag.ToString();

            switch (colorOfButton)
            {
                case "Green":
                    buttonSound = new SoundPlayer(Properties.Resources.djSound);
                    buttonSound.Play();
                    greenButtonPictureBox.Image = Properties.Resources.GreenButtonLight;
                    playerNumList.Add(1);
                    break;

                case "Red":
                    buttonSound = new SoundPlayer(Properties.Resources.jumpingSoundEdited);
                    buttonSound.Play();
                    redButtonPictureBox.Image = Properties.Resources.RedButtonLight;
                    playerNumList.Add(2);
                    break;

                case "Blue":
                    buttonSound = new SoundPlayer(Properties.Resources.moleSound);
                    buttonSound.Play();
                    blueButtonPictureBox.Image = Properties.Resources.BlueButtonLight;
                    playerNumList.Add(3);
                    break;

                case "Yellow":
                    buttonSound = new SoundPlayer(Properties.Resources.scifiSoundEdited);
                    buttonSound.Play();
                    yellowButtonPictureBox.Image = Properties.Resources.YellowButtonLight;
                    playerNumList.Add(4);
                    break;
            }

            numClicks++;
        }

        private void ButtonPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;

            string colorOfButton = clickedPictureBox.Tag.ToString();

            switch (colorOfButton)
            {
                case "Green":
                    greenButtonPictureBox.Image = Properties.Resources.GreenButtonDark;
                    break;

                case "Red":
                    redButtonPictureBox.Image = Properties.Resources.RedButtonDark;
                    break;

                case "Blue":
                    blueButtonPictureBox.Image = Properties.Resources.BlueButtonDark;
                    break;

                case "Yellow":
                    yellowButtonPictureBox.Image = Properties.Resources.YelloButtonDark;
                    break;
            }

            bool matchesSeq = (playerNumList[numClicks - 1] == gameNumList[numClicks - 1]);

            if (matchesSeq == false)
            {
                GamerAttemptResult guessResult = new GamerAttemptResult();
                guessResult.playerAttemptLabel.Text = "Wrong! Game Over.";
                guessResult.ShowDialog();

                //changing the start button to "Restart Level #"
                startGameButton.Text = "Restart Level";

                playerNumList.Clear();
                gameNumList.Clear();
                roundNum = 1;
                numClicks = 0;
            }

            if (numClicks == gameNumList.Count && matchesSeq)
            {
                roundNum++;

                if (roundNum < 4)
                {
                    playerNumList.Clear();
                    numClicks = 0;
                    numTicks = 0;
                    timer1.Start();
                }
                else
                {

                    if (currentPlayer.Level < 2)
                    {
                        GamerAttemptResult congratsPage = new GamerAttemptResult();
                        congratsPage.playerAttemptLabel.Text = "Congratulations! Level: " + (currentPlayer.Level + 1) + " " + "Complete.";
                        congratsPage.ShowDialog();

                        //clear both lists
                        playerNumList.Clear();
                        gameNumList.Clear();

                        //reset counters
                        roundNum = 1;
                        numClicks = 0;
                        numTicks = 0;

                        //updating and displaying level
                        //note that level is updated AFTER entering the IF condition
                        currentPlayer.Level++;
                        currentLevelLabel.Text = "Current Level " + (currentPlayer.Level + 1);

                        //decreasing the timer intervals
                        timer1.Interval -= 300;
                        timer2.Interval -= 300;
                        timer3.Interval -= 300;

                        timer1.Start();
                    }
                    else
                    {
                        currentPlayer.Wins += 1; 
                        GamerAttemptResult wonGamePage = new GamerAttemptResult();
                        wonGamePage.playerAttemptLabel.Text = "You have won the game!";
                        wonGamePage.ShowDialog();

                        //clear both lists
                        playerNumList.Clear();
                        gameNumList.Clear();

                        //reset counters
                        roundNum = 1;
                        numClicks = 0;
                        numTicks = 0;

                        startGameButton.Text = "Restart from Level 1?";

                    }


                }
            }
        }

        //A method to light up button
        private void lightUpButton(int colorNum)
        {
            bool isGreenButton = (colorNum == 1);
            bool isRedButton = (colorNum == 2);
            bool isBlueButton = (colorNum == 3);
            bool isYellowButton = (colorNum == 4);
            SoundPlayer buttonSound;


            if (isGreenButton)
            {
                buttonSound = new SoundPlayer(Properties.Resources.djSound);
                buttonSound.Play();
                greenButtonPictureBox.Image = Properties.Resources.GreenButtonLight;

            }

            if (isRedButton)
            {
                buttonSound = new SoundPlayer(Properties.Resources.jumpingSoundEdited);
                buttonSound.Play();
                redButtonPictureBox.Image = Properties.Resources.RedButtonLight;
            }

            if (isBlueButton)
            {
                buttonSound = new SoundPlayer(Properties.Resources.moleSound);
                buttonSound.Play();
                blueButtonPictureBox.Image = Properties.Resources.BlueButtonLight;
            }

            if (isYellowButton)
            {
                buttonSound = new SoundPlayer(Properties.Resources.scifiSoundEdited);
                buttonSound.Play();
                yellowButtonPictureBox.Image = Properties.Resources.YellowButtonLight;
            }
        }

        //Method to return buttons to normal color
        private void returnButtonToNormal(int colorNum)
        {
            bool isGreenButton = (colorNum == 1);
            bool isRedButton = (colorNum == 2);
            bool isBlueButton = (colorNum == 3);
            bool isYellowButton = (colorNum == 4);

            if (isGreenButton)
            {
                greenButtonPictureBox.Image = Properties.Resources.GreenButtonDark;
            }

            if (isRedButton)
            {
                redButtonPictureBox.Image = Properties.Resources.RedButtonDark;
            }

            if (isBlueButton)
            {
                blueButtonPictureBox.Image = Properties.Resources.BlueButtonDark;
            }

            if (isYellowButton)
            {
                yellowButtonPictureBox.Image = Properties.Resources.YelloButtonDark;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            //a list of holds each account information
            List<string> accounts = new List<string>();

            //first retrieve all the lines in the PlayerData textfile. 
            StreamReader playerFile;
            playerFile = File.OpenText("PlayerData.txt");

            string account = "";

            while ((!playerFile.EndOfStream))
            {
                account = playerFile.ReadLine();
                accounts.Add(account);
            }
            playerFile.Close();

            //replacement of old account level with new one; 
            for (int i = 0; i<accounts.Count; i++)
            {
                if (accounts[i].Contains(currentPlayer.LoginName))
                {
                    //notice that currentPlayer.Level will depend the user current level
                    accounts[i] = currentPlayer.FirstName + "," + currentPlayer.LastName + "," + currentPlayer.LoginName
                        + "," + currentPlayer.Password + "," + currentPlayer.Level + "," + currentPlayer.Wins; 
                }
            }

            //delete and create new text file while new account
            File.Delete("PlayerData.txt");
            File.WriteAllLines("PlayerData.txt", accounts); 

            //DON'T FORGET TO CLOSE THE FORM
            this.Close();

        }
    }
}
