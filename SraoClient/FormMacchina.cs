using SraoClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SraoClient
{
    public partial class FormMacchina : Form
    {
        private readonly int macchina;
        private readonly Data data;

        public FormMacchina(int macchina, Data data)
        {
            InitializeComponent();
            this.macchina = macchina;
            this.data = data;
        }

        private void FormMacchina_Load(object sender, EventArgs e)
        {
            if (data is null)
                return;

            if (!data.Ordini.Any())
                return;

            var lavori = data.Ordini
                .SelectMany(x => x.Lavori)
                .Where(x => x.StatoOk && x.Macchina == macchina)
                .OrderByDescending(x => x.DataFine)
                .ToList();

            listBoxLavori.Sorted = false;
            listBoxLavori.Items.Clear();
            listBoxLavori.DataSource = lavori;

            labelMacchina.Text = macchina.ToString();
            labelTempoMedio.Text = Utils.Average(lavori);
            labelNumeroLavori.Text = lavori.Count.ToString();
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
