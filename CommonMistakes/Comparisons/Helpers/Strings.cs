using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons.Helpers
{
    public class Strings
    {
        public bool Method1(string val1, string val2)
        {

            if(val1 == val2)
            {
                return true;
            }
            return false;
        }

        public bool Method2(string val1, string val2)
        {
            if(val1.Equals(val2))
            {
                return true;
            }
            return false;
        }

        public bool Method3(string val1, string val2)
        {
            if (val1.Equals(val2,StringComparison.Ordinal))
            {
                return true;
            }
            return false;
        }


        public bool Method4(string val1, string val2)
        {
            if (val1.Equals(val2, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public bool Method5(string val1, string val2)
        {
            if (val1.Equals(val2, StringComparison.CurrentCulture))
            {
                return true;
            }
            return false;
        }

        public bool Method6(string val1, string val2)
        {
            if (val1.Equals(val2, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
