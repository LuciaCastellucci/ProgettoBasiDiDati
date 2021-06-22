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
    public partial class Classifiche : Form
    {
        public Classifiche()
        {
            InitializeComponent();
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void classificheView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classificheView.Visible = true;
        }

        private void filmButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from v in db.VISIONEs
                       from f in db.FILMs
                       where f.codFilm == v.codFilm
                       group v by new { v.codFilm, f.titolo, f.vistoCensura, f.durataComplessiva } into n
                       orderby n.Key.codFilm.Count() descending
                       select new
                       {
                           n.Key.codFilm,
                           n.Key.titolo,
                           n.Key.durataComplessiva,
                           n.Key.vistoCensura,
                           numeroVisioni = n.Key.codFilm.Count()
                       }).Take(10);

            classificheView.DataSource = res;
        }

        private void serieButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from v in db.VISIONEs
                       from s in db.SERIEs
                       from ep in db.EPISODIOs
                       where v.codEpisodio == ep.codEpisodio && ep.codiceSerie == s.codiceSerie
                       group v by new { v.EPISODIO.codiceSerie, s.titolo } into n
                       orderby (n.Count() / (from epi in db.EPISODIOs
                                            where epi.codiceSerie == n.Key.codiceSerie
                                            select epi).Count()) descending
                       select new
                       {
                           n.Key.codiceSerie,
                           n.Key.titolo,
                           numeroVisioni = n.Count()/(from epi in db.EPISODIOs
                                                      where epi.codiceSerie == n.Key.codiceSerie
                                                      select epi).Count()
                       }).Take(10);

            classificheView.DataSource = res;
        }

        private void utentiButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from v in db.VISIONEs
                      group v by new { v.nomeAccount, v.nomeUtente } into g
                      orderby g.Sum(x => x.minutoArrivo.TotalHours) descending
                      select new
                      {
                          g.Key.nomeAccount,
                          g.Key.nomeUtente,
                          oreTotali = g.Sum(x => x.minutoArrivo.TotalHours)
                      }).Take(10);
            classificheView.DataSource = res;
        }
    }
}
