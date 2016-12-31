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
    public partial class SignIn : Form
    {

        public SignIn()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // capture user name
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("You must enter your name!");
            }
            else
            {
                Scrabble.Program.UserName = NameTextBox.Text;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                StartButton.DialogResult = DialogResult.OK;
            }
            else
            {
                StartButton.DialogResult = DialogResult.None;
            }
        }

    }
}
