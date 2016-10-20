/*
 * App: Character Generator
 * Author: Lucas Schoenardie
 * Created on: 20/10/2016
 * Description: Generates a D&D character with random stats and random name;
 */

using COMP1004_F2016_Mid_Term_Exam_2003221971.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_2003221971
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();

            RacePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            if(RacePictureBox.Image == null)
            {
                this.RacePictureBox.Image = (Image)Resources.ResourceManager.GetObject("HumanRadioButton");
            }
        }

        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {
            // Set Race property from character class as "Human"
            if (Program.character.Race == null)
            {
                Program.character.Race = "Human";
            }
            // loop through radiobuttons and check the one that matches the value of the Race property of character class
            var radioButtons = RaceGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Name.Equals(Program.character.Race + "RadioButton"))
                {
                    rb.Checked = true;
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
            Program.character.Race = this._selectedRace;

            string imageString = selectedRace.Name;
            this.RacePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
           
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            GenerateNameForm generateNameForm = new GenerateNameForm();
            generateNameForm.previousForm = this;

            generateNameForm.Show();
            this.Hide();
        }

        
    }
}
