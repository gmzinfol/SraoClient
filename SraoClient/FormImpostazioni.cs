using System;
using System.IO;
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
    public partial class FormImpostazioni : Form
    {
        Preferences Preferences;
        Data DataOrdini;
        public FormImpostazioni(Preferences prefs, Data dataOrdini)
        {
            InitializeComponent();
            Preferences = prefs;
            Preferences.Load();

            DataOrdini = dataOrdini;

            if (Preferences.Server != null)
                txtScambio.Text = Preferences.Server;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Preferences.Server = txtScambio.Text;
            Preferences.Save();

            DataOrdini.ChangeHost(Preferences.Server);
        }

        private void FormImpostazioni_Load(object sender, EventArgs e)
        {

        }
    }
}
