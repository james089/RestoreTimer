using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreTimer
{

    public enum mode
    {
        work,
        rest
    }
    public enum fitAlg
    {
        linear,
        gradient
    }

    public class p
    {
        public static int warningLevel = 30;                      //Yellow level.
        public static int dyingLevel = 10;                      //when your set time runs out, your engergy should be very low. red level
    }
}
