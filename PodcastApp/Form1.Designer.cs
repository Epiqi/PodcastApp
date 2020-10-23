﻿namespace PodcastApp
{
    partial class Podcast_app
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblUppdateringsf = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cmbxFrekvens = new System.Windows.Forms.ComboBox();
            this.cmbxKategori = new System.Windows.Forms.ComboBox();
            this.btnNy = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lstAvsnitt = new System.Windows.Forms.ListBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lstKategorier = new System.Windows.Forms.ListBox();
            this.txtValdKategori = new System.Windows.Forms.TextBox();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.lblRubrikPodcastInfo = new System.Windows.Forms.Label();
            this.lblPodcastBeskrivning = new System.Windows.Forms.Label();
            this.podcastInfoGridView = new System.Windows.Forms.DataGridView();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrekvens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.podcastInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(26, 313);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(49, 19);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // lblUppdateringsf
            // 
            this.lblUppdateringsf.AutoSize = true;
            this.lblUppdateringsf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdateringsf.Location = new System.Drawing.Point(307, 312);
            this.lblUppdateringsf.Name = "lblUppdateringsf";
            this.lblUppdateringsf.Size = new System.Drawing.Size(176, 19);
            this.lblUppdateringsf.TabIndex = 2;
            this.lblUppdateringsf.Text = "Uppdateringfrekvens:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(551, 312);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(80, 19);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(29, 339);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(255, 20);
            this.txtURL.TabIndex = 4;
            // 
            // cmbxFrekvens
            // 
            this.cmbxFrekvens.FormattingEnabled = true;
            this.cmbxFrekvens.Items.AddRange(new object[] {
            "option 1",
            "option2",
            "option 3"});
            this.cmbxFrekvens.Location = new System.Drawing.Point(311, 337);
            this.cmbxFrekvens.Name = "cmbxFrekvens";
            this.cmbxFrekvens.Size = new System.Drawing.Size(229, 21);
            this.cmbxFrekvens.TabIndex = 5;
            this.cmbxFrekvens.Text = "Välj uppdateringsfrekvens";
            // 
            // cmbxKategori
            // 
            this.cmbxKategori.FormattingEnabled = true;
            this.cmbxKategori.Location = new System.Drawing.Point(554, 337);
            this.cmbxKategori.Name = "cmbxKategori";
            this.cmbxKategori.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbxKategori.Size = new System.Drawing.Size(186, 21);
            this.cmbxKategori.TabIndex = 6;
            this.cmbxKategori.Text = "Välj en kategori";
            // 
            // btnNy
            // 
            this.btnNy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNy.Location = new System.Drawing.Point(414, 390);
            this.btnNy.Name = "btnNy";
            this.btnNy.Size = new System.Drawing.Size(75, 23);
            this.btnNy.TabIndex = 7;
            this.btnNy.Text = "Ny...";
            this.btnNy.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            this.btnSpara.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpara.Location = new System.Drawing.Point(538, 390);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 8;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBort.Location = new System.Drawing.Point(665, 390);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(75, 23);
            this.btnTaBort.TabIndex = 9;
            this.btnTaBort.Text = "Ta bort...";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(27, 433);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(54, 19);
            this.lblAvsnitt.TabIndex = 10;
            this.lblAvsnitt.Text = "label4";
            // 
            // lstAvsnitt
            // 
            this.lstAvsnitt.FormattingEnabled = true;
            this.lstAvsnitt.Location = new System.Drawing.Point(26, 458);
            this.lstAvsnitt.Name = "lstAvsnitt";
            this.lstAvsnitt.Size = new System.Drawing.Size(714, 290);
            this.lstAvsnitt.TabIndex = 12;
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.BackColor = System.Drawing.Color.White;
            this.lblKategorier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(791, 23);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(95, 19);
            this.lblKategorier.TabIndex = 13;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // lstKategorier
            // 
            this.lstKategorier.FormattingEnabled = true;
            this.lstKategorier.Location = new System.Drawing.Point(782, 43);
            this.lstKategorier.Name = "lstKategorier";
            this.lstKategorier.Size = new System.Drawing.Size(389, 251);
            this.lstKategorier.TabIndex = 14;
            // 
            // txtValdKategori
            // 
            this.txtValdKategori.Location = new System.Drawing.Point(782, 337);
            this.txtValdKategori.Name = "txtValdKategori";
            this.txtValdKategori.Size = new System.Drawing.Size(389, 20);
            this.txtValdKategori.TabIndex = 15;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNyKategori.Location = new System.Drawing.Point(782, 390);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(113, 23);
            this.btnNyKategori.TabIndex = 16;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparaKategori.Location = new System.Drawing.Point(928, 390);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(113, 23);
            this.btnSparaKategori.TabIndex = 17;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortKategori.Location = new System.Drawing.Point(1058, 390);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(113, 23);
            this.btnTaBortKategori.TabIndex = 18;
            this.btnTaBortKategori.Text = "Ta bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // lblRubrikPodcastInfo
            // 
            this.lblRubrikPodcastInfo.AutoSize = true;
            this.lblRubrikPodcastInfo.BackColor = System.Drawing.Color.White;
            this.lblRubrikPodcastInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubrikPodcastInfo.Location = new System.Drawing.Point(792, 469);
            this.lblRubrikPodcastInfo.Name = "lblRubrikPodcastInfo";
            this.lblRubrikPodcastInfo.Size = new System.Drawing.Size(47, 16);
            this.lblRubrikPodcastInfo.TabIndex = 19;
            this.lblRubrikPodcastInfo.Text = "label6";
            // 
            // lblPodcastBeskrivning
            // 
            this.lblPodcastBeskrivning.AutoSize = true;
            this.lblPodcastBeskrivning.BackColor = System.Drawing.Color.White;
            this.lblPodcastBeskrivning.Location = new System.Drawing.Point(792, 499);
            this.lblPodcastBeskrivning.Name = "lblPodcastBeskrivning";
            this.lblPodcastBeskrivning.Size = new System.Drawing.Size(35, 13);
            this.lblPodcastBeskrivning.TabIndex = 20;
            this.lblPodcastBeskrivning.Text = "label7";
            // 
            // podcastInfoGridView
            // 
            this.podcastInfoGridView.AllowUserToAddRows = false;
            this.podcastInfoGridView.AllowUserToDeleteRows = false;
            this.podcastInfoGridView.AllowUserToResizeColumns = false;
            this.podcastInfoGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.podcastInfoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.podcastInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podcastInfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAvsnitt,
            this.ColumnNamn,
            this.ColumnFrekvens,
            this.ColumnKategori});
            this.podcastInfoGridView.Location = new System.Drawing.Point(26, 22);
            this.podcastInfoGridView.Name = "podcastInfoGridView";
            this.podcastInfoGridView.ReadOnly = true;
            this.podcastInfoGridView.RowHeadersVisible = false;
            this.podcastInfoGridView.Size = new System.Drawing.Size(714, 272);
            this.podcastInfoGridView.TabIndex = 21;
            this.podcastInfoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.podcastInfoGridView_CellContentClick);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(26, 370);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(60, 19);
            this.lblNamn.TabIndex = 22;
            this.lblNamn.Text = "Namn:";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(29, 392);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(255, 20);
            this.txtNamn.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(782, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 290);
            this.label1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(782, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 272);
            this.label2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(759, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 725);
            this.label3.TabIndex = 26;
            // 
            // ColumnAvsnitt
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ColumnAvsnitt.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnAvsnitt.HeaderText = "Avsnitt";
            this.ColumnAvsnitt.Name = "ColumnAvsnitt";
            this.ColumnAvsnitt.ReadOnly = true;
            // 
            // ColumnNamn
            // 
            this.ColumnNamn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNamn.HeaderText = "Namn";
            this.ColumnNamn.Name = "ColumnNamn";
            this.ColumnNamn.ReadOnly = true;
            // 
            // ColumnFrekvens
            // 
            this.ColumnFrekvens.HeaderText = "Frekvens";
            this.ColumnFrekvens.Name = "ColumnFrekvens";
            this.ColumnFrekvens.ReadOnly = true;
            this.ColumnFrekvens.Width = 150;
            // 
            // ColumnKategori
            // 
            this.ColumnKategori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnKategori.HeaderText = "Kategori";
            this.ColumnKategori.Name = "ColumnKategori";
            this.ColumnKategori.ReadOnly = true;
            // 
            // Podcast_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1210, 776);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.podcastInfoGridView);
            this.Controls.Add(this.lblPodcastBeskrivning);
            this.Controls.Add(this.lblRubrikPodcastInfo);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.txtValdKategori);
            this.Controls.Add(this.lstKategorier);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lstAvsnitt);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnNy);
            this.Controls.Add(this.cmbxKategori);
            this.Controls.Add(this.cmbxFrekvens);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppdateringsf);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Podcast_app";
            this.Text = "Podcast app";
            ((System.ComponentModel.ISupportInitialize)(this.podcastInfoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblUppdateringsf;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cmbxFrekvens;
        private System.Windows.Forms.ComboBox cmbxKategori;
        private System.Windows.Forms.Button btnNy;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ListBox lstAvsnitt;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.ListBox lstKategorier;
        private System.Windows.Forms.TextBox txtValdKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Label lblRubrikPodcastInfo;
        private System.Windows.Forms.Label lblPodcastBeskrivning;
        private System.Windows.Forms.DataGridView podcastInfoGridView;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrekvens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKategori;
    }
}

