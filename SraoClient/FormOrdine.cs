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
        public Ordine Ordine;

        public FormOrdine(Ordine ordine)
        {
            InitializeComponent();
            Ordine = ordine;
        }

        private void FormOrdine_Load(object sender, EventArgs e)
        {
            if (Ordine is null)
                return;

            labelLavori.Text = Ordine.Commento;

            listBoxLavori.Sorted = false;
            listBoxLavori.Items.Clear();
            var lavori = Ordine.Lavori
                .OrderBy(x => x.Macchina)
                .ThenBy(x => x.DataInizio).ToList();
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
                this.Close();
            }
        }
    }
}
