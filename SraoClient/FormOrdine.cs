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
    public partial class FormOrdine : Form
    {
        private readonly Ordine ordine;

        public FormOrdine(Ordine ordine)
        {
            InitializeComponent();
            this.ordine = ordine;
        }

        private void FormOrdine_Load(object sender, EventArgs e)
        {
            if (ordine is null)
                return;

            if (!ordine.Lavori.Any())
                return;

            var lavori = ordine.Lavori
                .OrderBy(x => x.Macchina)
                .ThenBy(x => x.DataInizio)
                .ToList();

            listBoxLavori.Sorted = false;
            listBoxLavori.Items.Clear();
            listBoxLavori.DataSource = lavori;

            labelLavori.Text = ordine.Commento;
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
