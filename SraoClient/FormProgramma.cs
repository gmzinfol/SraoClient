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
        private readonly string programma;
        private readonly Data data;

        public FormProgramma(string programma, Data data)
        {
            InitializeComponent();
            this.programma = programma;
            this.data = data;
        }

        private void FormProgramma_Load(object sender, EventArgs e)
        {
            if (data is null)
                return;

            labelProgramma.Text = programma;

            if (!data.Ordini.Any())
                return;

            var lavori = data.Ordini.SelectMany(x => x.Lavori)
                .Where(x => x.StatoOk && x.Programma == programma)
                .OrderByDescending(x => x.DataFine)
                .ToList();

            listBoxLavori.Sorted = false;
            listBoxLavori.Items.Clear();
            listBoxLavori.DataSource = lavori;

            labelTempoMedio.Text = Utils.Average(lavori);
        }

        private void listBoxLavori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormLavoro dialog = new FormLavoro(listBoxLavori.SelectedItem as Lavoro);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Show();
        }

        private void listBoxLavori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
