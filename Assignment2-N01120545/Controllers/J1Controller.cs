using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01120545.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This function verifies if drivers within speed limit or over the speed limit. If they are over, they will be fined.
        /// </summary>
        /// <param name="speedLimit">Speed Limit</param>
        /// <param name="recordSpeed">Recorded Speed</param>
        /// <example>
        ///     GET api/J1/SpeedFines/40/39 -> Congratulations, you are within the speed limit!
        /// </example>
        /// <example>
        ///     GET api/J1/SpeedFines/100/131 -> You are speeding and your fine is $500
        /// </example>
        ///     GET api/J1/SpeedFines/100/120 -> You are speeding and your fine is $100
        /// <example>
        /// </example>
        /// <returns>speedLimit + recordSpeed as a message</returns>
        [HttpGet]
        [Route("api/J1/SpeedFines/{speedLimit}/{recordSpeed}")]
        public string SpeedFines(int speedLimit, int recordSpeed)
        {
            string cMsg = " Congratulations, you are within the speed limit!";
            string overMsg = "You are speeding and your fine is ";
            string enter = "Enter the speed limit: " + speedLimit;
            string enter2 = " Enter the recorded speed of the car: " + recordSpeed;

            int speed = speedLimit;
            int record = recordSpeed;

            if (record <= speed)
            {
                return enter + "," + enter2 + "," + cMsg;
            }
            else if (record <= speed + 20)
            {
                return enter + "," + enter2 + "," + overMsg + " $100";
            }
            else if (record <= speed + 30)
            {
                return enter + "," + enter2 + "," + overMsg + " $270";
            }
            else 
                return enter + "," + enter2 + "," + overMsg + " $500";
            
        }
    }
}
