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
    public partial class Statistiche : Form
    {
        public Statistiche()
        {
            InitializeComponent();
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void utentiButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from u in db.UTENTEs
                      select new
                      {
                          NumeroUtentiPerAccount = (from ut in db.UTENTEs
                                          group ut by new {ut.nomeAccount} into m
                                          select m.Count()).Average()
                      }).Take(1);

            medioView.DataSource = res;
        }

        private void statisticheView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            statisticheView.Visible = true;
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from a in db.ACCOUNTs
                      select a.nomeAccount).Count();

            accountBox.Text = res.ToString();
        }

        private void serieButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from s in db.SERIEs
                       orderby s.durata descending
                       select s).Take(1);
            statisticheView.DataSource = res;
        }

        private void incassoButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from a in db.ABBONAMENTOs
                       where a.dataInizio.Month == DateTime.Today.Month && a.dataInizio.Year == DateTime.Today.Year
                       select a).Count();

            iscrizioniBox.Text = res.ToString();
        }

        private void orarioButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from v in db.VISIONEs
                       group v by new { v.ora } into o
                       orderby o.Count() descending
                       select o.Key).Take(1);

            orarioView.DataSource = res;
        }

        private void incassoButton_Click_1(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from pag in db.PAGAMENTOs
                       select new
                       {
                           IncassoAnnuo = (from p in db.PAGAMENTOs
                                           where DateTime.Today.Year == p.dataPagamento.Year
                                           select new { p.importo }).Sum(q => q.importo)
                       }).Take(1);
            incassoView.DataSource = res;
        }
    }
}
