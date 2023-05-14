using System;
using System.Windows.Forms;

namespace SPANZURATOARE

{
    public partial class SPANZURATOAREA : Form
    {
        private string[] wordsToGuess = { "sternocleidomastoidian", "paralelipiped", "ciucas", "paracetamol", "luceafar", "ciment", "mucegai", "ciuperca", "literalmente", "evantai", "metalica", "broccoli", "morcov", "calorifer", "rigola", "saltea", "bombastic", "dacia", "bricheta", "carrefour" };
        private string wordToGuess;
        private string wordDisplayed;
        private int numGuesses;
        private const int MAX_GUESSES = 8;
        private Random random = new Random();
        public SPANZURATOAREA()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            
            wordToGuess = wordsToGuess[random.Next(wordsToGuess.Length)];
            wordDisplayed = new string('*', wordToGuess.Length);
            numGuesses = 0;

            
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            labelWord.Text = wordDisplayed;
            labelGuesses.Text = $"Gresite: {numGuesses}/{MAX_GUESSES}";
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            
            string guess = textBoxGuess.Text.ToLower();

            
            if (string.IsNullOrEmpty(guess) || guess.Length != 1 || !char.IsLetter(guess[0]))
            {
                MessageBox.Show("Pune o singura litera pliz", "NE NE NEE");
                return;
            }

            
            bool guessCorrect = false;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guess[0])
                {
                    wordDisplayed = wordDisplayed.Remove(i, 1).Insert(i, guess);
                    guessCorrect = true;
                }
            }

            
            if (guessCorrect)
            {
                if (wordDisplayed == wordToGuess)
                {
                    MessageBox.Show("Bravo ba ", "Ai nimerit");
                    StartGame();
                }
            }
            else
            {
                numGuesses++;
                if (numGuesses >= MAX_GUESSES)
                {
                    MessageBox.Show($"Ha bozmeg prea multe incercari. Era simplu: '{wordToGuess}'.", "Dezamagitor");
                    StartGame();
                }
            }
            UpdateDisplay();

            
            textBoxGuess.Clear();
        }
    }
}
