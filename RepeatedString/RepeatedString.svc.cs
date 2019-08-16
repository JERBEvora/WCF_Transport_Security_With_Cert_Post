using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RepeatedString
{
    public class RepeatedString : IRepeatedString
    {
        long IRepeatedString.RepeatedString(string repeatedString, long number)
        {
            long count_repeated_a = 0,  factor = number / repeatedString.Length, remainder = number % repeatedString.Length;

            for (int i = 0; i < repeatedString.Length; i++)
            {
                if (repeatedString[i] == 'a') count_repeated_a += (i < remainder) ? factor + 1 : factor;
            }
            return count_repeated_a;
        }
    }
}
