using System;
using System.Collections.Generic;

namespace Quest
{
    public class Robe
    {
        public List<string> Colors = new List<string>();

        public int Length = 30;

        public Robe(List<string> colors, int length)
        {
            Colors = colors;
            Length = length;
        }
    }
}