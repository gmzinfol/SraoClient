using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SraoClient.Models;

namespace SraoClient
{
    public class Data
    {
        private SraoApi srao;
        public List<Ordine> Ordini;

        public Data(string host)
        {
            srao = new SraoApi(host);
            Ordini = new List<Ordine>();
        }

        public void ChangeHost(string host)
        {
            srao = new SraoApi(host);
            Ordini.Clear();
        }

        public async void UpdateAsync()
        {
            try
            {
                Ordini = await srao.GetOrdiniAsync();
                // Ordini = await _srao.GetOrdiniAnnoAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
