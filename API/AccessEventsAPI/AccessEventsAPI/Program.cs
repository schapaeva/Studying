using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Handlers;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Formatting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessEventsAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string uuid = "578d57e39fae43.78062022" ;
            Console.WriteLine("User UUID: " + uuid);
            HttpResponseMessage response = ClientPostRequest(uuid).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("----------------Access Events-------------------");
                Console.WriteLine(response.ToString());
            }
            else
            {
                Console.WriteLine("Status code: " + response.StatusCode.ToString());
            }
            Console.ReadKey();
        }

        public static async Task<HttpResponseMessage> ClientPostRequest(string uuid)
        {
            string url = "https://q1secure.seattletimes.com/authorization/vendor/useraccessevents";
            
            using (HttpClient client = new HttpClient())
            {
                var content =
                    new FormUrlEncodedContent(
                        new Dictionary<string, string>
                    {
                        { "apikey", "fyKCtVDR7THYNNJXWpyevNBFGUhyYtqu" },
                        { "uuid", uuid }
                    });

                var response = await client.PostAsync(url, content);

                Console.WriteLine(await response.Content.ReadAsStringAsync());

                return response;
            }
        }

        public static string ReturnApiKey()
        {

        }

    }
}
