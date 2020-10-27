using System;
using System.Windows.Forms;
using BL.Validering;
using BL.Controllers;




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
                        feedController.SkapaFeedObjekt(txtNamn.Text, txtURL.Text, cmbxFrekvens.Text, cmbxKategori.Text);
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
            }
        }
    }
}
