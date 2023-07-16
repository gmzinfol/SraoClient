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
    public partial class FormProgrammi : Form
    {
        Data DataOrdini;
        public FormProgrammi(Data dataOrdini)
        {
            InitializeComponent();
            DataOrdini = dataOrdini;
        }

        private void FormProgrammi_Load(object sender, EventArgs e)
        {
            DataOrdini.Update();

            if (!DataOrdini.Ordini.Any())
                return;

            var programmi = DataOrdini.Ordini.SelectMany(x => x.Lavori).Select(x => x.Programma).Distinct().ToList();
            listBoxProgrammi.Sorted = false;
            listBoxProgrammi.Items.Clear();
            listBoxProgrammi.DataSource = programmi;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            var programmi = DataOrdini.Ordini.SelectMany(x => x.Lavori).Select(x => x.Programma).Distinct().ToList();
            listBoxProgrammi.DataSource = programmi.Where(x => x.Contains(txtCerca.Text)).ToList();
        }

        private void listBoxProgrammi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormProgramma dialog = new FormProgramma(listBoxProgrammi.SelectedItem.ToString(), DataOrdini);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Show();
        }

        private void txtCerca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCerca.PerformClick();
            }
        }
    }
}
