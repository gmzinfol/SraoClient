
namespace SraoClient
{
    partial class FormOrdine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdine));
            this.listBoxLavori = new System.Windows.Forms.ListBox();
            this.labelLavori = new System.Windows.Forms.Label();
            this.labelTempoMedio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxLavori
            // 
            this.listBoxLavori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.listBoxLavori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLavori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxLavori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLavori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.listBoxLavori.FormattingEnabled = true;
            this.listBoxLavori.ItemHeight = 16;
            this.listBoxLavori.Location = new System.Drawing.Point(0, 89);
            this.listBoxLavori.Name = "listBoxLavori";
            this.listBoxLavori.Size = new System.Drawing.Size(462, 288);
            this.listBoxLavori.Sorted = true;
            this.listBoxLavori.TabIndex = 1;
            this.listBoxLavori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxLavori_KeyDown);
            this.listBoxLavori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxLavori_MouseDoubleClick);
            // 
            // labelLavori
            // 
            this.labelLavori.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLavori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelLavori.Location = new System.Drawing.Point(187, 9);
            this.labelLavori.Name = "labelLavori";
            this.labelLavori.Size = new System.Drawing.Size(263, 29);
            this.labelLavori.TabIndex = 7;
            this.labelLavori.Text = "-";
            this.labelLavori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTempoMedio
            // 
            this.labelTempoMedio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.labelTempoMedio.Location = new System.Drawing.Point(132, 44);
            this.labelTempoMedio.Name = "labelTempoMedio";
            this.labelTempoMedio.Size = new System.Drawing.Size(330, 29);
            this.labelTempoMedio.TabIndex = 8;
            this.labelTempoMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero ordine:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tempo medio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormOrdine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(462, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTempoMedio);
            this.Controls.Add(this.labelLavori);
            this.Controls.Add(this.listBoxLavori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(482, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(482, 420);
            this.Name = "FormOrdine";
            this.Text = "Ordine";
            this.Load += new System.EventHandler(this.FormOrdine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLavori;
        private System.Windows.Forms.Label labelLavori;
        private System.Windows.Forms.Label labelTempoMedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}