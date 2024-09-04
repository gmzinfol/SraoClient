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
        private readonly Preferences preferences;
        private readonly Data data;

        public FormImpostazioni(Preferences prefs, Data data)
        {
            InitializeComponent();

            preferences = prefs;
            this.data = data;
        }

        private void FormImpostazioni_Load(object sender, EventArgs e)
        {
            if (preferences is null)
                return;

            preferences.Load();

            if (preferences.Server is null)
                return;

            txtScambio.Text = preferences.Server;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (preferences is null)
                return;

            preferences.Server = txtScambio.Text;
            preferences.Save();

            if (data is null)
                return;

            data.ChangeHost(preferences.Server);
        }
    }
}
