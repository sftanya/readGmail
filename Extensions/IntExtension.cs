using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GmailTest.Extensions
{
    public static class IntExtension
    {
        public static bool IsOdd(this int i)
        {
            return i % 2 == 0;
        }
    }
}
