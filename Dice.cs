using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDice
{
    internal class Dice
    {

        /// <summary>
        /// Dice number
        /// </summary>
        private int diceNumber;

        /// <summary>
        /// players guess
        /// </summary>
        public int guess;

        /// <summary>
        /// Past Dice number list
        /// </summary>
        private List<int> faces;

        /// <summary>
        /// Past guesses number list
        /// </summary>
        private List<int> guesses;

        /// <summary>
        ///  Number of rolls
        /// </summary>
        private int numOfRolls;

        /// <summary>
        ///  Number of wins
        /// </summary>
        private int won;

        /// <summary>
        ///  Number of losses
        /// </summary>
        private int lost;

        /// <summary>
        /// instantiates Random
        /// </summary>
        Random rand = new Random();

        public Dice()
        {
            faces = new List<int>();
            guesses = new List<int>();
            numOfRolls = 0;
            won = 0;
            lost = 0;
            diceNumber = 1;
        }

        /// <summary>
        /// instantiates Random
        /// </summary>
        public void rest()
        {
            faces = new List<int>();
            guesses = new List<int>();
            numOfRolls = 0;
            won = 0;
            lost = 0;
            diceNumber = 1;
        }


        /// <summary>
        /// get random
        /// </summary>
        /// <returns> New Dice Number</returns>
        public int Roll(int guess)
        {
            numOfRolls++;
            diceNumber = rand.Next(1, 6);
            faces.Add(diceNumber);
            guesses.Add(guess);
            checkWin(guess);
            return diceNumber;
        }


        /// <summary>
        /// Get numberOfRolls
        /// </summary>
        /// <returns> New Dice Number</returns>
        public int getTimes() { return numOfRolls; }

        /// <summary>
        /// Get number of mins
        /// </summary>
        /// <returns> Num of Wins </returns>
        public int getWins() { return won; }

        /// <summary>
        /// Get Die number
        /// </summary>
        /// <returns> Dice Number</returns>
        public int getDieNum() { return diceNumber; }

        /// <summary>
        /// Get number of loses
        /// </summary>
        /// <returns> Num of loses </returns>
        public int getLoses() { return lost; }

        /// <summary>
        /// Gets frequency
        /// </summary>
        /// <returns> frequency </returns>
        public int getFrequency(int face)
        {
            int countFace = 0;
            for (int i = 0; i < faces.Count; i++)
            {
                if (faces[i] == face) { countFace++; }
            }
            return countFace;
        }

        /// <summary>
        /// Gets each percent
        /// </summary>
        /// <returns> Percent </returns>
        public double getPercent(int face)
        {
            double percent = 0;
            if (getFrequency(face) == 0)
            {
                return percent;
            }
            percent = (double)getFrequency(face) / numOfRolls;
            percent *= 100;
            return percent;
        }

        /// <summary>
        /// gets each time guessed
        /// </summary>
        /// <returns> num of guesses</returns>
        public double getGuessTimes(int face)
        {
            int countGuess = 0;
            for (int i = 0; i < guesses.Count; i++)
            {
                if (guesses[i] == face) { countGuess++; }
            }
            return countGuess;
        }

        /// <summary>
        /// check win or lose
        /// </summary>
        public void checkWin(int guess)
        {
            if (guess == diceNumber)
            {
                won++;
            }
            else { lost++; }
        }


    }
}
