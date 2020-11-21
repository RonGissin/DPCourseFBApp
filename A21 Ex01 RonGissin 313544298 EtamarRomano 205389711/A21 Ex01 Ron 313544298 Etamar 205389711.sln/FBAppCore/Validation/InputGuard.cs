using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppInfra.Validation
{
    public static class InputGuard
    {
        public static T CheckNullArgument<T>(T argument, string argumentName = null)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }

            return argument;
        }

        public static string CheckNullOrEmptyArgument(string argument, string paramName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(paramName);
            }

            if (argument == string.Empty)
            {
                throw new ArgumentException("String may not be empty", paramName);
            }

            return argument;
        }

    }
}
