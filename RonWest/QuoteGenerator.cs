using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RonWest
{
    public class QuoteGenerator
    {
        public static void kanyeQuote()
        {
            var kanyeURL = "https://api.kanye.rest";
            var client = new HttpClient();
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"--------------");
            Console.WriteLine($"kanye:'{kanyeQuote}'");
            Console.WriteLine($"--------------");
        }
        public static void RonQuote ()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString();

            Console.WriteLine($"--------------");
            Console.WriteLine($"kanye:'{ronQuote}'");
            Console.WriteLine($"--------------");

        }

    }
}
