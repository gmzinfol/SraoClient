using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace SraoClient
{
    public partial class FormDefault : Form
    {
        private readonly Preferences preferences;
        private readonly SraoRepository repository;

        public FormDefault()
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("it-IT");

            IsMdiContainer = true;
            btnMenuDashboard.PerformClick();

            // Auto update
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 30 secs
            timer.Tick += new EventHandler(AggiornaDashboard);
            timer.Start();

            // Load Preferences object
            preferences = new Preferences();
            preferences.Load(); // Carica preferenze

            // Create repository
            var sraoApi = new SraoApi(preferences.Server);
            repository = new SraoRepository(sraoApi);

            // Load Dashboard form as default
            FormDashboard fd = new FormDashboard(repository);
            fd.MdiParent = this;
            fd.Dock = DockStyle.Fill;
            fd.Show();
            OnClick(btnMenuDashboard);
        }

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            FormDashboard fd = new FormDashboard(repository);
            fd.MdiParent = this;
            fd.Dock = DockStyle.Fill;
            fd.Show();
        }

        private void btnMenuOrdini_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            FormOrdini fo = new FormOrdini(repository);
            fo.MdiParent = this;
            fo.Dock = DockStyle.Fill;
            fo.Show();
        }

        private void btnMenuProgrammi_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            // FormProgrammi fp = new FormProgrammi(data);
            // fp.MdiParent = this;
            // fp.Dock = DockStyle.Fill;
            // fp.Show();
        }

        private void btnMenuPreferenze_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            // FormImpostazioni fp = new FormImpostazioni(preferences, data);
            // fp.MdiParent = this;
            // fp.Dock = DockStyle.Fill;
            // fp.Show();
        }

        private void btnMenuMacchine_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            // FormMacchine fm = new FormMacchine(data);
            // fm.MdiParent = this;
            // fm.Dock = DockStyle.Fill;
            // fm.Show();
        }

        public void OnClick(object sender)
        {
            btnMenuDashboard.BackColor = Color.FromArgb(50, 110, 168);
            btnMenuOrdini.BackColor = Color.FromArgb(50, 110, 168);
            btnMenuProgrammi.BackColor = Color.FromArgb(50, 110, 168);
            btnMenuPreferenze.BackColor = Color.FromArgb(50, 110, 168);
            btnMenuMacchine.BackColor = Color.FromArgb(50, 110, 168);

            (sender as Button).BackColor = Color.FromArgb(60, 132, 201);

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormDashboard)
            {
                btnMenuDashboard.PerformClick();
            }
            else if (ActiveMdiChild is FormOrdini)
            {
                btnMenuOrdini.PerformClick();
            }
            else if (ActiveMdiChild is FormProgrammi)
            {
                btnMenuProgrammi.PerformClick();
            }
            else if (ActiveMdiChild is FormMacchine)
            {
                btnMenuMacchine.PerformClick();
            }
            else if (ActiveMdiChild is FormImpostazioni)
            {
                // Impostazioni does not get information from Data class
            }
            // data.UpdateAsync();
        }

        private void AggiornaDashboard(object sender, EventArgs e)
        {
            // If you are in the Dashboard you should refresh the window.
            // If you are in another form you should not refresh the window
            // since refreshing clears whatever the user is doing.
            if (ActiveMdiChild is FormDashboard)
            {
                btnMenuDashboard.PerformClick();
            }
            else
            {
                // data.UpdateAsync();
            }
        }
    }
}