using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SraoClient.Models;

namespace SraoClient
{
    internal class Utils
    {
        public static string Average(IEnumerable<Lavoro> lavori)
        {
            var tempi = lavori.Where(x => x.StatoOk).Select(x => x.DataFine - x.DataInizio);

            if (tempi.Any())
            {
                double tempoMedioTicks = tempi.Average(x => x.TotalMinutes);
                if (tempoMedioTicks > 0)
                    return TimeSpan.FromMinutes(tempoMedioTicks).ToString("hh\\:mm\\:ss");
            }

            return string.Empty;
        }
    }
}
