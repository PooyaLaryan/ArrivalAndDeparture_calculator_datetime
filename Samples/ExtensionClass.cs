using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    public static class ExtensionClass
    {
        public static DateTime ToDateTime(this long value)
        {
            if (value <= 0)
            {
                return DateTime.MinValue;
            }

            string text = value.ToString();
            if (text.Length == 8)
            {
                return new DateTime(int.Parse(text.Substring(0, 4)), int.Parse(text.Substring(4, 2)), int.Parse(text.Substring(6, 2)));
            }

            if (text.Length == 14)
            {
                return new DateTime(int.Parse(text.Substring(0, 4)), int.Parse(text.Substring(4, 2)), int.Parse(text.Substring(6, 2)), int.Parse(text.Substring(8, 2)), int.Parse(text.Substring(10, 2)), int.Parse(text.Substring(12, 2)));
            }

            if (text.Length == 17)
            {
                return new DateTime(int.Parse(text.Substring(0, 4)), int.Parse(text.Substring(4, 2)), int.Parse(text.Substring(6, 2)), int.Parse(text.Substring(8, 2)), int.Parse(text.Substring(10, 2)), int.Parse(text.Substring(12, 2))).AddMilliseconds(long.Parse(text.Substring(14, 3)));
            }

            throw new Exception();
        }
    }
}
