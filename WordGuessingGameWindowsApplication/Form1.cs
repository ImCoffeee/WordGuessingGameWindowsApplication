using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessingGameWindowsApplication
{
    public partial class Form1 : Form
    {
        private string guessWord = "computer";

        public Form1()
        {
            InitializeComponent();
            string hiddenWord = guessWord;
            int Index = 1;
            int length = guessWord.Length - 2;
            if(length > 0 )
            {
                hiddenWord = guessWord.Substring(0, Index) + new string('?', length) + hiddenWord.Substring(Index + length);
            }
            lblGuess.Text = hiddenWord;
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtBoxInputGuess.Text;
            if (guess.Equals(guessWord))
            {
                lblGuess.Text = guessWord;
                MessageBox.Show("Correct guess!");
            }
            else
            {
                StringBuilder mistakes = new StringBuilder();
                mistakes.Append(guess);

                listBoxWrongGuess.Items.Add(mistakes.ToString());
                MessageBox.Show("Wrong guess! \nTry again.");

            }
        }
    }
}
