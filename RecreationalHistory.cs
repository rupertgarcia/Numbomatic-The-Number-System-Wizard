using System;
using System.Collections.Generic;

namespace MyNameSpace
{
    public class RecreationalHistory
    {
        private static List<NumberGuessEntry> numberGuesses;

        public RecreationalHistory()
        {
            if (numberGuesses == null)
            {
                numberGuesses = new List<NumberGuessEntry>();
            }
        }

        public void AddNumberGuess(int number, int guesses)
        {
            NumberGuessEntry entry = new NumberGuessEntry
            {
                Number = number,
                Guesses = guesses,
                DateTime = DateTime.Now
            };

            numberGuesses.Add(entry);
        }

        public List<NumberGuessEntry> GetNumberGuesses()
        {
            return numberGuesses;
        }

        public bool IsEmpty()
        {
            return numberGuesses.Count == 0;
        }
    }

    public class NumberGuessEntry
    {
        public int Number { get; set; }
        public int Guesses { get; set; }
        public DateTime DateTime { get; set; }
    }
}
