/*
 * App: Character Generator
 * Author: Lucas Schoenardie
 * Created on: 20/10/2016
 * Description: Generates a D&D character with random stats and random name;
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_2003221971
{
    public partial class FinalForm : Form
    {
        public GenerateNameForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
            FillTextBoxes();
        }

        // fill text boxes with corresponding data
        public void FillTextBoxes()
        {
            StrengthTextBox.Text = Program.character.Strength;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Charisma;
            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            RaceTextBox.Text = Program.character.Race;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
