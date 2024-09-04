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
        private readonly Lavoro lavoro;

        public FormLavoro(Lavoro lavoro)
        {
            InitializeComponent();
            this.lavoro = lavoro;
        }

        private void FormLavoro_Load(object sender, EventArgs e)
        {
            if (lavoro is null)
                return;

            string message;
            if (lavoro.StatoOk)
            {
                labelNomeMacchina.ForeColor = Color.FromArgb(15, 120, 15);
                message = "Completato";
            }
            else
            {
                labelNomeMacchina.ForeColor = Color.FromArgb(175, 120, 15);
                message = "Non completato";
            }

            if (lavoro.Stato == null)
            {
                labelNomeMacchina.Text = message;
            }
            else
            {
                labelNomeMacchina.Text = lavoro.Stato;
            }

            labelMacchina.Text = lavoro.Macchina.ToString();
            labelProgramma.Text = lavoro.Programma;
            labelOrdine.Text = lavoro.OrdineCommento;
            labelLavoro.Text = String.Format(
                "{0} di {1}",
                lavoro.PezziLavorati.ToString(),
                (lavoro.PezziLavorati + lavoro.PezziRimanenti).ToString());

            DateTime temp = new DateTime();
            if (lavoro.DataInizio != temp && lavoro.DataFine != temp)
            {
                labelDataInizio.Text = lavoro.DataInizio.ToString();
                labelDataFine.Text = lavoro.DataFine.ToString();
                labelTempoImpiegato.Text = (lavoro.DataFine - lavoro.DataInizio).ToString();
                labelAggiornamento.Text = String.Format(
                    "Ultimo aggiornamento avvenuto il: {0}",
                    lavoro.DataFine);
            }
        }

        private void FormLavoro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
