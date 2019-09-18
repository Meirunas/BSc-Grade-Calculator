using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Helper
    {
        public static bool CheckRequired(string p_Input, ref string p_Message, string p_FieldName)
        {
            if (string.IsNullOrEmpty(p_Input))
            {
                p_Message += "\n ---> Enter " + p_FieldName + "!";
                return false;
            }

            return true;
        }

    }
}
