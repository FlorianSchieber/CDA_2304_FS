using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Game421
{
    public class Die
    {
        private const uint MIN_NUMBER = 1;
        private const uint MAX_NUMBER = 6;

        private uint faceNumber;

        public Die(uint _faceNumber)
        {
            if (_faceNumber >= Die.MIN_NUMBER && _faceNumber <= Die.MAX_NUMBER)
                this.faceNumber = _faceNumber;
        }

        public void Roll()
        {
            this.faceNumber = (uint)Alea.Instance().New((int)Die.MIN_NUMBER, (int)Die.MAX_NUMBER);
        }
    }
}
