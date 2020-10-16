using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01120545.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This function determines the depth reading of a fish from a sequence.
        /// </summary>
        /// <param name="num1">Sequence Number 1</param>
        /// <param name="num2">Sequence Number 2</param>
        /// <param name="num3">Sequence Number 3</param>
        /// <param name="num4">Sequence Number 4</param>
        /// <example>
        ///     GET : api/J2/SoundsFishy/30/10/20/20 -> No Fish
        /// </example>
        ///     GET : api/J2/SoundsFishy/1/10/12/13 -> Fish Rising
        /// <example>
        /// </example>
        /// <returns>num1, num2, num3, num4 as a message</returns>
        [HttpGet]
        [Route("api/J2/SoundsFishy/{num1}/{num2}/{num3}/{num4}")]
        public string SoundsFishy(int num1, int num2, int num3, int num4)
        {
            string msg1 = "Fish Rising";
            string msg2 = "Fish Diving";
            string msg3 = "Fish At Constant Depth";
            string msg4 = "No Fish";
            if (num1 < num2 && num2 < num3 && num3 < num4)
            {
                return msg1;
            }
            else if (num1 > num2 && num2 > num3 && num3 > num4)
            {
                return msg2;
            }
            else if (num1==num2 && num2 == num3 && num3 == num4 && num1 == num4 && num4 == num2 && num1 == num3)
            {
                return msg3;
            }
            else
                return msg4;
        }
           
    }
}
