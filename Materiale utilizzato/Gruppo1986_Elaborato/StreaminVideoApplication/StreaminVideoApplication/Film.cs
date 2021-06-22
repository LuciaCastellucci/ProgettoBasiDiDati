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
    public partial class Film : Form
    {
        public Film()
        {
            InitializeComponent();
        }

        private void filmView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filmView.Visible = true;
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void visualizzaButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from f in db.FILMs
                      orderby f.titolo
                      select f;


            filmView.DataSource = res;
        }

        private void cercaButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from f in db.FILMs
                      where f.titolo == titoloBox.Text
                      select f;


            filmView.DataSource = res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from f in db.FILMs
                      from a in db.appartenere_films
                      from g in db.GENEREs
                      where g.descrizione == genereBox.Text && a.codGenere == g.codGenere && f.codFilm == a.codFilm
                      select f;

            filmView.DataSource = res;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
