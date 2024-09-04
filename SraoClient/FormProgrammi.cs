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
        private readonly Data data;

        public FormProgrammi(Data data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void FormProgrammi_Load(object sender, EventArgs e)
        {
            if (data is null)
                return;

            data.UpdateAsync();

            if (!data.Ordini.Any())
                return;

            var programmi = data.Ordini
                .SelectMany(x => x.Lavori)
                .Select(x => x.Programma)
                .Distinct()
                .ToList();

            listBoxProgrammi.Sorted = false;
            listBoxProgrammi.Items.Clear();
            listBoxProgrammi.DataSource = programmi;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            var programmi = data.Ordini.SelectMany(x => x.Lavori).Select(x => x.Programma).Distinct().ToList();
            listBoxProgrammi.DataSource = programmi.Where(x => x.Contains(txtCerca.Text)).ToList();
        }

        private void listBoxProgrammi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormProgramma dialog = new FormProgramma(listBoxProgrammi.SelectedItem.ToString(), data);
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
