﻿
namespace SraoClient
{
    partial class FormProgrammi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProgrammi = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.listBoxProgrammi = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.labelProgrammi);
            this.panel1.Controls.Add(this.btnCerca);
            this.panel1.Controls.Add(this.txtCerca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 81);
            this.panel1.TabIndex = 8;
            // 
            // labelProgrammi
            // 
            this.labelProgrammi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgrammi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelProgrammi.Location = new System.Drawing.Point(13, 9);
            this.labelProgrammi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgrammi.Name = "labelProgrammi";
            this.labelProgrammi.Size = new System.Drawing.Size(589, 36);
            this.labelProgrammi.TabIndex = 6;
            this.labelProgrammi.Text = "Programmi";
            this.labelProgrammi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(168)))));
            this.btnCerca.FlatAppearance.BorderSize = 0;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerca.ForeColor = System.Drawing.Color.White;
            this.btnCerca.Location = new System.Drawing.Point(927, 45);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(143, 32);
            this.btnCerca.TabIndex = 5;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // txtCerca
            // 
            this.txtCerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerca.Location = new System.Drawing.Point(13, 47);
            this.txtCerca.Margin = new System.Windows.Forms.Padding(4);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(906, 30);
            this.txtCerca.TabIndex = 2;
            this.txtCerca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCerca_KeyDown);
            // 
            // listBoxProgrammi
            // 
            this.listBoxProgrammi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.listBoxProgrammi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProgrammi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProgrammi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProgrammi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.listBoxProgrammi.ItemHeight = 20;
            this.listBoxProgrammi.Location = new System.Drawing.Point(0, 81);
            this.listBoxProgrammi.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProgrammi.Name = "listBoxProgrammi";
            this.listBoxProgrammi.Size = new System.Drawing.Size(1090, 609);
            this.listBoxProgrammi.Sorted = true;
            this.listBoxProgrammi.TabIndex = 9;
            this.listBoxProgrammi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProgrammi_MouseDoubleClick);
            // 
            // FormProgrammi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1090, 690);
            this.Controls.Add(this.listBoxProgrammi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProgrammi";
            this.Text = "FormProgrammi";
            this.Load += new System.EventHandler(this.FormProgrammi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProgrammi;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.ListBox listBoxProgrammi;
    }
}