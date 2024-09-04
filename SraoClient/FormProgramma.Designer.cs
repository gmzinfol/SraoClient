
namespace SraoClient
{
    partial class FormProgramma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgramma));
            this.label1 = new System.Windows.Forms.Label();
            this.labelProgramma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTempoMedio = new System.Windows.Forms.Label();
            this.listBoxLavori = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Programma:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProgramma
            // 
            this.labelProgramma.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelProgramma.Location = new System.Drawing.Point(194, 11);
            this.labelProgramma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgramma.Name = "labelProgramma";
            this.labelProgramma.Size = new System.Drawing.Size(412, 36);
            this.labelProgramma.TabIndex = 11;
            this.labelProgramma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tempo medio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTempoMedio
            // 
            this.labelTempoMedio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelTempoMedio.Location = new System.Drawing.Point(179, 46);
            this.labelTempoMedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempoMedio.Name = "labelTempoMedio";
            this.labelTempoMedio.Size = new System.Drawing.Size(427, 36);
            this.labelTempoMedio.TabIndex = 13;
            this.labelTempoMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxLavori
            // 
            this.listBoxLavori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.listBoxLavori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLavori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxLavori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLavori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.listBoxLavori.FormattingEnabled = true;
            this.listBoxLavori.ItemHeight = 20;
            this.listBoxLavori.Location = new System.Drawing.Point(0, 99);
            this.listBoxLavori.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLavori.Name = "listBoxLavori";
            this.listBoxLavori.Size = new System.Drawing.Size(619, 360);
            this.listBoxLavori.Sorted = true;
            this.listBoxLavori.TabIndex = 14;
            this.listBoxLavori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxLavori_KeyDown);
            this.listBoxLavori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxLavori_MouseDoubleClick);
            // 
            // FormProgramma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 459);
            this.Controls.Add(this.listBoxLavori);
            this.Controls.Add(this.labelTempoMedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelProgramma);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(637, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(637, 506);
            this.Name = "FormProgramma";
            this.Text = "Programma";
            this.Load += new System.EventHandler(this.FormProgramma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgramma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTempoMedio;
        private System.Windows.Forms.ListBox listBoxLavori;
    }
}