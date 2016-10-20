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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }


        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;

            // Instantiate the AbilityGeneratorForm form
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();

            abilityGeneratorForm.Show();
            // Hide this form
            this.Hide();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
