using ItemsLibraryForGame.Interfaces;

namespace ItemsLibraryForGame.Dices
{
    internal class Dice : IRollable
    {
        public int diceSize { get; set; }
        private Random random;
        private DateTime date;

        internal Dice(int sizeOfDice)
        {
            diceSize = sizeOfDice;
            date = new DateTime();
            random = new Random(date.Millisecond);
        }

        public int rollDice()
        {
            return random.Next(diceSize); ;
        }
    }
}
