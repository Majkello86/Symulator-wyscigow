using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyscigow
{
   public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random myRandom;

        public bool Run()
        { 
            Location+= myRandom.Next(5);
            MyPictureBox.Left += Location;

            if (Location>= RacetrackLength)
            {
                return true;
            }
            else
            
             return false;
            
        }

        public void TakeStartingPosition()
        {

        }
    }
}
