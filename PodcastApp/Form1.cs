using System;
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
        AvsnittController avsnittController;

        public Podcast_app()
        {
            InitializeComponent();
            feedController = new FeedController();
            kategoriController = new KategoriController();
            avsnittController = new AvsnittController();
            SkrivUtSparade();

        }

        private void podcastDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Skriv ut avsnitt för vald podcast
            lstAvsnitt.Items.Clear();
            string feedUrl = podcastDataGridView.CurrentRow.Cells[2].Value.ToString();
            Feed valdFeed = feedController.GetFeed(feedUrl);
            int nummer = 1;
            foreach (Avsnitt avsnitt in valdFeed.Avsnitten)
            {
                lstAvsnitt.Items.Add(nummer++ + ".  " + avsnitt.Beskrivning);
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

        private void btnNyFeed_Click(object sender, System.EventArgs e)
        {
            try
            {
                string namn = txtNamn.Text;
                string url = txtURL.Text;
                string frekvens = cmbxFrekvens.Text;
                string kategori = cmbxKategori.Text;

                if (!String.IsNullOrEmpty(namn) && !String.IsNullOrEmpty(txtURL.Text)
                    && !String.IsNullOrEmpty(cmbxFrekvens.Text) && !String.IsNullOrEmpty(cmbxKategori.Text))
                {
                    if (ValideringAvEntities.KorrektNamn(namn) && ValideringAvEntities.KorrektURL(url)
                        && ValideringAvEntities.EnFrekvensArVald(frekvens) && ValideringAvEntities.KorrektKategori(kategori))
                    {
                        feedController.SkapaFeedObjekt(namn, url, frekvens, kategori);
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
            //podcastDataGridView.SelectedCells;
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
                if (ValideringAvEntities.KorrektNamn(kategoriNamn))
                {
                    //KategoriController.SkapaKategoriObjekt(kategoriNamn);
                    lstKategorier.Items.Add(kategoriNamn);
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

                lstKategorier.Items.Insert(lstKategorier.SelectedIndex, nyKategori);
                lstKategorier.Items.Remove(lstKategorier.SelectedItem);
                //KategoriController.UppdateraKategoriObjekt(kategoriNamn);
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

                        feedController.DeleteByKategori(kategoriNamn);
                    }
                }
            }
            catch (InvalidOperationException ex) //gör nytt eget exeption
            {
                MessageBox.Show("Kan inte ta bort valda poddar, välj kategori och försök igen");
            }
        }


      

    }
}
