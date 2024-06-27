using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;
using System.Drawing;
namespace AssignmentDice
{
    public partial class Form1 : Form
    {
        //stores the number for dice
        private int imageNumber = 1;
        // Create random
        Random rand = new Random();
        private int randImage;
        //New object
        Dice dice = new Dice();

        public Form1()
        {
            InitializeComponent();
            printTable();
            TimeText.Text = dice.getTimes().ToString();
            WonText.Text = dice.getWins().ToString();
            LostText.Text = dice.getLoses().ToString();
            randImage = rand.Next(1, 7);
            changeImage(randImage);
        }

        
        private void RollButton_Click(object sender, EventArgs e)
        {


            bool tryAgain;

            try
            {
                ErrorMessage.Text = "";
                for (int i = 1; i < 7; i++)
                {
                    randImage = rand.Next(1, 7);
                    changeImage(randImage);
                    Thread.Sleep(200);
                }
                int guessNumber = Convert.ToInt32(guessInput.Text);
                if (guessNumber >= 1 && guessNumber <= 6)
                {
                    imageNumber = dice.Roll(guessNumber);
                }
                else
                {
                    ErrorMessage.Text = "Number is not between 1-6";
                }
                tryAgain = false;
                changeImage(imageNumber);
            }
            catch
            {
                ErrorMessage.Text = "Must be a Number";
                tryAgain = true;
            }
            if (!tryAgain)
            {

                TimeText.Text = dice.getTimes().ToString();
                WonText.Text = dice.getWins().ToString();
                LostText.Text = dice.getLoses().ToString();
                printTable();
            }
        }

        /// <summary>
        /// Prints textbox
        /// </summary>
        private void printTable()
        {
            DisplayResults.Text = "FACE    FREQUENCY    PERCENT       NUMBER OF TIMES GUESSED";
            DisplayResults.Text += Environment.NewLine;
            for (int i = 1; i < 7; i++)
            {

                DisplayResults.Text += (" " + i.ToString()).PadRight(20, ' ');
                DisplayResults.Text += (dice.getFrequency(i).ToString()).PadRight(18, ' ');
                DisplayResults.Text += (String.Format("{0:f2}", dice.getPercent(i)) + "%").PadRight(35, ' ');
                DisplayResults.Text += (dice.getGuessTimes(i).ToString());
                DisplayResults.Text += Environment.NewLine;


            }

        }

        /// <summary>
        /// changes image
        /// </summary>
        private void changeImage(int dieNum)
        {
            String stringPath = "die" + dieNum.ToString() + ".gif";
            DiceImages.Image = Image.FromFile(stringPath);
            DiceImages.Refresh();

        }
    }

}