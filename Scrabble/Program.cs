using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
    static class Program
    {
        public static String UserName = "";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SignIn());


            // load new SignIn form and display
            DialogResult dr = new DialogResult();
            SignIn SignInForm = new SignIn();
            dr = SignInForm.ShowDialog();
            // did the user signal to proceed or to exit the game?
            if (dr != DialogResult.OK)
            {
                ShutDown();
            }

            // load new GameBoard form and display
            GameBoard GameBoardForm = new GameBoard();
            dr = GameBoardForm.ShowDialog();
            if (dr != DialogResult.OK)
            {
                ShutDown();
            }

            // load Scores form and display
            Scores ScoresForm = new Scores();
            dr = ScoresForm.ShowDialog();
            if (dr != DialogResult.OK)
            {
                ShutDown();
            }
            else
            {
                // how do we loop back to the GameBoard ???
            }

        }

        static void ShutDown()
        {
            System.Environment.Exit(0);
        }
    }
}
