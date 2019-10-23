using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacemashModel.Enums;

namespace FacemashService
{
    public class EloCalculation : IEloCalculation
    {
     private readonly int eloK = 32;
        public void CalculateELO(int playerOneRating, int playerTwoRating, GameOutcome outcome)
        {
            var delta = (int)(eloK * ((int)outcome - ExpectationToWin(playerOneRating, playerTwoRating)));
            playerOneRating += delta;
            playerTwoRating -= delta;
        }

        public double ExpectationToWin(int playerOneRating, int playerTwoRating)
        {
            return 1 / (1 + Math.Pow(10, (playerTwoRating - playerOneRating) / 400.0));
        }
    }
}
