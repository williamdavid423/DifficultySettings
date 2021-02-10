using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
         String heroName;
        String difficultyLevel;
        public Form1()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
          
            difficultyLevel = "easy";

        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            difficultyLevel = "medium";

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
           
            heroName = heroNameInput.Text;

          
           


            outputLabel.Text = $"Welcome {heroName}";
            outputLabel2.Text = $"A true brave Hero! Go forth and conquer the {difficultyLevel} path!";
          
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void OuputLabel2_Click(object sender, EventArgs e)
        {

        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            difficultyLevel = "hard";
        }
    }
}
