using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Game421
{
    internal class Round
    {
        private const uint MAX_ROLL_COUNT = 3;

        private uint rollCount;

        private Die[] dice; 

        private Round(Die[] _dice, uint _rollCount)
        {
            this.rollCount = _rollCount;
            this.dice = _dice;
        }

        public Round()
            : this(
                  new Die[] {new Die(), new Die(), new Die()},
                  0
                  )
        { }

        public void Roll(List<int> diceIndexesToRoll)
        {
            foreach (int index in diceIndexesToRoll)
            {
                this.dice[index].Roll();
            }

            this.rollCount++;
        }

        public uint FaceCount(uint faceToCheck)
        {
            uint count = 0;
            
            foreach (Die dieToCheck in this.dice)
            {
                if (faceToCheck == dieToCheck.GetFaceNumber())
                {
                    count++;
                }
            }

            return count;
        }

        public bool HasFaces(List<uint> facesToCheck)
        {
            bool result = true;
            int faceIndex = 0;

            while (faceIndex < facesToCheck.Count() && result)
            {
                if (this.FaceCount(facesToCheck[faceIndex]) == 0)
                {
                    result = false;
                }

                faceIndex++;
            }

            return result;
        }

        public List<uint> FacesToList()
        {
            List<uint> result = new List<uint> {};

            for (int index = 0; index < this.dice.Count(); index++)
            {
                result.Add(this.dice[index].GetFaceNumber());
            }

            return result;
        }

        public bool IsWon()
        {
            return this.HasFaces(new List<uint> { 4, 2, 1 });
        }

        public bool IsOver()
        {
            return this.rollCount >= Round.MAX_ROLL_COUNT;
        }
    }
}
