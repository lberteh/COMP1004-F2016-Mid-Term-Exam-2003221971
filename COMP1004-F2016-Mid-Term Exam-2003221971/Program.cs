/*
 * App: Character Generator
 * Author: Lucas Schoenardie
 * Created on: 20/10/2016
 * Description: Generates a D&D character with random stats and random name;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_2003221971
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);     
            Application.Run(new SplashForm()); // run splash form first
        }
    }
}
