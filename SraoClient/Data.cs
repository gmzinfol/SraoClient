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
        private Srao _srao;
        public List<Ordine> Ordini;

        public Data(string host)
        {
            _srao = new Srao(host);
            Ordini = new List<Ordine>();
        }

        public void ChangeHost(string host)
        {
            _srao = new Srao(host);
            Ordini.Clear();
        }

        public async void Update()
        {
            try
            {
                Ordini = await _srao.GetOrdiniAsync();
                // Ordini = await _srao.GetOrdiniAnnoAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
