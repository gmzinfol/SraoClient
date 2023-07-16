using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SraoClient.Models
{
    [Serializable]
    public class Lavoro
    {
        public int Id { get; set; }
        public int Macchina { get; set; }
        public int PezziLavorati { get; set; }
        public int PezziRimanenti { get; set; }
        public string Path { get; set; }
        public bool StatoOk { get; set; }
        public string Stato { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public string Programma { get; set; }
        public string OrdineCommento { get; set; }

        public override string ToString()
        {
            // return OrdineCommento + " - " +
            //     DataInizio +
            //     " (pezzo n°: " + PezziLavorati + ")";
            return "(Macchina: " + Macchina
                + ") (" + PezziLavorati
                + "° lavoro) (" + DataInizio + ")";
        }
    }
}
