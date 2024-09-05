using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SraoClient.Models;

namespace SraoClient
{
    public partial class FormOrdini : Form
    {
        private readonly SraoRepository repository;

        public FormOrdini(SraoRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private async void FormOrdini_Load(object sender, EventArgs e)
        {
            txtAnno.Text = DateTime.Now.Year.ToString();
            await UpdateListBox();
        }

        private void listBoxOrdini_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormOrdine dialog = new FormOrdine(listBoxOrdini.SelectedItem as Ordine)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            dialog.Show();
        }

        private async void btnCerca_Click(object sender, EventArgs e)
        {
            await UpdateListBox();
        }

        private async void txtCerca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await UpdateListBox();
            }
        }

        private async void txtAnno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await UpdateListBox();
            }
        }

        private async Task UpdateListBox()
        {
            int anno = GetAnno();
            var ordiniOption = await repository.GetOrdiniAnnoAsync(anno);
            if (ordiniOption.IsSome(out var ordini))
            {
                listBoxOrdini.DataSource = ordini
                    .Where(x => x.ToString().Contains(txtCerca.Text))
                    .OrderByDescending(x => x.Lavori.LastOrDefault().DataInizio)
                    .ToList();
            }
        }

        private int GetAnno()
        {
            if (int.TryParse(txtAnno.Text, out int anno))
            {
                return anno;
            }
            else
            {
                MessageBox.Show(
                    "Attenzione! L'anno inserito non è in formato numerico",
                    "Errore nella ricerca degli ordini",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtAnno.Text = DateTime.Now.Year.ToString();
                return DateTime.Now.Year;
            }
        }
    }
}
