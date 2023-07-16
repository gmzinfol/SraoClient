
namespace SraoClient
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMenuPreferenze = new System.Windows.Forms.Button();
            this.btnMenuOrdini = new System.Windows.Forms.Button();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenuProgrammi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuPreferenze
            // 
            this.btnMenuPreferenze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(168)))));
            this.btnMenuPreferenze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPreferenze.FlatAppearance.BorderSize = 0;
            this.btnMenuPreferenze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPreferenze.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPreferenze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnMenuPreferenze.Location = new System.Drawing.Point(0, 180);
            this.btnMenuPreferenze.Name = "btnMenuPreferenze";
            this.btnMenuPreferenze.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuPreferenze.Size = new System.Drawing.Size(200, 60);
            this.btnMenuPreferenze.TabIndex = 4;
            this.btnMenuPreferenze.Text = "Preferenze";
            this.btnMenuPreferenze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPreferenze.UseVisualStyleBackColor = false;
            this.btnMenuPreferenze.Click += new System.EventHandler(this.btnMenuPreferenze_Click);
            // 
            // btnMenuOrdini
            // 
            this.btnMenuOrdini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(168)))));
            this.btnMenuOrdini.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuOrdini.FlatAppearance.BorderSize = 0;
            this.btnMenuOrdini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOrdini.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuOrdini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnMenuOrdini.Location = new System.Drawing.Point(0, 60);
            this.btnMenuOrdini.Name = "btnMenuOrdini";
            this.btnMenuOrdini.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuOrdini.Size = new System.Drawing.Size(200, 60);
            this.btnMenuOrdini.TabIndex = 3;
            this.btnMenuOrdini.Text = "Ordini";
            this.btnMenuOrdini.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOrdini.UseVisualStyleBackColor = false;
            this.btnMenuOrdini.Click += new System.EventHandler(this.btnMenuOrdini_Click);
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(168)))));
            this.btnMenuDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuDashboard.FlatAppearance.BorderSize = 0;
            this.btnMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDashboard.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnMenuDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuDashboard.Size = new System.Drawing.Size(200, 60);
            this.btnMenuDashboard.TabIndex = 0;
            this.btnMenuDashboard.Text = "Dashboard";
            this.btnMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDashboard.UseVisualStyleBackColor = false;
            this.btnMenuDashboard.Click += new System.EventHandler(this.btnMenuDashboard_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnMenuPreferenze);
            this.panelMenu.Controls.Add(this.btnMenuProgrammi);
            this.panelMenu.Controls.Add(this.btnMenuOrdini);
            this.panelMenu.Controls.Add(this.btnMenuDashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 431);
            this.panelMenu.TabIndex = 2;
            // 
            // btnMenuProgrammi
            // 
            this.btnMenuProgrammi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(168)))));
            this.btnMenuProgrammi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuProgrammi.FlatAppearance.BorderSize = 0;
            this.btnMenuProgrammi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProgrammi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProgrammi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnMenuProgrammi.Location = new System.Drawing.Point(0, 120);
            this.btnMenuProgrammi.Name = "btnMenuProgrammi";
            this.btnMenuProgrammi.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuProgrammi.Size = new System.Drawing.Size(200, 60);
            this.btnMenuProgrammi.TabIndex = 6;
            this.btnMenuProgrammi.Text = "Programmi";
            this.btnMenuProgrammi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProgrammi.UseVisualStyleBackColor = false;
            this.btnMenuProgrammi.Click += new System.EventHandler(this.btnMenuProgrammi_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(0, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "© INFOL S.r.l";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1010, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "Software Raccolta Avanzamento Ordini";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnAggiorna.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAggiorna.FlatAppearance.BorderSize = 0;
            this.btnAggiorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiorna.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAggiorna.ForeColor = System.Drawing.Color.White;
            this.btnAggiorna.Location = new System.Drawing.Point(719, 0);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(85, 70);
            this.btnAggiorna.TabIndex = 3;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = false;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.btnAggiorna);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 70);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(804, 501);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "Form1";
            this.Text = "Client";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenuPreferenze;
        private System.Windows.Forms.Button btnMenuOrdini;
        private System.Windows.Forms.Button btnMenuDashboard;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuProgrammi;
    }
}

