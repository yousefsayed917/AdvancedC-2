using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperchars(string name)
        {
            int count = 0;
            if (name != null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]))
                        count++;
                }
            }
            return count;
        }
        public static int GetCountOfLowerchars(string name)
        {
            int count = 0;
            if (name != null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLower(name[i]))
                        count++;
                }
            }
            return count;
        }
    }
}
