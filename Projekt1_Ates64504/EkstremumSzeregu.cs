using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_Ates64504
{
    internal class EkstremumSzeregu
    {
        public static float MinSx(float[,] TWS)
        {
            float AktualneMin;
            AktualneMin = TWS[0, 1];

            for (int i = 0; i < TWS.GetLength(0); i++)
            {
                if (AktualneMin > TWS[i, 1])
                {
                    AktualneMin = TWS[i, 1];
                }
            }

            return AktualneMin;
        }

        public static float MaxSx(float[,] TWS)
        {
            float AktualneMax;
            AktualneMax = TWS[0, 1];

            for (int i = 0; i < TWS.GetLength(0); i++)
            {
                if (AktualneMax < TWS[i, 1])
                {
                    AktualneMax = TWS[i, 1];
                }
            }

            return AktualneMax;
        }
    }
}