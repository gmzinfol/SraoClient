using Newtonsoft.Json;
using SraoClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SraoClient
{
    public class SraoApi
    {
        private readonly HttpClient http;
        private readonly string baseUrl;

        public SraoApi(string baseUrl)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            http = new HttpClient(clientHandler);
            this.baseUrl = baseUrl;
        }

        public async Task<Option<List<Lavoro>>> GetLavoriOggiAsync()
        {
            try
            {
                string json = await http.GetStringAsync(baseUrl + "/Srao/lavorirec");
                var lavori = JsonConvert.DeserializeObject<List<Lavoro>>(json);
                return Option<List<Lavoro>>.Some(lavori);
            }
            catch
            {
                return Option<List<Lavoro>>.None;
            }
        }

        public async Task<Option<Lavoro>> GetUltimoLavoroAsync()
        {
            try
            {
                string json = await http.GetStringAsync(baseUrl + "/Srao/ultimolavoro");
                var lavoro = JsonConvert.DeserializeObject<Lavoro>(json);
                return Option<Lavoro>.Some(lavoro);
            }
            catch
            {
                return Option<Lavoro>.None;
            }
        }

        public async Task<Option<List<Ordine>>> GetOrdiniAsync()
        {
            try
            {
                string json = await http.GetStringAsync(baseUrl + "/Srao/ordini");
                var ordini = JsonConvert.DeserializeObject<List<Ordine>>(json);
                return Option<List<Ordine>>.Some(ordini);
            }
            catch
            {
                return Option<List<Ordine>>.None;
            }
        }

        public async Task<Option<List<Ordine>>> GetOrdiniRecentiAsync()
        {
            try
            {
                string json = await http.GetStringAsync(baseUrl + "/Srao/ordinirec");
                var ordini = JsonConvert.DeserializeObject<List<Ordine>>(json);
                return Option<List<Ordine>>.Some(ordini);
            }
            catch
            {
                return Option<List<Ordine>>.None;
            }
        }

        public async Task<Option<List<Ordine>>> GetOrdiniAnnoAsync(int anno)
        {
            try
            {
                string url = $"{baseUrl}/Srao/ordini/{anno}";
                string json = await http.GetStringAsync(url);
                var ordini = JsonConvert.DeserializeObject<List<Ordine>>(json);
                return Option<List<Ordine>>.Some(ordini);
            }
            catch
            {
                return Option<List<Ordine>>.None;
            }
        }

        public async Task<Option<Ordine>> GetOrdineAsync(int anno, int n)
        {
            try
            {
                string url = $"{baseUrl}/Srao/ordini/{anno}/{n}";
                string json = await http.GetStringAsync(url);
                var ordine = JsonConvert.DeserializeObject<Ordine>(json);
                return Option<Ordine>.Some(ordine);
            }
            catch
            {
                return Option<Ordine>.None;
            }
        }
    }
}