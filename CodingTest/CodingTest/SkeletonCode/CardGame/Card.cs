using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
    class Card : ICard
    {
        private string suit;
        private string value;

        // Constructor - set the suit name and value
        // @param string s (suit)
        // @param string v (value)
        public Card(string s, string v)
        {
            suit = s;
            value = v;
        }

        // return the suit name
        public string getSuit()
        {
            return suit;
        }

        // return the value of the card
        public string getValue()
        {
            return value;
        }

        // combine the suit name and value
        public string getCardName()
        {
            return value+" of "+suit;
        }
    }
}
