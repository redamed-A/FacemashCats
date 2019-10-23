using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacemashModel.Enums;

namespace FacemashService
{
    public interface IEloCalculation
    {
        void CalculateELO(int playerOneRating, int playerTwoRating, GameOutcome outcome);
    }
}
