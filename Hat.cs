using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat
    {
        public static int ShininessLevel { get; set; }

        public string ShininessDescription { get; }

        public Hat(int shininessLevel)
        {
            ShininessLevel = shininessLevel;
            ShininessDescription = GetShininessDescription();
        }

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