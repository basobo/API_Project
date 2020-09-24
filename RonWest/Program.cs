using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace RonWest
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.kanyeQuote();

            QuoteGenerator.RonQuote();
        }
    }
}
