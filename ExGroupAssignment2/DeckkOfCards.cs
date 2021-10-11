using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;

        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }
        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        public int Count => cards.Length;
        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>

        public int Counter()
        {
            int countNrCards = 0;
            for (int i = 0; i < MaxNrOfCards; i++)
            {
                if (cards[i] != null)
                {
                    countNrCards++;
                }
            }
            return countNrCards;
        }



        public override string ToString()
        {

            string sRet = "";

            for (int i = 0; i < Counter(); i++)
            {
                sRet += cards[i].ToString() + "\n";
            }


            return sRet;
        }
        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            var rnd = new Random(); //rnd is now a random generator - see .NET documentation
            int a;
            int b;

            PlayingCard card3;

            for (int i = 0; i < 1000; i++)
            {
                a = rnd.Next(0, 52);
                b = rnd.Next(0, 52);

                card3 = cards[a];
                cards[a] = cards[b];
                cards[b] = card3;
            }


            //YOUR CODE
            //to shuffle the deck.
            //Hint: pick two cards in the deck randomly and swap them. Do this 1000 times
        }

        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            int cardNr = 0;



            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards[cardNr] = new PlayingCard { Color = (PlayingCardColor)j, Value = (PlayingCardValue)i };
                    cardNr++;

                }
            }


            //YOUR CODE
            //to initialize a fresh deck of cards
        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {
            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            return null;
        }

        public DeckOfCards()
        {
            FreshDeck();
            //YOUR CODE
            //to write a constructor that generates a fresh deck of cards
        }




    }
}


