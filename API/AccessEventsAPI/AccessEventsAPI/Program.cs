using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            clientHandler.UseDefaultCredentials = true;
            //System.Net.Http.WebRequestHandler certHandler = new WebRequestHander();


            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync(url, args).Result;
            //response.EnsureSuccessStatusCode();
            return response;            
        }


        class CertPolicy : ICertificatePolicy
        {
            public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
            {
                // You can do your own certificate checking.
                // You can obtain the error values from WinError.h.

                // Return true so that any certificate will work with this sample.
                return true;
            }
        }

    }
}
