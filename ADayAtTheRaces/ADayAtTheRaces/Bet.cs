using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    public class Bet
    {
        // The amount of cash that was bet
        public int Amount;

        // Instead of the number of the dog the bet is on, 
        // change to dog so as to win double if handicapped
        public Greyhound Dog;

        // The guy who placed the bet
        public Guy Bettor;

        public string GetDescription()
        {
            // Return a string that syas who placed the bet, how much
            // cash was bet, and which dog he bet on ("Joe bets 8 on 
            // dog #4"). If the amount is zero, no bet was placed 
            // ("Joe hasn't placed a bet")
            if (Amount > 0)
            {
                return Bettor.BettorName + " bets " + Amount + " on dog #" + Dog.DogNumber;
            }
            return Bettor.BettorName + " hasn't placed a bet";
        }

        public int PayOut(Greyhound Winner)
        {
            // The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of 
            // the amount bet.

            if (Amount == 0) // the bettor hasn't placed a bet
                return 0;

            if (Winner == Dog)
            {
                if (Winner.IsHandicapped)
                {
                    return Amount*2; // won double if handicapped
                }
                else
                {
                    return Amount; // normal win
                }
            }else
            {
                return -Amount; // lost
            }
        }
    }


}
