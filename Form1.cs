namespace NGG
{
   
    public partial class Form1 : Form
    {
        private NumberGuessingGame game;
        
        public Form1()
        {
            InitializeComponent();
            game = new NumberGuessingGame();
            NewGameButton_Click(null, EventArgs.Empty);
        }

        private void level1RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void level2RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void level3RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guessTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                    textBox.Text = "";
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(guessTextBox.Text))
            {
                int guess = int.Parse(guessTextBox.Text);
                string result = game.MakeGuess(guess);
                resultLabel.Text = result;
                UpdateTriesLabel();

                if (result.Contains("Congratulations! You guessed the correct number."))
                {
                    guessTextBox.Text = "";

                    MessageBox.Show("Congratulations! You guessed the correct number.");
                    NewGameButton_Click(null, EventArgs.Empty);
                    return;  
                }

                if (game.RemainingTries == 0)
                {
                    MessageBox.Show($"Game Over! The correct number was: {game.TargetNumber}");
                    NewGameButton_Click(null, EventArgs.Empty);
                }
            }
        }

        private void UpdateTriesLabel()
        {
            triesLabel.Text = $"Tries left: {game.RemainingTries}";
        }
        private void triesLabel_Click(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {

            if (level1RadioButton.Checked)
            {
                game.StartNewGame(1);
            }
            else if (level2RadioButton.Checked)
            {
                game.StartNewGame(2);
            }
            else if (level3RadioButton.Checked)
            {
                game.StartNewGame(3);
            }
            else
            {
                MessageBox.Show("Please select a difficulty level before starting a new game.");
                return;
            }

            guessTextBox.Text = "";
            resultLabel.Text = "";
            UpdateTriesLabel();

        }
    }

    public class NumberGuessingGame
    {
        private int targetNumber;
        private int remainingTries;

        public int RemainingTries
        {
            get { return remainingTries; }
        }
        public int TargetNumber
        {
            get { return targetNumber; }
        }

        public void StartNewGame(int difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case 1:
                    remainingTries = 8;
                    break;
                case 2:
                    remainingTries = 5;
                    break;
                case 3:
                    remainingTries = 3;
                    break;
                default:
                    throw new ArgumentException("Invalid difficulty level");
            }

            Random random = new Random();
            targetNumber = random.Next(1, 101);
        }

        public string MakeGuess(int guess)
        {
            remainingTries--;

            if (guess == targetNumber)
            {
                return "Congratulations! You guessed the correct number.";
            }
            else if (guess < targetNumber)
            {
                return "Go higher.";
            }
            else
            {
                return "Go lower.";
            }
        }
    }
}
