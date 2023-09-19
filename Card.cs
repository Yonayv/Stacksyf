using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksYF
{

    /// <summary>
    /// Card class is made
    /// Two properties are made with an automatic getter
    /// The two string data type is Number & Suit
    /// A constructor is made two params named number & suit
    /// number is assigned to Number and suit is assigned to Suit
    /// </summary>
    internal class Card
    {


        public string Number { get; }

        public string Suit { get; }

        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;   

        }


    }
}
