using System;
using System.Collections.Generic;
using System.Text;

namespace S2_Homework
{
    class SayMyName
    {

        public static string nameToSay { get; set; } = "Mary";

        public static string NameSayer()
        {
            return "Hello " + nameToSay;
        }
    }
}
