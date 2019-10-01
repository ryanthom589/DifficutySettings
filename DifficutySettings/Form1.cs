using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficutySettings
{
    public partial class Form1 : Form
    {
        String heroName;
        String difficultyLevel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Easy Button
            difficultyLevel = "an easy game";
            easyButton.BackColor = Color.Lime;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //Begin Button
            heroName = heroNameInput.Text;
            label2.Text = heroName + ", you will have " + difficultyLevel;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Medium Button
            difficultyLevel = "a fair game";
            mediumButton.BackColor = Color.Orange;
            easyButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Hard Button
            difficultyLevel = "a hard game";
            hardButton.BackColor = Color.Red;
            mediumButton.BackColor = Color.Black;
            easyButton.BackColor = Color.Black;
          
        }
    }
}
