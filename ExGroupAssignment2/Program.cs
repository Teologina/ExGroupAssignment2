using System;

namespace GroupAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard card1 = new PlayingCard();


            Console.WriteLine($"color of random card is {card1.Color} and value is {card1.Value}");

            //Prinout 3 random cards
            Console.WriteLine($"\n3 randomly generated cards:");
            Console.WriteLine(new PlayingCard().ToString());
            Console.WriteLine(new PlayingCard().ToString());
            Console.WriteLine(new PlayingCard().ToString());

            DeckOfCards myDeck = new DeckOfCards();
            Console.WriteLine($"\nA freshly created deck with {myDeck.Count} cards:");
            Console.WriteLine(myDeck);


            myDeck.Shuffle();
            Console.WriteLine($"\nA shuffled deck with {myDeck.Count} cards:");
            Console.WriteLine(myDeck);











            //For the Challange
            /*
            Console.WriteLine($"\nRemove three card from the top:");
            Console.WriteLine(myDeck.GetTopCard());
            Console.WriteLine(myDeck.GetTopCard());
            Console.WriteLine(myDeck.GetTopCard());

            Console.WriteLine($"\nDeck has now {myDeck.Count} cards:");
            Console.WriteLine(myDeck);
            */
        }
    }
}
