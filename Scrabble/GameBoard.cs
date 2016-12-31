using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scrabble;

namespace Scrabble
{
    public partial class GameBoard : Form
    {
        Random mRandom = new Random();

        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            NameLabel.Text = Scrabble.Program.UserName;

            // generate a collection of letter the user can pick from
            GenerateLetters();


        }

        private void SimulateGameCompleteButton_Click(object sender, EventArgs e)
        {

        }

        private void GenerateLetters()
        {
            // clear any existing letters
            AvailableLetter1TextBox.Text = "";
            AvailableLetter2TextBox.Text = "";
            AvailableLetter3TextBox.Text = "";
            AvailableLetter4TextBox.Text = "";
            AvailableLetter5TextBox.Text = "";
            AvailableLetter6TextBox.Text = "";
            AvailableLetter7TextBox.Text = "";
            AvailableLetter8TextBox.Text = "";
            AvailableLetter9TextBox.Text = "";
            AvailableLetter10TextBox.Text = "";

            // loop through all ten boxes and load random letter
            AvailableLetter1TextBox.Text = GenerateRandomLetter(true);
            AvailableLetter2TextBox.Text = GenerateRandomLetter(true);
            AvailableLetter3TextBox.Text = GenerateRandomLetter(true);
            AvailableLetter4TextBox.Text = GenerateRandomLetter(true);
            AvailableLetter5TextBox.Text = GenerateRandomLetter(true);
            AvailableLetter6TextBox.Text = GenerateRandomLetter(true);
            AvailableLetter7TextBox.Text = GenerateRandomLetter(true);
            AvailableLetter8TextBox.Text = GenerateRandomLetter(false);
            AvailableLetter9TextBox.Text = GenerateRandomLetter(false);
            AvailableLetter10TextBox.Text = GenerateRandomLetter(false);


            //for (int i = 0; i < 10; i++)
            //{

            //}


        }

        private string GenerateRandomLetter(bool DesiresConsonateFlag)
        {
            char ch;
            bool FoundDesiredTypeOfCharacter = false;

            char [] vowels = new char[6] { 'A', 'E', 'I', 'O', 'U', 'Y' };

            // loop until we get a consonate back
            while (FoundDesiredTypeOfCharacter == false)
            {
                // get a random character
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * mRandom.NextDouble() + 65)));

                // check to see if we got a vowel or a consonant

                // if we want a vowel and ch is in our vowels array
                // or if we want a consonate and the character is not in our vowels array
                if (DesiresConsonateFlag == true)
                {
                    if ( Array.IndexOf(vowels, ch) == -1  )  // if ch is in vowels[]
                    {
                        // then set the flag that we found the right kind of character
                        FoundDesiredTypeOfCharacter = true;
                        return ch.ToString();
                    }
                }
                else // DesiresConsonateFlag = false (we want a vowel)
                {
                    if (Array.IndexOf(vowels, ch) > -1)  // if ch is in vowels[]
                    {
                        // then set the flag that we found the right kind of character
                        FoundDesiredTypeOfCharacter = true;
                        return ch.ToString();
                    }

                }
            }
            throw new System.Exception("Did not loop");
        }
    }
}
