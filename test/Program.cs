/*
 * Project: Dad Joke Fetcher
 * Description: This program fetches a random dad joke from the icanhazdadjoke API,
 *              deserializes the JSON response using Newtonsoft.Json, and prints
 *              the joke ID and text to the console.
 *
 * Author: Saeed Soukiah
 * Date: 7/23/3035
 *
 * Key Features:
 *  - Uses HttpWebRequest to call the API with "Accept: application/json".
 *  - Reads the JSON response stream and converts it into a string.
 *  - Deserializes the JSON into a Rootobject model using JsonConvert.
 *  - Outputs the joke ID and joke text via Console.WriteLine.
 *
 * Example Output:
 *  Joke ID: R7UfaahVfFd
 *  Joke: Why did the scarecrow win an award? Because he was outstanding in his field.
 */
using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;   // Use Newtonsoft for deserialization
using test;

namespace api
{
    class Program
    {
        static string url;

        static void Main(string[] args)
        {
            url = "https://icanhazdadjoke.com/";
            var data = jsoncall(url);

            // Deserialize and store the result
            Rootobject joke = JsonConvert.DeserializeObject<Rootobject>(data);

            // Pass the deserialized object to test()
            test(joke);
        }

        static private string jsoncall(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application/json"; // Add this line
            var response = request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }

        // Accept the deserialized object instead of creating a new one
        public static void test(Rootobject data)
        {
            Console.WriteLine($"Joke ID: {data.id}");
            Console.WriteLine($"Joke: {data.joke}");
        }
    }
}