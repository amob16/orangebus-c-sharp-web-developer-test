using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
    class PackOfCards : IPackOfCards
    {
        // declare string arrays for values and suits of a pack of cards
        private string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        private string[] suits = { "Hearts", "Spades", "Diamonds", "Spades" };

        // Declare a collection to hold the cards (the pack)
        private Collection<ICard> pack = new Collection<ICard>();

        public int Count
        {
            // return the count of how many items are in the collection
            // ie how many cards are in the pack
            get { return pack.Count;  }
        }

        public void Create()
        {
            // iterate through array of suits
            foreach(var suit in suits)
            {
                // iterate through array of values
                foreach(var value in values)
                {
                    // Create a new card with the current suit and value
                    Card card = new Card(suit, value);
                    // Add the card to the pack
                    pack.Add(card);
                }
            }
        }
    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return pack.GetEnumerator();
        }

        public void Shuffle()
        {
            // Create a temporary pack
            Collection<ICard> tempPack = new Collection<ICard>();
            // Get the count of the pack
            int numberOfCards = pack.Count;
            // need a random number
            Random randNum = new Random();

            // loop through the temp pack until they are all added
            while(tempPack.Count < numberOfCards)
            {
                // generate a random number from the size of the pack
                int randCardIndex = randNum.Next(pack.Count);
                // add the card to the temp pack from the pack at index
                tempPack.Add(pack.ElementAt(randCardIndex));
                // remove the card from the orginal pack so that it is not reused
                pack.RemoveAt(randCardIndex);
            }

            // assign tempPack to pack
            pack = tempPack;

            
        }

        public ICard TakeCardFromTopOfPack()
        {
            // Get the first card in the collection (pack)
            var card = pack.First();
            // Remove the first card from the collection (pack)
            pack.RemoveAt(0);
            // return the card
            return card;
        }
    }
}
