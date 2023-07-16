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
    public partial class FormLavoro : Form
    {
        public Lavoro Lavoro;
        public FormLavoro(Lavoro lavoro)
        {
            InitializeComponent();
            Lavoro = lavoro;
        }

        private void FormLavoro_Load(object sender, EventArgs e)
        {
            string message;
            if (Lavoro.StatoOk)
            {
                labelNomeMacchina.ForeColor = Color.FromArgb(15, 120, 15);
                message = "Completato";
            }
            else
            {
                labelNomeMacchina.ForeColor = Color.FromArgb(175, 120, 15);
                message = "Non completato";

            }

            if (Lavoro.Stato == null)
            {
                labelNomeMacchina.Text = message;
            }
            else
            {
                labelNomeMacchina.Text = Lavoro.Stato;
            }

            labelProgramma.Text = Lavoro.Programma;
            labelOrdine.Text = String.Format(
                "Numero ordine: {0}",
                Lavoro.OrdineCommento);
            labelLavoro.Text = String.Format(
                "{0} di {1}",
                Lavoro.PezziLavorati.ToString(),
                (Lavoro.PezziLavorati + Lavoro.PezziRimanenti).ToString());
            if (Lavoro.DataInizio != new DateTime() &&
                Lavoro.DataFine != new DateTime())
            {
                labelDataInizio.Text = Lavoro.DataInizio.ToString();
                labelDataFine.Text = Lavoro.DataFine.ToString();
                labelTempoImpiegato.Text = String.Format(
                    "Tempo Impiegato: {0}",
                    (Lavoro.DataFine - Lavoro.DataInizio).ToString());
                labelAggiornamento.Text = String.Format(
                    "Ultimo aggiornamento avvenuto il: {0}",
                    Lavoro.DataFine);
            }
        }

        private void FormLavoro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
