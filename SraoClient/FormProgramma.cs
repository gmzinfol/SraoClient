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
    public partial class FormProgramma : Form
    {
        string Programma;
        Data DataOrdini;
        public FormProgramma(string programma, Data dataOrdini)
        {
            InitializeComponent();
            Programma = programma;
            DataOrdini = dataOrdini;
        }

        private void FormProgramma_Load(object sender, EventArgs e)
        {
            labelProgramma.Text = Programma;

            if (!DataOrdini.Ordini.Any())
                return;

            var lavori = DataOrdini.Ordini.SelectMany(x => x.Lavori)
                .Where(x => x.StatoOk && x.Programma == Programma)
                .OrderBy(x => x.OrdineCommento)
                .ToList();

            listBoxLavori.DataSource = lavori;

            var tempi = lavori.Select(x => x.DataFine - x.DataInizio);
            if (tempi.Any())
            {
                double tempoMedioTicks = tempi.Average(x => x.TotalMinutes);
                if (tempoMedioTicks > 0)
                    labelTempoMedio.Text = TimeSpan.FromMinutes(tempoMedioTicks).ToString("hh\\:mm\\:ss");
            }
        }

        private void listBoxLavori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormLavoro dialog = new FormLavoro(listBoxLavori.SelectedItem as Lavoro);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Show();
        }
    }
}
