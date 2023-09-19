using System;

namespace StacksYF
{
    internal class Program
    {
        /// <summary>
        /// Card array is made with Card objects appropriate values, & at least +7 cards
        /// A Card stack was made and startingdeck was pushed and looped through
        /// "Cards in the deck" is printed to console
        /// The stack is looped through & a new line is printed for each card, "The <Number> of <Suit>!"
        /// The number of cards in the stack is printed to console.
        /// myHand is created
        /// 3 different cards are added to myHand
        /// "Got any 8's" is printed to console.
        /// A card is added to myHand from stack by popping it
        /// The number of cards in the Stack are printed to console
        /// "Cards in the deck:" is printed to console
        /// The stack is looped through and a new line is printed for each card, "The <Number> of <Suit>!"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[]
            {

                new Card("ACE", "Spades"),
                new Card("JACK", "Clubs"),
                new Card("QUEEN", "Diamonds"),
                new Card("QUEEN", "Diamonds"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("ACE", "Diamonds")


            };
                
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            Console.WriteLine("Cards in Deck");

            foreach(Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}! ");

            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));


            Console.WriteLine("Got any 8's?");

            if(startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("Cards in Deck");

            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}! ");

            }

        }
    }
}