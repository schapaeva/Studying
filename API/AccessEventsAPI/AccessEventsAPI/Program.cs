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
            LoginArgs userArgs = new LoginArgs() { apikey = "dmdfYP6kyjbGKRUG7vdY3X86ZxT2W5uP", uuid = "578d57e39fae43.78062022" };
            Console.WriteLine("User UUID: " + userArgs.uuid);
            HttpResponseMessage response = ClientPostRequest(userArgs).Result;
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

        public static async Task<HttpResponseMessage> ClientPostRequest(LoginArgs args)
        {
            string url = "https://q1secure.seattletimes.com/authorization/vendor/useraccessevents";
            
            using (HttpClient client = new HttpClient())
            {
                var content =
                    new FormUrlEncodedContent(
                        new Dictionary<string, string>
                    {
                        { "apikey", "fyKCtVDR7THYNNJXWpyevNBFGUhyYtqu" },
                        { "uuid", "578d57e39fae43.78062022" }
                    });

                var response = await client.PostAsync(url, content);

                Console.WriteLine(await response.Content.ReadAsStringAsync());

                return response;
            }
        }

    }
}
