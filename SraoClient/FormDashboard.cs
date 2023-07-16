using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SraoClient.Models;

namespace SraoClient
{
    public partial class FormDashboard : Form
    {
        Data DataOrdini;
        public FormDashboard(Data dataOrdini)
        {
            InitializeComponent();
            DataOrdini = dataOrdini;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            DataOrdini.Update();
            labelAggiornamento.Text = String.Format(
                "Ultimo aggiornamento avvenuto il: {0}",
                DateTime.Now);

            // Dashboard
            var lavoriSvoltiOggi = DataOrdini.Ordini
                .SelectMany(x => x.Lavori)
                .Where(x => x.DataInizio.Date == DateTime.Now.Date);
                // .Where(x => x.PezziLavorati != 0 && x.DataInizio.Date == DateTime.Now.Date);

            lblLavoriOggi.Text = lavoriSvoltiOggi.Count().ToString();

            var tempi = lavoriSvoltiOggi.Select(x => x.DataFine - x.DataInizio);
            if (tempi.Any())
            {
                double tempoMedioTicks = tempi.Average(x => x.TotalMinutes);
                if (tempoMedioTicks > 0)
                    lblTempoMedioOggi.Text = TimeSpan.FromMinutes(tempoMedioTicks).ToString();
            }

            var ordiniSvolti = lavoriSvoltiOggi.Select(x => x.OrdineCommento).Distinct();
            foreach (string ordine in ordiniSvolti)
            {
                try
                {
                    lblOrdiniOggi.Text += ordine.Split()[0];
                }
                catch
                {
                    lblOrdiniOggi.Text += ordine;
                }
                lblOrdiniOggi.Text += " ";
            }

            // Last Lavoro
            if (!DataOrdini.Ordini.Any()) 
                return;

            Lavoro last = DataOrdini.Ordini
                .SelectMany(x => x.Lavori)
                .OrderBy(x => x.DataInizio)
                .Last();

            string message;
            if (last.StatoOk)
            {
                labelNomeMacchina.ForeColor = Color.FromArgb(15, 120, 15);
                message = "Completato";
            }
            else
            {
                labelNomeMacchina.ForeColor = Color.FromArgb(175, 120, 15);
                message = "Non completato";
            }

            if (last.Stato is null)
            {
                labelNomeMacchina.Text = message;
            }
            else
            {
                labelNomeMacchina.Text = last.Stato;
            }

            labelMacchina.Text = last.Macchina.ToString();
            labelProgramma.Text = last.Programma;
            labelOrdine.Text = last.OrdineCommento.ToString();
            labelLavoro.Text = String.Format(
                "{0} di {1}",
                last.PezziLavorati.ToString(),
                (last.PezziLavorati + last.PezziRimanenti).ToString());

            DateTime temp = new DateTime();
            if (last.DataInizio != temp && last.DataFine != temp)
            {
                labelTempoImpiegato.Text = (last.DataFine - last.DataInizio).ToString();
                labelDataInizio.Text = last.DataInizio.ToString();
                labelDataFine.Text = last.DataFine.ToString();
            }
        }
    }
}
