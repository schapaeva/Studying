using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Handlers;
using System.Security.Cryptography.X509Certificates;

namespace AccessEventsAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            LoginArgs userArgs = new LoginArgs() { apikey = "dmdfYP6kyjbGKRUG7vdY3X86ZxT2W5uP", uuid = "578d57e39fae43.78062022" };
            Console.WriteLine("User UUID: " + userArgs.uuid);
            HttpResponseMessage response = ClientPostRequest(userArgs);
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

        public static HttpResponseMessage ClientPostRequest(LoginArgs args)
        {
            string url = "https://q1secure.seattletimes.com/authorization/vendor/useraccessevents";
            
            WebRequestHandler certHandler = new WebRequestHandler();
            X509Certificate cert = X509Certificate.CreateFromCertFile(@"C:\Users\schapaeva\Desktop\WORK-ST\Study\Studying\API\certificate.cer");
            certHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            certHandler.ClientCertificates.Add(cert);

            HttpClient client = new HttpClient(certHandler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync(url, args).Result;
            return response;            
        }

    }
}
