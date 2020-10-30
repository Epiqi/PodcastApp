﻿using System;
using System.Windows.Forms;
using BL.Validering;
using BL.Controllers;
using System.Collections.Generic;
using Entities;

namespace PodcastApp
{
    public partial class Podcast_app : Form
    {
        FeedController feedController;
        KategoriController kategoriController;
        ValideringAvEntities validering;
        string urlSKaInteAndras;

        public Podcast_app()
        {
            InitializeComponent();
            feedController = new FeedController();
            kategoriController = new KategoriController();
            validering = new ValideringAvEntities();
            SkrivUtSparade();
            SkrivUtSparadeKategorier();

        }
        private void lstAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string feedUrl = podcastDataGridView.CurrentRow.Cells[2].Value.ToString();
            Feed valdFeed = feedController.GetFeed(feedUrl);
            lblRubrikPodcastInfo.Text = valdFeed.Namn + ".";
            lblPodAvsnitt.Text = valdFeed.Avsnitten[lstAvsnitt.SelectedIndex].Namn;
            lblPodcastBeskrivning.Text = valdFeed.Avsnitten[lstAvsnitt.SelectedIndex].Beskrivning;
        }
        private void podcastDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (podcastDataGridView.Rows.Count > 0)
            {
                txtNamn.Text = podcastDataGridView.CurrentRow.Cells[1].Value.ToString();
                urlSKaInteAndras = podcastDataGridView.CurrentRow.Cells[2].Value.ToString();
                cmbxFrekvens.Text = podcastDataGridView.CurrentRow.Cells[3].Value.ToString();
                cmbxKategori.Text = podcastDataGridView.CurrentRow.Cells[4].Value.ToString();
                skrivUtAvsnittForValdPod();
            }
        }

        private void skrivUtAvsnittForValdPod()
        {
            lstAvsnitt.Items.Clear();
            string feedUrl = podcastDataGridView.CurrentRow.Cells[2].Value.ToString();
            Feed valdFeed = feedController.GetFeed(feedUrl);
            lblRubrikPodcastInfo.Text = valdFeed.Namn;
            lblPodcastBeskrivning.Text = valdFeed.Beskrivning;
            lblPodAvsnitt.Text = "";
            foreach (Avsnitt avsnitt in valdFeed.Avsnitten)
            {
                lstAvsnitt.Items.Add(valdFeed.Namn + ". Avsnitt " + avsnitt.Nummer + ". " + avsnitt.Namn);
            }
        }


        private void SkrivFeed(string url)
        {
            string avsnitt = ""; //Hämta värde från rss-feed.
            Entities.Feed ny = feedController.GetFeed(url);
            avsnitt = $"{ny.Avsnitten.Count}";
            podcastDataGridView.Rows.Add(new string[] { avsnitt, ny.Namn, ny.Url, ny.UppdateringsTid, ny.Kategorier });
        }

        private void SkrivUtSparade()
        {
            foreach (Feed feed in feedController.GetAll())
                SkrivFeed(feed.Url);

        }

        private void SkrivUtSparadeKategorier()
        {

            foreach (Kategori kategori in kategoriController.GetAll())
            {
                lstKategorier.Items.Add(kategori.Namn);
                cmbxKategori.Items.Add(kategori.Namn);
            }
        }

        private void btnNyFeed_Click(object sender, System.EventArgs e)
        {
            try
            {


                if (!String.IsNullOrEmpty(txtNamn.Text) && !String.IsNullOrEmpty(txtURL.Text)
                    && !String.IsNullOrEmpty(cmbxFrekvens.Text) && !String.IsNullOrEmpty(cmbxKategori.Text))
                {
                    string namn = txtNamn.Text;
                    string url = txtURL.Text;
                    string frekvens = cmbxFrekvens.Text;
                    string kategori = cmbxKategori.Text;
                    List<Feed> feedLista = feedController.GetAll();
                    List<Kategori> kategoriLista = kategoriController.GetAll();


                    if (validering.EndastEttNamn(feedLista, namn) && validering.KorrektURL(url) && validering.EndastEnURL(feedLista, url)
                        && validering.EnFrekvensArVald(frekvens) && validering.KorrektKategori(kategoriLista, kategori))
                    {
                        int antalFeeds = feedController.GetAll().Count;
                        feedController.SkapaFeedObjekt(namn, url, frekvens, kategori);
                        if (feedController.GetAll().Count > antalFeeds)
                            SkrivFeed(url);
                    }
                }
                else
                {
                    MessageBox.Show("Det måste finnas värden i alla rutor");
                }

            }
            catch (UserException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnSparaNyaVardenFeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtNamn.Text) && !String.IsNullOrEmpty(cmbxFrekvens.Text)
                    && !String.IsNullOrEmpty(cmbxKategori.Text))
                {
                    string namn = txtNamn.Text;
                    string url = urlSKaInteAndras;
                    string frekvens = cmbxFrekvens.Text;
                    string kategori = cmbxKategori.Text;

                    List<Feed> allaUtomAktuellFeed = feedController.GetAllExceptThisOne(url);
                    List<Kategori> allaKategori = kategoriController.GetAll();


                    if (validering.EndastEttNamn(allaUtomAktuellFeed, namn) && validering.EnFrekvensArVald(frekvens)
                        && validering.KorrektKategori(allaKategori, kategori))
                    {
                        int antalFeeds = feedController.GetAll().Count;

                        podcastDataGridView.Rows.RemoveAt(podcastDataGridView.CurrentCell.RowIndex);

                        feedController.DeleteFeed(url);
                        feedController.SkapaFeedObjekt(namn, url, frekvens, kategori);



                        if (feedController.GetAll().Count == antalFeeds)
                            SkrivFeed(url);
                        ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Det måste finnas värden i alla rutor");
                }
            }
            catch (UserException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (System.NullReferenceException exception)
            {
                MessageBox.Show("Ingen pod är vald");
            }
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            try
            {
                int valtIndex = podcastDataGridView.CurrentCell.RowIndex;
                if (valtIndex > -1)
                {
                    if (DialogResult.Yes == MessageBox.Show("Vill du ta bort podden ?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        string urlToDelete = podcastDataGridView.Rows[valtIndex].Cells[2].Value.ToString();
                        feedController.DeleteFeed(urlToDelete);
                        podcastDataGridView.Rows.RemoveAt(valtIndex);
                        ClearSelection();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Kan inte ta bort vald rad, välj raden och försök igen");
            }
        }


        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtValdKategori.Text))
            {
                string kategoriNamn = txtValdKategori.Text;
                List<Feed> feedLista = feedController.GetAll();

                if (validering.EndastEttNamn(feedLista, kategoriNamn))
                {
                    kategoriController.SkapaKategoriObjekt(kategoriNamn);
                    lstKategorier.Items.Add(kategoriNamn);
                    cmbxKategori.Items.Add(kategoriNamn);
                    txtValdKategori.Text = "";
                }
            }
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {

            if (lstKategorier.SelectedItems.Count > 0)
            {
                string gamlaKategorin = lstKategorier.SelectedItem.ToString();
                string nyKategori = txtValdKategori.Text;
                kategoriController.SkapaKategoriObjekt(nyKategori);
                feedController.ChangeKategori(nyKategori, gamlaKategorin);
                ClearSelection();
                kategoriController.DeleteKategori(gamlaKategorin);
                lstKategorier.Items.Clear();
                cmbxKategori.Items.Clear();
                podcastDataGridView.Rows.Clear();
                SkrivUtSparade();
                SkrivUtSparadeKategorier();
                ClearSelection();
                //kategoriController.UppdateraKategoriObjekt(kategoriNamn);
            }
        }

        private void lstKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategorier.SelectedItem != null)
                txtValdKategori.Text = lstKategorier.SelectedItem.ToString();
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtValdKategori.Text))
                {
                    string kategoriNamn = txtValdKategori.Text;

                    if (DialogResult.Yes == MessageBox.Show
                   ("Vill du ta bort kategorin och alla tillhörande poddar?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        lstKategorier.Items.Remove(lstKategorier.SelectedItem);
                        cmbxKategori.Items.Remove(kategoriNamn);
                        ClearSelection();
                        feedController.DeleteByKategori(kategoriNamn);
                        kategoriController.DeleteKategori(kategoriNamn);
                        // ta bort rätt rader i datagridview
                        podcastDataGridView.Rows.Clear();
                        SkrivUtSparade();
                        ClearSelection();

                    }
                }
            }
            catch (InvalidOperationException ex) //gör nytt eget exeption
            {
                MessageBox.Show("Kan inte ta bort valda poddar, välj kategori och försök igen");
            }
        }

        private void Podcast_app_Load(object sender, EventArgs e)
        {
            ClearSelection();
        }

        private void ClearSelection()
        {
            podcastDataGridView.ClearSelection();
            txtNamn.Text = "";
            txtURL.Text = "";
            cmbxFrekvens.Text = "Välj en frekvens";
            cmbxKategori.Text = "Välj en kategori";
            lstAvsnitt.Items.Clear();
            lblRubrikPodcastInfo.Text = "Podcast";
            lblPodAvsnitt.Text = "Avsnitt";
            lblPodcastBeskrivning.Text = "Beskrivning";
        }
    }
}
