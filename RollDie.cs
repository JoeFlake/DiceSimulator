using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulator
{
    internal class RollDie
    {
        Random rnd = new Random();
        public int[] DieRoller(int numRolls) 
        {
            // create array for roll possibilities
            int[] aRolls = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < numRolls; i++)
             {
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int sum = die1 + die2;

                aRolls[sum]++;
             }
            return aRolls;
        }
    }
}
