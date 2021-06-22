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
    public partial class Inserimento : Form
    {
        public Inserimento()
        {
            InitializeComponent();
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void inserisciButton_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            TITOLARE_ACCOUNT titolare = new TITOLARE_ACCOUNT
            {
                CF = cfBox.Text,
                nomeAccount = nomeBox.Text,
                indirizzo = indirizzoBox.Text,
                città = cittaBox.Text,
                numCartaDiCredito = cartaBox.Text
            };

            db.TITOLARE_ACCOUNTs.InsertOnSubmit(titolare);

            ACCOUNT account = new ACCOUNT
            {
                nomeAccount = nomeBox.Text,
                password = passwordBox.Text
            };

            db.ACCOUNTs.InsertOnSubmit(account);

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
            indirizzoBox.Clear();
            cittaBox.Clear();
            cartaBox.Clear();
            passwordBox.Clear();
            accountLabel.Text = "Inserimento completato";
        }

        private void inserisci2Button_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = (from u in db.UTENTEs
                       where u.nomeAccount == account2Box.Text
                       select u).Count();
            if (res < 5)
            {
                UTENTE utente = new UTENTE
                {
                    nomeAccount = account2Box.Text,
                    nomeUtente = utenteBox.Text
                };

                db.UTENTEs.InsertOnSubmit(utente);
                account2Box.Clear();
                utenteBox.Clear();
                errorLabel.Text = "Inserimento completato";
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception er)
                {
                    Console.WriteLine(er);
                }

            }
            else
            {
                errorLabel.Text = "Raggiunto il limite massimo di utenti";
            }
            
        }

        private void inserisci3Button_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            double val = Convert.ToDouble(prezzoBox.Text);
            ABBONAMENTO abb = new ABBONAMENTO
            {
                codAbbonamento = abbBox.Text,
                dataInizio = DateTime.Today,
                prezzo = val,
                CF = cfAbbBox.Text
            };
            db.ABBONAMENTOs.InsertOnSubmit(abb);

            try
            {
                db.SubmitChanges();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }

            abbBox.Clear();
            prezzoBox.Clear();
            cfAbbBox.Clear();
            abbLabel.Text = "Inserimento completato";
        }
    }
}
