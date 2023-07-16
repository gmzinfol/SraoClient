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
        Data Data;

        public FormImpostazioni(Preferences prefs, Data data)
        {
            InitializeComponent();

            Preferences = prefs;
            Data = data;
        }

        private void FormImpostazioni_Load(object sender, EventArgs e)
        {
            if (Preferences is null)
                return;

            Preferences.Load();

            if (Preferences.Server is null)
                return;

            txtScambio.Text = Preferences.Server;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Preferences is null || Preferences.Server is null)
                return;

            Preferences.Server = txtScambio.Text;
            Preferences.Save();

            if (Data is null)
                return;

            Data.ChangeHost(Preferences.Server);
        }
    }
}
