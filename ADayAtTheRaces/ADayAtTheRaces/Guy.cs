using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Guy
    {
        public string BettorName; // The guy's name
        public Bet MyBet; // An instance of Bet that has his bet
        public int Cash; // How much cash he has

        // The last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton; // My RadioButton
        public Label MyLabel; // My Label

        public void UpdateLabels()
        {
            // Set my label to my bet's description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
            MyRadioButton.Text = BettorName + " has " + Cash + " bucks";

            if (MyBet != null)
                MyLabel.Text = MyBet.GetDescription();
        }

        public void ClearBet()
        {
            // Rest my bet so it's zero
            if (MyBet!=null)
            {
                MyBet.Amount = 0;
                MyBet.Dog = null;
            }
        }

        public bool PlaceBet(int BetAmount, Greyhound DogToWin)
        {
            // Place a net bet and store it in my bet field
            // Return true if the guy had enough to bet
            if (Cash < BetAmount)
                return false;
            MyBet = new Bet { Amount = BetAmount, Dog = DogToWin, Bettor = this };
            return true;
        }

        public void Collect(Greyhound Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
            if (MyBet != null)
            {
                Cash += MyBet.PayOut(Winner);
                MyBet.Amount = 0;
                MyBet.Dog = null;
            }
        }
    }
}
