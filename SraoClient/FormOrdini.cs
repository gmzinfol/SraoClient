﻿using System;
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
    public partial class FormOrdini : Form
    {
        Data Data;

        public FormOrdini(Data data)
        {
            InitializeComponent();
            Data = data;
        }

        private void FormOrdini_Load(object sender, EventArgs e)
        {
            if (Data is null)
                return;

            Data.Update();

            if (!Data.Ordini.Any())
                return;

            var ordini = Data.Ordini
                .Where(x => x.Lavori.Count() > 0)
                .OrderByDescending(x => x.Lavori.FirstOrDefault().DataInizio).ToList();

            listBoxOrdini.Sorted = false;
            listBoxOrdini.Items.Clear();
            listBoxOrdini.DataSource = ordini;
        }

        private void listBoxOrdini_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormOrdine dialog = new FormOrdine(listBoxOrdini.SelectedItem as Ordine);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Show();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimeStart.Value.Date;
            DateTime dt2 = dateTimeEnd.Value.Date;

            if (dt1 > dt2)
                return;

            var ordini = Data.Ordini.Where(x => x.Lavori.Count() > 0);

            if (txtCerca.Text != String.Empty)
                ordini = ordini.Where(x => x.Commento.Contains(txtCerca.Text)).ToList();

            if (dateTimeStart.Enabled)
                ordini = ordini.Where(x => x.Lavori.Last().DataInizio > dt1).ToList();

            if (dateTimeEnd.Enabled)
                ordini = ordini.Where(x => x.Lavori.Last().DataInizio < dt2).ToList();

            listBoxOrdini.DataSource = ordini
                .OrderByDescending(x => x.Lavori.LastOrDefault().DataInizio)
                .ToList();
        }

        private void txtCerca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCerca.PerformClick();
            }
        }

        private void checkBoxStart_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeStart.Enabled = checkBoxStart.Checked;
        }

        private void checkBoxEnd_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeEnd.Enabled = checkBoxEnd.Checked;
        }
    }
}
