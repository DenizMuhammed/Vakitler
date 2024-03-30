using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiniVakitler.Enums
{
    /* @kaynaklar:
     * https://www.date-converter.com/tr/hijri-calendar/turkey/1445/
     */
    public static class HicriayUzunluklari
    {
        public static readonly int[] aylar = new int[]
        {
            29, 30, 30,   30, 29, 30,   29, 29, 30,   29, 29, 30, // 1445 ~ M.S. 2023
            29, 30, 30,   30, 29, 30,   30, 29, 29,   30, 29, 29, // 1446
            30, 29, 30,   30, 30, 29,   30, 29, 30,   29, 30, 29, // 1447
            29, 30, 29,   30, 30, 29,   30, 30, 29,   30, 30, 29, // 1448
            29, 29, 30,   29, 30, 29,   30, 30, 29,   30, 30, 29, // 1449
            30, 29, 30,   29, 29, 30,   29, 30, 29,   30, 30, 29  // 1450
        };
    }
}
