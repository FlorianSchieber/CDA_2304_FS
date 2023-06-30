using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Game421
{
    public class Game
    {
        private readonly uint MAX_ROUNDS;

        private uint roundCount;
        private int playerPoints;

        private Round currentRound;

        private Game(uint _MAX_ROUNDS, uint _roundCount, int _playerPoints,  Round _currentRound)
        {
            this.MAX_ROUNDS = _MAX_ROUNDS;
            this.roundCount = _roundCount;
            this.playerPoints = _playerPoints;
            this.currentRound = _currentRound;
        }

        public Game(uint rounds)
            : this(rounds, 0, (int)rounds * 10, new Round())
        {}

        public void Roll(List<int> diceIndexesToRoll)
        {
            this.currentRound.Roll(diceIndexesToRoll);
        }

        public bool HasFaces(List<uint> facesToCheck)
        {
            return this.currentRound.HasFaces(facesToCheck);
        }

        public List<uint> FacesToList()
        {
            return this.currentRound.FacesToList();
        }

        public bool CurrentRoundIsWon()
        {
            return this.currentRound.IsWon();
        }

        public bool CurrentRoundIsOver()
        {
            return this.currentRound.IsOver();
        }

        public bool TryNextRound()
        {
            if (this.CurrentRoundIsWon() || this.CurrentRoundIsOver())
            {
                if (this.CurrentRoundIsWon())
                {
                    this.playerPoints += 30;
                }
                else if (this.CurrentRoundIsOver())
                {
                    this.playerPoints -= 10;
                }

                this.currentRound = new Round();
                return true;
            }

            return false;
        }

        public bool PlayerHasPoints()
        {
            return this.playerPoints > 0;
        }

        public bool CompletedRounds()
        {
            return this.roundCount >= this.MAX_ROUNDS;
        }
        
        public bool IsWon()
        {
            return this.CompletedRounds() && this.PlayerHasPoints();
        }

        public bool IsOver()
        {
            return this.CompletedRounds() || !this.PlayerHasPoints();
        }

    }
}
