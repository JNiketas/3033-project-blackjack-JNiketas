//@John Niketas
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Deck
    {
        public Card[] deck { get; set; }
        public Random rand { get; set; }
        public int card { get; set; }

        public Deck()
        {

            card = 0;
            deck = new Card[52];
            rand = new Random();
  
            string[] face = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            string[] suit = { "Diamonds", "Clubs", "Spades", "Hearts" };

            for ( int i = 0; i < 52; i++)
            {
                deck[i] = new Card(face[i % 11], suit[i / 13]);
            }

        }

        public void Shuffle()
        {
            card = 0;

            for (int card1 = 0; card1 < deck.Length; card1++)
            {
                int card2 = rand.Next(52);
                Card temporarycard = deck[card1];
                deck[card1] = deck[card2];
                deck[card2] = temporarycard;
            }
            
        }

        public Card Deal()
        {
            if (card < deck.Length)
            {
                return deck[card];
            }
            else
            {
                return null;
            }
            
        }
    }
}
