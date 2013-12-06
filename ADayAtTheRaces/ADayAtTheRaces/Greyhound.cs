using System;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength; //How long the racetrack is
        public PictureBox MyPictureBox = null; //MyPictureBox object
        public int Location = 0; //My Location on the racetrack
        public Random Randomizer; //An instance of Random
        public bool IsHandicapped; //A dog which will run slower
        public int DogNumber;

        public bool Run()
        {
            // Move forward either 1,2,3,4 spaces at random
            int move = 1;
            if (!IsHandicapped || (IsHandicapped && Randomizer.Next(10) != 0))
            {
                move = Randomizer.Next(4) + 1;
            }

            // Update the position of my PictureBox on the form
            Location += move;
            MyPictureBox.Left = StartingPosition + Location;

            // Return if this won the race
            return Location >= RacetrackLength;
        }

        public void TakeStartingPosition()
        {
            // Reset my location to 0 and my PictureBox to starting position
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
