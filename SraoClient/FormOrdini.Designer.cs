
namespace SraoClient
{
    partial class FormOrdini
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
            this.listBoxOrdini = new System.Windows.Forms.ListBox();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.labelOrdini = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOrdini
            // 
            this.listBoxOrdini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.listBoxOrdini.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOrdini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOrdini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrdini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.listBoxOrdini.ItemHeight = 16;
            this.listBoxOrdini.Location = new System.Drawing.Point(0, 0);
            this.listBoxOrdini.Name = "listBoxOrdini";
            this.listBoxOrdini.Size = new System.Drawing.Size(800, 329);
            this.listBoxOrdini.Sorted = true;
            this.listBoxOrdini.TabIndex = 0;
            this.listBoxOrdini.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOrdini_MouseDoubleClick);
            // 
            // txtCerca
            // 
            this.txtCerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerca.Location = new System.Drawing.Point(12, 40);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(663, 26);
            this.txtCerca.TabIndex = 2;
            this.txtCerca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCerca_KeyDown);
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(168)))));
            this.btnCerca.FlatAppearance.BorderSize = 0;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerca.ForeColor = System.Drawing.Color.White;
            this.btnCerca.Location = new System.Drawing.Point(681, 40);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(107, 26);
            this.btnCerca.TabIndex = 5;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // labelOrdini
            // 
            this.labelOrdini.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelOrdini.Location = new System.Drawing.Point(12, 9);
            this.labelOrdini.Name = "labelOrdini";
            this.labelOrdini.Size = new System.Drawing.Size(442, 29);
            this.labelOrdini.TabIndex = 6;
            this.labelOrdini.Text = "Ordini";
            this.labelOrdini.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.checkBoxEnd);
            this.panel1.Controls.Add(this.checkBoxStart);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.labelOrdini);
            this.panel1.Controls.Add(this.btnCerca);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.txtCerca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 121);
            this.panel1.TabIndex = 7;
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.AutoSize = true;
            this.checkBoxEnd.Location = new System.Drawing.Point(206, 101);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(46, 17);
            this.checkBoxEnd.TabIndex = 10;
            this.checkBoxEnd.Text = "Fine";
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            this.checkBoxEnd.CheckedChanged += new System.EventHandler(this.checkBoxEnd_CheckedChanged);
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(206, 75);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(50, 17);
            this.checkBoxStart.TabIndex = 9;
            this.checkBoxStart.Text = "Inizio";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.CheckedChanged += new System.EventHandler(this.checkBoxStart_CheckedChanged);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Enabled = false;
            this.dateTimeEnd.Location = new System.Drawing.Point(12, 98);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(188, 20);
            this.dateTimeEnd.TabIndex = 8;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Enabled = false;
            this.dateTimeStart.Location = new System.Drawing.Point(12, 72);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(188, 20);
            this.dateTimeStart.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxOrdini);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 329);
            this.panel2.TabIndex = 8;
            // 
            // FormOrdini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrdini";
            this.Text = "FormOrdini";
            this.Load += new System.EventHandler(this.FormOrdini_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrdini;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label labelOrdini;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.CheckBox checkBoxEnd;
        private System.Windows.Forms.CheckBox checkBoxStart;
    }
}