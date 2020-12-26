using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore.Validation
{
    public static class InputGuard
    {
        public static T CheckNullArgument<T>(T i_Argument, string i_ArgumentName = null)
        {
            if (i_Argument == null)
            {
                throw new ArgumentNullException(i_ArgumentName);
            }

            return i_Argument;
        }

        public static string CheckNullOrEmptyArgument(string i_Argument, string i_ParamName)
        {
            if (i_Argument == null)
            {
                throw new ArgumentNullException(i_ParamName);
            }

            if (i_Argument == string.Empty)
            {
                throw new ArgumentException("String may not be empty", i_ParamName);
            }

            return i_Argument;
        }
    }
}
