using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLibraryForGame.Dices
{
    static class DiceSet
    {
        static Dice d2 = new(2);
        static Dice d4 = new(4);
        static Dice d6 = new(6);
        static Dice d8 = new(8);
        static Dice d10 = new(10);
        static Dice d12 = new(12);
        static Dice d20 = new(20);
        static Dice d100 = new(100);

        static int rollD20WithAdvantage()
        {
            var firstRoll = d20.rollDice();
            var secondRoll = d20.rollDice();

            return (firstRoll > secondRoll ? firstRoll : secondRoll);
        }

        static int rollD20WithDisadvantage()
        {
            var firstRoll = d20.rollDice();
            var secondRoll = d20.rollDice();

            return (firstRoll < secondRoll ? firstRoll : secondRoll);
        }
    }
}
