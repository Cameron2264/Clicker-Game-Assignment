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
    public partial class Form1 : Form
    {
        public LoadScenes loadController = new LoadScenes();
        public Form1 mainMenuForm;
        public Form2 sceneForm = new Form2();

        public Form1()
        {
            InitializeComponent();
            //Shows the main menue form
            mainMenuForm = this;
            mainMenuForm.Show();
            //Makes sure the game scenes will never boot first somehow
            sceneForm.Hide();
            //Make the info picture box transparrent
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = pbxBackground;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Parent = pbxBackground;
        }

        //Main Menu
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Hides the main menu form and opens the Game 'sceneForm'
            mainMenuForm.Hide();
            sceneForm.Show();
            sceneForm.SetupScene();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exits the application once the 'Quit' button is clicked on the main menu form
            Application.Exit();
        }           
    }
}
