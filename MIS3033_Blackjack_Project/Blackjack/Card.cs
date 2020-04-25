//@John Niketas
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Card
    {
        public string face { get; set; }
        public string suit { get; set; }

        public int value { get; set; }

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        public Card()
        {
            face = "";
            suit = "";
        }


        public override string ToString()
        {
            return $"{face} of {suit}";
        }

    }
}
