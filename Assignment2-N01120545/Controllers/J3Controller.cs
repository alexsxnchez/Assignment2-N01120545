using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01120545.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This function returns the total point of each player. THe player with the highest points wins.
        /// </summary>
        /// <param name="numRounds">Round Tally</param>
        /// <param name="antoniasTurn">Antonias Round</param>
        /// <param name="davidsTurn">Davids Round</param>
        /// <example>
        ///     GET : api/J3/DoubleDice/4/5/6/6/6/4/3/5/2 -> antonia 94, david 95
        /// </example>
        /// <returns>antoniasPoint and davidsPoints</returns>
        [HttpGet]
        [Route("api/J3/DoubleDice/{numRounds}/{antoniasTurn}/{DavidsTurn}")]
        public int DoubleDice(int numRounds, int antoniasTurn, int davidsTurn)
        {
            //Each player starts with 100 points.
            numRounds = turns;
            var turns = antoniasTurn.count() + davidsTurn.count();
            int davidsPoints = 100;
            int antoniasPoints = 100;
            //Loop each time the players role.
            for (int i = 1; i <= 6; i ++)
            
            //Eevry time a player loses, they are deducted the amount the apponent rolled.
            if (davidsTurn < antoniasTurn)
            {
                return davidsPoints = davidsPoints - antoniasTurn;
            }
            else if (davidsTurn > antoniasTurn)
            {
                return antoniasPoints = antoniasPoints - davidsTurn;
            }
            return 0;
        }
    }
}
