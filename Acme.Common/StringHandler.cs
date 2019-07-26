using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public  static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each captial letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {

            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char item in source)
                {
                    
                    if (char.IsUpper(item))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += item;

                }


            }

            result = result.Trim();


            return result;

        }

      

    }
}
