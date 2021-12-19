using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axtarish.Extension
{
    internal static class Search
    {
        public static bool Searching(this string soz,string SearchText)
        {

             int textlenght= SearchText.Length;  
            for (int i = 0;i<soz.Length;i++)
            {
                if (i + textlenght <= soz.Length)
                {
                    if (soz.Substring(i, textlenght) == SearchText)
                    {
                        return true;
                    }
                }
            }

             return false;        
        }
    }
}
