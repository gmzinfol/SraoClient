using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using SraoClient.Models;

namespace SraoClient
{
    public class Srao
    {
        private readonly HttpClient http;
        private readonly string url;

        public Srao(string url)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            http = new HttpClient(clientHandler);
            this.url = url;
        }

        public async Task<List<Ordine>> GetOrdiniAsync()
        {
            Console.WriteLine(url + "/Srao/ordini");
            string json = await http.GetStringAsync(url + "/Srao/ordini");
            var ordini = JsonConvert.DeserializeObject<List<Ordine>>(json);
            return ordini;
        }

        public async Task<List<Ordine>> GetOrdiniAnnoAsync()
        {
            string json = await http.GetStringAsync(url + "/Srao/ordinirec");
            var ordini = JsonConvert.DeserializeObject<List<Ordine>>(json);
            return ordini;
        }
    }
}
