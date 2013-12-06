using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class RacesForm : Form
    {
        Greyhound[] dogs;
        Guy[] bettors;
        Guy currentBettor;
        Random MyRandomizer;

        public RacesForm()
        {
            InitializeComponent();
            InitializeRaces();
            UpdateRacesForm();
        }

        private void InitializeRaces()
        {
            // Random object to pass to create dog
            MyRandomizer = new Random();

            // Declare Dog array and define Greyhound objects in the array
            dogs = new Greyhound[4];
            dogs[0] = new Greyhound()
            {
                MyPictureBox = dog1PictureBox,
                StartingPosition = raceTrackerPictureBox.Left,
                RacetrackLength = raceTrackerPictureBox.Width - dog1PictureBox.Width,
                DogNumber = 1,
                Randomizer = MyRandomizer
            };
            dogs[1] = new Greyhound()
            {
                MyPictureBox = dog2PictureBox,
                StartingPosition = raceTrackerPictureBox.Left,
                RacetrackLength = raceTrackerPictureBox.Width - dog2PictureBox.Width,
                DogNumber = 2, 
                Randomizer = MyRandomizer
            };

            dogs[2] = new Greyhound()
            {
                MyPictureBox = dog3PictureBox,
                StartingPosition = raceTrackerPictureBox.Left,
                RacetrackLength = raceTrackerPictureBox.Width - dog3PictureBox.Width,
                DogNumber = 3, 
                Randomizer = MyRandomizer
            };

            dogs[3] = new Greyhound()
            {
                MyPictureBox = dog4PictureBox,
                StartingPosition = raceTrackerPictureBox.Left,
                RacetrackLength = raceTrackerPictureBox.Width - dog4PictureBox.Width,
                DogNumber = 4,
                Randomizer = MyRandomizer
            };

            // Declare Bettor array and define guy objects in the array
            bettors = new Guy[3];
            bettors[0] = new Guy
                             {
                                 Cash = 50,
                                 MyBet = null,
                                 MyRadioButton = joeRadioButton,
                                 MyLabel = joeBetLabel,
                                 BettorName = "Joe"
                             };
            bettors[1] = new Guy
                             {
                                 Cash = 75,
                                 MyBet = null,
                                 MyRadioButton = bobRadioButton,
                                 MyLabel = bobBetLabel,
                                 BettorName = "Bob"
                             };
            bettors[2] = new Guy
                             {
                                 Cash = 45,
                                 MyBet = null,
                                 MyRadioButton = alRadioButton,
                                 MyLabel = alBetLabel,
                                 BettorName = "Al"
                             };

            currentBettor = bettors[0];
            minimumBetLabel.Text = "Minimum bet: " + betAmount.Minimum + " bucks";
        }

        private void UpdateRacesForm()
        {
            bettorNameLabel.Text = currentBettor.BettorName;
            for (int i = 0; i < 3; i++)
            {
                bettors[i].UpdateLabels();
            }
        }



        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
                currentBettor = bettors[0];
            UpdateRacesForm();

        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobRadioButton.Checked)
                currentBettor = bettors[1];
            UpdateRacesForm();
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alRadioButton.Checked)
                currentBettor = bettors[2];
            UpdateRacesForm();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (!currentBettor.PlaceBet((int)betAmount.Value, dogs[(int)dogNumber.Value - 1]))
            {
                MessageBox.Show(currentBettor.BettorName + " does not have enough cash to place the bet.", "Ooops. Not enough cash.");
            }
            else
            {
                currentBettor.UpdateLabels();
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            dogRunTimer.Start();
        }

        private void dogRunTimer_Tick(object sender, EventArgs e)
        {
            // Let all the dogs run and see which dog has won after this round

            bool hasWinner = false;
            // loop through each dog
            for (int i = 0; i < 4; i++)
            {
                // call the dog's run method and check if it returns true (which means won)

                if (dogs[i].Run())
                {
                    // have a winner, stop the timer and show which dog has won
                    dogRunTimer.Stop();
                    MessageBox.Show("Dog#" + dogs[i].DogNumber + " has won");
                    hasWinner = true;

                    // every bettor collect his winnings
                    for (int j = 0; j < 3; j++)
                    {
                        bettors[j].Collect(dogs[i]);
                    }
                    break;
                }
            }

            if (hasWinner)
            {
                // reset the race
                for (int i = 0; i < 4; i++)
                {
                    dogs[i].TakeStartingPosition();
                }
                for (int j = 0; j < 3; j++)
                {
                    bettors[j].ClearBet();
                    bettors[j].UpdateLabels();
                }

            }


        }

        private void dog1IsHandicapped_CheckedChanged(object sender, EventArgs e)
        {
            bool isHandicapped = dog1IsHandicapped.Checked;
            dogs[0].IsHandicapped = isHandicapped;
            if (isHandicapped)
                dog1PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.handicapdog;
            else
                dog1PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
        }

        private void dog2IsHandicapped_CheckedChanged(object sender, EventArgs e)
        {
            bool isHandicapped = dog2IsHandicapped.Checked;
            dogs[1].IsHandicapped = isHandicapped;
            if (isHandicapped)
                dog2PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.handicapdog;
            else
                dog2PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
        }

        private void dog3IsHandicapped_CheckedChanged(object sender, EventArgs e)
        {
            bool isHandicapped = dog3IsHandicapped.Checked;
            dogs[2].IsHandicapped = isHandicapped;
            if (isHandicapped)
                dog3PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.handicapdog;
            else
                dog3PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
        }

        private void dog4IsHandicapped_CheckedChanged(object sender, EventArgs e)
        {
            bool isHandicapped = dog4IsHandicapped.Checked;
            dogs[3].IsHandicapped = isHandicapped;
            if (isHandicapped)
                dog4PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.handicapdog;
            else
                dog4PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
        }
    }
}
