using System;

namespace Quest
{
    public class Prize
    {
        private string _text { get; }

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer theAdventurer)
        {
            if (theAdventurer.Awesomeness <= 0)
            {
                Console.WriteLine("Sorry, you lost! No prize for you!");
            }
            else
            {
                for (int i = theAdventurer.Awesomeness; i > 0; i--)
                {
                    Console.WriteLine(_text);
                }
            }
        }
    }
}