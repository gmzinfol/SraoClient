using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SraoClient.Models
{
    public class Ordine
    {
        public string Commento { get; set; }

        public virtual ICollection<Lavoro> Lavori { get; set; }

        public override string ToString()
        {
            return Commento
                + " (Ultimo lavoro: " + Lavori.Last().DataFine
                + ") (" + Lavori.Count + " elementi)";
        }
    }
}