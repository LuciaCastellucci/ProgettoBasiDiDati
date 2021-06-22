using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreaminVideoApplication
{
    public partial class Serie : Form
    {
        public Serie()
        {
            InitializeComponent();
        }

        private void cercaButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from s in db.SERIEs
                      from ep in db.EPISODIOs
                      where s.titolo == titoloBox.Text && ep.codiceSerie == s.codiceSerie
                      select ep;

            serieView.DataSource = res;
        }

        private void visualizzaButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from s in db.SERIEs
                      orderby s.titolo
                      select s;

            serieView.DataSource = res;
        }

        private void serieView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            serieView.Visible = true;
        }

        private void cercaGenereButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from ser in db.SERIEs
                      from ep in db.EPISODIOs
                      from g in db.GENEREs
                      from a in db.appartenere_eps
                      where g.descrizione == genereBox.Text && a.codGenere == g.codGenere && a.codEpisodio == ep.codEpisodio && ep.codiceSerie == ser.codiceSerie
                      group ser by new { ser.codiceSerie, ser.titolo, ser.durata } into x
                      select new
                      {
                          x.Key.codiceSerie,
                          x.Key.titolo,
                          x.Key.durata
                      };


            serieView.DataSource = res;
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void dettagliButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from s in db.SERIEs
                      where s.titolo == dettagliBox.Text
                      select new
                      {
                          s.codiceSerie,
                          s.titolo,
                          numeroStagioni = (from st in db.STAGIONEs
                                            where st.codiceSerie == s.codiceSerie
                                            select st).Count(),
                          numeroEpisodi = (from ep in db.EPISODIOs
                                           where ep.codiceSerie == s.codiceSerie
                                           select ep).Count()
                      };

            serieView.DataSource = res;

        }
    }
}
