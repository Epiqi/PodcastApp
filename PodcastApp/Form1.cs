using System;
using System.Windows.Forms;
using Entities;

namespace PodcastApp
{
    public partial class Podcast_app : Form
    {
        public Podcast_app()
        {
            InitializeComponent();
        }

        private void btnNyFeed_Click(object sender, System.EventArgs e)
        {   
            if (!String.IsNullOrEmpty(txtNamn.Text) && !String.IsNullOrEmpty(txtURL.Text) && !String.IsNullOrEmpty(cmbxFrekvens.Text) && !String.IsNullOrEmpty(cmbxKategori.Text)) 
            {
                //feedController.SkapaFeedObjekt(txtNamn.Text, txtURL.Text, cmbxFrekvens.Text, cmbxKategori.Text)
                
                string urlAdress = txtURL.Text;
                bool korrektUrl = ValideringAvEntities.KorrektURL(urlAdress);

                if (korrektUrl)
                {
                    System.Console.WriteLine(urlAdress);
                }
                else
                {
                    //throw new Exception
                }
            }
            

            bool enFrekvensArVald = Int32.TryParse(cmbxFrekvens.Text, out int frekvens);
            if (enFrekvensArVald)
            {
                Console.WriteLine(" " + frekvens);
            }
            else
            {
                //throw new Exception
            }

            if (!String.IsNullOrEmpty(txtValdKategori.Text))
            {
                string enKategori = txtValdKategori.Text;
                bool enKategoriArVald = ValideringAvEntities.KorrektKategori(enKategori);
                if (enKategoriArVald)
                {

                }
                else
                {

                }
            }
        }
    }
}
