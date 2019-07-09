using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class Form2 : Form
    {
        public LoadScenes loadController = new LoadScenes();
        //Creating a counter variable so we can access different scenes throught the code easyly
        public int sceneCounter = 0;
        public Form2 sceneForm;
        //Creating a variable to store the creatures health
        public int creatureHealth;
        //Creating a variable to store the time left to defeat the monster
        public int currentTime, creaturesTimer;
        //Creating a variable to store the players health
        public int playerHealth = 3;

        public Form2()
        {
            InitializeComponent();
            //using this current form, ie. sceneForm and adjusting the form to the centre of the screen
            sceneForm = this;
            sceneForm.CenterToScreen();
        }

        public void SetupScene()
        {
            //makes the button for the game over scene false after you click it
            btnRetry.Visible = false;
            //makes the game over picture boc invisible after reinitializing
            picOverlay.Visible = false;
            //cyles through the scenes only after the monsters health reaches 0 hp
            sceneCounter++;
            //setting up the timer
            loseTimer.Stop();
            loseTimer.Enabled = false;
            loseTimer.Interval = 1000;
            //the counter starts at 0, it gets 1 added to that and runs this if statement
            if (sceneCounter == 1)
            {
                //gets the pictures for the monster and the background from the resource file
                pictureBox1.Image = Properties.Resources.Scene1;
                creatureBox.Image = Properties.Resources.Creature_1;
                //sets the creatures location each time, this way i can use 1 picture box for all the creatures
                creatureBox.Location = new Point(0, 0);
                //sets the creatures health (amount of click taken to kill it)
                creatureHealth = 5;
                //sets the time the player has to kill the creature before loosing health
                currentTime = creaturesTimer = 30;
            }
            //level 2 ; same as above
            else if (sceneCounter == 2)
            {
                pictureBox1.Image = Properties.Resources.Scene2;
                creatureBox.Image = Properties.Resources.Creature_3;
                creatureBox.Location = new Point(150, 25);
                creatureHealth = 15;
                currentTime = creaturesTimer = 25;
            }
            //level 3 ; same as above
            else if (sceneCounter == 3)
            {
                pictureBox1.Image = Properties.Resources.Scene3;
                creatureBox.Image = Properties.Resources.Creature_2;
                creatureBox.Location = new Point(150, 25);
                creatureHealth = 20;
                currentTime = creaturesTimer = 20;
            }
            //level 4 ; same as above
            else if (sceneCounter == 4)
            {
                pictureBox1.Image = Properties.Resources.Scene5;
                creatureBox.Image = Properties.Resources.Creature_5;
                creatureBox.Location = new Point(150, 25);
                creatureHealth = 25;
                currentTime = creaturesTimer = 15;
            }
            //level 5 ; same as above
            else if (sceneCounter == 5)
            {
                pictureBox1.Image = Properties.Resources.Outro;
                creatureBox.Image = Properties.Resources.Creature_4;
                creatureBox.Location = new Point(331, 183);
                creatureHealth = 50;
                currentTime = creaturesTimer = 15;
            }
            //this is once the counter reaches 6 the princess apperas on the screen
            else if (sceneCounter == 6)
            {
                //loading the pictures from the resource file
                pictureBox1.Image = Properties.Resources.Outro;
                creatureBox.Image = Properties.Resources.Princess;
                //sets the princess location on the screen at x and y co-ordinates
                creatureBox.Location = new Point(331, 183);
                currentTime = creaturesTimer = 15;
            }

            //Apply Transparency to the picture boxes
            creatureBox.BackColor = Color.Transparent;
            creatureBox.Parent = pictureBox1;
            //Apply Transparency to the labels
            lblHealth.BackColor = Color.Transparent;
            lblHealth.Parent = pictureBox1;
            lblPlayerHealth.BackColor = Color.Transparent;
            lblPlayerHealth.Parent = pictureBox1;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Parent = pictureBox1;

            //Call the 'UpdateText' function
            UpdateText();
            loseTimer.Enabled = true;
            loseTimer.Start();
            creatureBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creatureBox_Click(object sender, EventArgs e)
        {
            creatureHealth--;

            UpdateText();

            if (creatureHealth <= 0 && sceneCounter != 6)
            {
                creatureHealth = 0;
                SetupScene();
            }
        }
        //New function that updates the text according to what scene it is on.
        private void UpdateText()
        {
            //if the scene is not the 6th scene it runs the if statement
            if (sceneCounter != 6)
            {
                lblPlayerHealth.Text = "Player Health: " + (playerHealth).ToString();
                lblHealth.Text = "Creature Health: " + (creatureHealth).ToString();
                lblTimer.Text = "Timer Remaining: " + (currentTime).ToString();
            }
            //otherwise if it is scene 1-5 it executes the else statement
            else
            {
                lblPlayerHealth.Text = "";
                lblHealth.Text = "I have been trapped in this \n castle for many days now, \n you have saved me, thanks! ";
                lblTimer.Text = "";
            }
        }

        private void loseTimer_Tick(object sender, EventArgs e)
        {
            //the timer decreases by 1
            currentTime--;

            if (currentTime < 0)
                currentTime = creaturesTimer;

            if (currentTime <= 0)
            {
                playerHealth--;
                //if the players health bar hits 0 then the game is over
                if (playerHealth <= 0)
                {
                    //if player health hits 0 the function bellow will execute
                    GameOver();
                }
            }
            //runs the function again to update all the text 
            UpdateText();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            //reinitializes the players health and the scene to thir respective values
            playerHealth = 3;
            sceneCounter = 0;
            SetupScene();
        }
        //this function handles the timer and the visibility of the pictures
        public void GameOver()
        {
            //makes the retry button visible
            btnRetry.Visible = true;
            picOverlay.Visible = true;
            //stops the timer from running 
            loseTimer.Stop();        
            loseTimer.Enabled = false;
            loseTimer.Interval = 1000;
        }
    }
}
