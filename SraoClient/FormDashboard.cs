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
        private readonly SraoRepository repository;

        public FormDashboard(SraoRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private async void FormDashboard_Load(object sender, EventArgs e)
        {
            labelAggiornamento.Text = String.Format(
                "Ultimo aggiornamento avvenuto il: {0}",
                DateTime.Now);

            // Statistiche lavori svolti oggi
            var lavoriSvoltiOggiOption = await repository.GetLavoriOggiAsync();
            if (lavoriSvoltiOggiOption.IsSome(out var lavoriSvoltiOggi))
            {
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
            }

            // Statistiche ultimo lavoro
            var ultimoLavoroOption = await repository.GetUltimoLavoroAsync();
            if (ultimoLavoroOption.IsSome(out var ultimoLavoro))
            {
                string message;
                if (ultimoLavoro.StatoOk)
                {
                    labelNomeMacchina.ForeColor = Color.FromArgb(15, 120, 15);
                    message = "Completato";
                }
                else
                {
                    labelNomeMacchina.ForeColor = Color.FromArgb(175, 120, 15);
                    message = "Non completato";
                }

                if (ultimoLavoro.Stato is null)
                {
                    labelNomeMacchina.Text = message;
                }
                else
                {
                    labelNomeMacchina.Text = ultimoLavoro.Stato;
                }

                labelMacchina.Text = ultimoLavoro.Macchina.ToString();
                labelProgramma.Text = ultimoLavoro.Programma;
                labelOrdine.Text = ultimoLavoro.OrdineCommento.ToString();
                labelLavoro.Text = String.Format(
                    "{0} di {1}",
                    ultimoLavoro.PezziLavorati.ToString(),
                    (ultimoLavoro.PezziLavorati + ultimoLavoro.PezziRimanenti).ToString());

                DateTime temp = new DateTime();
                if (ultimoLavoro.DataInizio != temp && ultimoLavoro.DataFine != temp)
                {
                    labelTempoImpiegato.Text = (ultimoLavoro.DataFine - ultimoLavoro.DataInizio).ToString();
                    labelDataInizio.Text = ultimoLavoro.DataInizio.ToString();
                    labelDataFine.Text = ultimoLavoro.DataFine.ToString();
                }
            }
        }
    }
}
