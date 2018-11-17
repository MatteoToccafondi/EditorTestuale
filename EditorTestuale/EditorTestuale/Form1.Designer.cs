﻿namespace EditorTestuale
{
    partial class EditorTestuale
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
            this.txtBEditor = new System.Windows.Forms.TextBox();
            this.btnScelta = new System.Windows.Forms.Button();
            this.btnIndenta = new System.Windows.Forms.Button();
            this.lblNomefile = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBEditor
            // 
            this.txtBEditor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBEditor.Enabled = false;
            this.txtBEditor.Location = new System.Drawing.Point(12, 12);
            this.txtBEditor.Multiline = true;
            this.txtBEditor.Name = "txtBEditor";
            this.txtBEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBEditor.Size = new System.Drawing.Size(324, 260);
            this.txtBEditor.TabIndex = 0;
            // 
            // btnScelta
            // 
            this.btnScelta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScelta.Location = new System.Drawing.Point(12, 278);
            this.btnScelta.Name = "btnScelta";
            this.btnScelta.Size = new System.Drawing.Size(75, 23);
            this.btnScelta.TabIndex = 2;
            this.btnScelta.Text = "Scegli il file";
            this.btnScelta.UseVisualStyleBackColor = true;
            this.btnScelta.Click += new System.EventHandler(this.BtnScelta_Click);
            // 
            // btnIndenta
            // 
            this.btnIndenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIndenta.Location = new System.Drawing.Point(342, 12);
            this.btnIndenta.Name = "btnIndenta";
            this.btnIndenta.Size = new System.Drawing.Size(75, 23);
            this.btnIndenta.TabIndex = 3;
            this.btnIndenta.Text = "Indenta";
            this.btnIndenta.UseVisualStyleBackColor = true;
            this.btnIndenta.Click += new System.EventHandler(this.BtnIndenta_Click);
            // 
            // lblNomefile
            // 
            this.lblNomefile.AutoSize = true;
            this.lblNomefile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNomefile.Location = new System.Drawing.Point(93, 283);
            this.lblNomefile.Name = "lblNomefile";
            this.lblNomefile.Size = new System.Drawing.Size(65, 13);
            this.lblNomefile.TabIndex = 4;
            this.lblNomefile.Text = "Percorso file";
            // 
            // btnSalva
            // 
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalva.Location = new System.Drawing.Point(12, 317);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 5;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.BtnSalva_Click);
            // 
            // EditorTestuale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(432, 352);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lblNomefile);
            this.Controls.Add(this.btnIndenta);
            this.Controls.Add(this.btnScelta);
            this.Controls.Add(this.txtBEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditorTestuale";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Testuale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBEditor;
        private System.Windows.Forms.Button btnScelta;
        private System.Windows.Forms.Button btnIndenta;
        private System.Windows.Forms.Label lblNomefile;
        private System.Windows.Forms.Button btnSalva;
    }
}

