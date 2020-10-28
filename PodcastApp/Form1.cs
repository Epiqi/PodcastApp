using System;
using System.Windows.Forms;
using BL.Validering;
using BL.Controllers;
using System.Collections.Generic;

namespace PodcastApp
{
    public partial class Podcast_app : Form
    {
        FeedController feedController;
        public Podcast_app()
        {
            InitializeComponent();
            feedController = new FeedController();
        }

        private void btnNyFeed_Click(object sender, System.EventArgs e)
        {
           /* try
            {
                string avsnitt = ""; //Hämta värde från rss-feed.
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
                        //När vi fått URL måste vi läsa in och hämta antal avsnitt innan ett objekt kan skapas
                        //feedController.SkapaFeedObjekt(namn, url, frekvens, kategori);

                        
                    }
                }
                else
                {
                    MessageBox.Show("Det måste finnas värden i alla rutor");
                }

            }
            catch( UserException exception)
            {
                MessageBox.Show(exception.Message);
            }*/

           //Hur man lägger till en rad i Dataviewgrid.
             
            string[] row1 = new string[] { "avsnitt1", "namn", "url", "frekvens", "kategori" };
            string[] row2 = new string[] { "avsnitt2", "namn", "url", "frekvens", "kategori" };

            List<Object> rows = new List<Object> { row1, row2 };
            foreach (string[] rowArray in rows)
            {
                podcastDataGridView.Rows.Add(rowArray);
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

                        podcastDataGridView.Rows.RemoveAt(valtIndex);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Kan inte ta bort vald rad, välj raden och försök igen");
            }
        }

    }
}
