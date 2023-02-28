using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat
    {
        public static int ShininessLevel = 8;

        public string ShininessDescription = GetShininessDescription();

        static string GetShininessDescription()
        {
            switch (ShininessLevel)
            {
                case (< 2):
                    return "dull";
                case (< 5):
                    return "noticeable";
                case (< 9):
                    return "bright";
                case (> 9):
                    return "blinding";
                default:
                    return "ERROR";
            }
        }
    }
}