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
    public partial class Utenti : Form
    {
        public Utenti()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            utentiView.Visible = true;
        }

        private void visualizzaButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from u in db.UTENTEs
                      select new
                      {
                          u.nomeAccount,
                          u.nomeUtente
                      };

            utentiView.DataSource = res;
        }

        private void cercaButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from u in db.UTENTEs
                      where u.nomeAccount == accountBox.Text
                      select new
                      {
                          u.nomeAccount,
                          u.nomeUtente
                      };

            utentiView.DataSource = res;
        }

        private void utenteButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from u in db.UTENTEs
                      where u.nomeUtente == utenteBox.Text
                      select new
                      {
                          u.nomeAccount,
                          u.nomeUtente
                      };

            utentiView.DataSource = res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
