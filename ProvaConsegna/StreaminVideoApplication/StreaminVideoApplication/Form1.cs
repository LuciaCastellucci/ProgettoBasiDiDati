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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void filmButton_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Show();
            this.Hide();
        }

        private void serieButton_Click(object sender, EventArgs e)
        {
            Serie serie = new Serie();
            serie.Show();
            this.Hide();
        }

        private void utentiButton_Click(object sender, EventArgs e)
        {
            Utenti utenti = new Utenti();
            utenti.Show();
            this.Hide();
        }

        private void statisticheButton_Click(object sender, EventArgs e)
        {
            Statistiche statistiche = new Statistiche();
            statistiche.Show();
            this.Hide();
        }

        private void classificheButon_Click(object sender, EventArgs e)
        {
            Classifiche classifiche = new Classifiche();
            classifiche.Show();
            this.Hide();
        }

        private void visioniButton_Click(object sender, EventArgs e)
        {
            Visioni visioni = new Visioni();
            visioni.Show();
            this.Hide();
        }

        private void inserimentoButton_Click(object sender, EventArgs e)
        {
            Inserimento ins = new Inserimento();
            ins.Show();
            this.Hide();
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            Rimuovere rim = new Rimuovere();
            rim.Show();
            this.Hide();
        }
    }
}
