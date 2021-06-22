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
    public partial class Rimuovere : Form
    {
        public Rimuovere()
        {
            InitializeComponent();
        }

        private void rimuoviButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var utenteDelate = from u in db.UTENTEs
                               where u.nomeAccount == account2Box.Text && u.nomeUtente == utenteBox.Text
                               select u;

            foreach( var ut in utenteDelate)
            {
                db.UTENTEs.DeleteOnSubmit(ut);
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }


            account2Box.Clear();
            utenteBox.Clear();
            utenteLabel.Text = "Utente rimosso correttamente";
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void rimuovi2Button_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var delateTitolare = from t in db.TITOLARE_ACCOUNTs
                                 where t.CF == cfBox.Text
                                 select t;
            var delateAccount = from a in db.ACCOUNTs
                                where a.nomeAccount == nomeBox.Text
                                select a;
            var delateAbb = from ab in db.ABBONAMENTOs
                            where ab.CF == cfBox.Text
                            select ab;
            var delateUtenti = from u in db.UTENTEs
                               where u.nomeAccount == nomeBox.Text
                               select u;

            foreach (var abb in delateAbb)
            {
                db.ABBONAMENTOs.DeleteOnSubmit(abb);
            }

            foreach(var tit in delateTitolare)
            {
                db.TITOLARE_ACCOUNTs.DeleteOnSubmit(tit);
            }

            foreach(var acc in delateAccount)
            {
                db.ACCOUNTs.DeleteOnSubmit(acc);
            }

            foreach(var ut in delateUtenti)
            {
                db.UTENTEs.DeleteOnSubmit(ut);
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }

            cfBox.Clear();
            nomeBox.Clear();
            accountLabel.Text = "Titolare rimosso correttamente";
        }

        private void rimuovi3Button_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var delateAbb = from ab in db.ABBONAMENTOs
                            where ab.codAbbonamento == codiceBox.Text
                            select ab;
            foreach (var abb in delateAbb)
            {
                db.ABBONAMENTOs.DeleteOnSubmit(abb);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
            codiceBox.Clear();
            abbLabel.Text = "Abbonamento rimosso correttamente";
        }
    }
}
