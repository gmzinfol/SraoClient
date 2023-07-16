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
    public partial class Form1 : Form
    {
        Preferences Preferences;
        Data DataOrdini;
        public Form1()
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("it-IT");

            IsMdiContainer = true;
            btnMenuDashboard.PerformClick();

            // Auto update
            Timer timer = new Timer();
            timer.Interval = (30 * 1000); // 30 secs
            timer.Tick += new EventHandler(AggiornaDashboard);
            timer.Start();

            // Load Preferences object
            Preferences = new Preferences();
            Preferences.Load(); // Carica preferenze

            // Load Dashboard form as default
            DataOrdini = new Data(Preferences.Server);
            FormDashboard fd = new FormDashboard(DataOrdini);
            fd.MdiParent = this;
            fd.Dock = DockStyle.Fill;
            fd.Show();
            OnClick(btnMenuDashboard);
        }

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            FormDashboard fd = new FormDashboard(DataOrdini);
            fd.MdiParent = this;
            fd.Dock = DockStyle.Fill;
            fd.Show();
        }

        private void btnMenuOrdini_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            FormOrdini fd = new FormOrdini(DataOrdini);
            fd.MdiParent = this;
            fd.Dock = DockStyle.Fill;
            fd.Show();
        }

        private void btnMenuProgrammi_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            FormProgrammi fd = new FormProgrammi(DataOrdini);
            fd.MdiParent = this;
            fd.Dock = DockStyle.Fill;
            fd.Show();
        }

        private void btnMenuPreferenze_Click(object sender, EventArgs e)
        {
            OnClick(sender);

            FormImpostazioni fd = new FormImpostazioni(Preferences, DataOrdini);
            fd.MdiParent = this;
            fd.Dock = DockStyle.Fill;
            fd.Show();
        }

        public void OnClick(object sender)
        {
            btnMenuDashboard.BackColor = Color.FromArgb(50, 110, 168);
            btnMenuOrdini.BackColor = Color.FromArgb(50, 110, 168);
            btnMenuProgrammi.BackColor = Color.FromArgb(50, 110, 168);
            btnMenuPreferenze.BackColor = Color.FromArgb(50, 110, 168);

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
            else if (ActiveMdiChild is FormImpostazioni)
            {
                DataOrdini.Update();
            }
        }

        private void AggiornaDashboard(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormDashboard)
            {
                btnMenuDashboard.PerformClick();
            }
            else
            {
                DataOrdini.Update();
            }
        }
    }
}
