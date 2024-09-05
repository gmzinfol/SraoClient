using SraoClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SraoClient
{
    public class SraoRepository
    {
        private readonly SraoApi sraoApi;
        private Dictionary<int, List<Ordine>> ordiniAnno;

        public SraoRepository(SraoApi sraoApi)
        {
            this.sraoApi = sraoApi;
            ordiniAnno = new Dictionary<int, List<Ordine>>();
        }

        public async Task<Option<List<Ordine>>> GetOrdiniAnnoAsync(int anno)
        {
            if (anno < DateTime.Now.Year && ordiniAnno.ContainsKey(anno))
            {
                return Option<List<Ordine>>.Some(ordiniAnno[anno]);
            }

            var ordiniAnnoOption = await sraoApi.GetOrdiniAnnoAsync(anno);
            if (ordiniAnnoOption.IsSome(out var newOrdiniAnno))
            {
                ordiniAnno[anno] = newOrdiniAnno;
                return Option<List<Ordine>>.Some(ordiniAnno[anno]);
            }

            return Option<List<Ordine>>.None;
        }

        public async Task<Option<Lavoro>> GetUltimoLavoroAsync()
        {
            var ultimoLavoroOption = await sraoApi.GetUltimoLavoroAsync();
            if (ultimoLavoroOption.IsSome(out var ultimoLavoro))
            {
                return Option<Lavoro>.Some(ultimoLavoro);
            }

            return Option<Lavoro>.None;
        }

        public async Task<Option<List<Lavoro>>> GetLavoriOggiAsync()
        {
            var lavoriOggiOption = await sraoApi.GetLavoriOggiAsync();
            if (lavoriOggiOption.IsSome(out var lavoriOggi))
            {
                return Option<List<Lavoro>>.Some(lavoriOggi);
            }
            return Option<List<Lavoro>>.None;
        }
    }
}