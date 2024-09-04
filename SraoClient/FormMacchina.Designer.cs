namespace SraoClient
{
    partial class FormMacchina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMacchina));
            this.listBoxLavori = new System.Windows.Forms.ListBox();
            this.labelTempoMedio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMacchina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.listBoxLavori.ItemHeight = 20;
            this.listBoxLavori.Location = new System.Drawing.Point(0, 99);
            this.listBoxLavori.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLavori.Name = "listBoxLavori";
            this.listBoxLavori.Size = new System.Drawing.Size(619, 360);
            this.listBoxLavori.Sorted = true;
            this.listBoxLavori.TabIndex = 15;
            this.listBoxLavori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxLavori_KeyDown);
            this.listBoxLavori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxLavori_MouseDoubleClick);
            // 
            // labelTempoMedio
            // 
            this.labelTempoMedio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelTempoMedio.Location = new System.Drawing.Point(176, 44);
            this.labelTempoMedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempoMedio.Name = "labelTempoMedio";
            this.labelTempoMedio.Size = new System.Drawing.Size(427, 36);
            this.labelTempoMedio.TabIndex = 19;
            this.labelTempoMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tempo medio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMacchina
            // 
            this.labelMacchina.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMacchina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelMacchina.Location = new System.Drawing.Point(167, 9);
            this.labelMacchina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMacchina.Name = "labelMacchina";
            this.labelMacchina.Size = new System.Drawing.Size(412, 36);
            this.labelMacchina.TabIndex = 17;
            this.labelMacchina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Macchina:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMacchina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 459);
            this.Controls.Add(this.labelTempoMedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMacchina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLavori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(637, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(637, 506);
            this.Name = "FormMacchina";
            this.Text = "Macchina";
            this.Load += new System.EventHandler(this.FormMacchina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLavori;
        private System.Windows.Forms.Label labelTempoMedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMacchina;
        private System.Windows.Forms.Label label1;
    }
}