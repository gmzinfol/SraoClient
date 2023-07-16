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
        private HttpClient _http;
        private string _url;

        public Srao(string url)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            _http = new HttpClient(clientHandler);
            _url = url;
        }

        public async Task<List<Ordine>> GetOrdiniAsync()
        {
            Console.WriteLine(_url + "/Srao/ordini");
            string json = await _http.GetStringAsync(_url + "/Srao/ordini");
            var ordini = JsonConvert.DeserializeObject<List<Ordine>>(json);
            return ordini;
        }

        public async Task<List<Ordine>> GetOrdiniAnnoAsync()
        {
            string json = await _http.GetStringAsync(_url + "/Srao/ordinirec");
            var ordini = JsonConvert.DeserializeObject<List<Ordine>>(json);
            return ordini;
        }
    }
}
