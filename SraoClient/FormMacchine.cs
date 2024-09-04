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
    public partial class FormMacchine : Form
    {
        private readonly Data data;

        public FormMacchine(Data data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void FormMacchine_Load(object sender, EventArgs e)
        {
            if (data is null)
                return;

            data.Update();

            if (!data.Ordini.Any())
                return;

            var macchine = data.Ordini
                .SelectMany(x => x.Lavori)
                .Select(x => x.Macchina)
                .Distinct()
                .ToList();

            listBoxMacchine.Sorted = false;
            listBoxMacchine.Items.Clear();
            listBoxMacchine.DataSource = macchine;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            listBoxMacchine.DataSource = data.Ordini
                .SelectMany(x => x.Lavori)
                .Select(x => x.Macchina)
                .Distinct()
                .Where(x => x.ToString().Contains(txtCerca.Text))
                .ToList();
        }

        private void txtCerca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCerca.PerformClick();
            }
        }

        private void listBoxMacchine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!int.TryParse(listBoxMacchine.SelectedItem.ToString(), out int macchina))
                return;

            FormMacchina dialog = new FormMacchina(macchina, data);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Show();
        }
    }
}
