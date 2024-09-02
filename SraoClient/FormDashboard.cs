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
        Data Data;

        public FormDashboard(Data data)
        {
            InitializeComponent();
            Data = data;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (Data is null)
                return;

            Data.Update();

            if (Data.Ordini is null)
                return;

            labelAggiornamento.Text = String.Format(
                "Ultimo aggiornamento avvenuto il: {0}",
                DateTime.Now);

            // Dashboard
            var lavoriSvoltiOggi = Data.Ordini
                .SelectMany(x => x.Lavori)
                .Where(x => x.DataInizio.Date == DateTime.Now.Date);

            lblLavoriOggi.Text = lavoriSvoltiOggi.Count().ToString();

            lblTempoMedioOggi.Text = Utils.Average(lavoriSvoltiOggi);

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
            if (!Data.Ordini.Any()) 
                return;

            Lavoro last = Data.Ordini
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
