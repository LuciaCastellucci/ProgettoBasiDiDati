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
    public partial class Visioni : Form
    {
        public Visioni()
        {
            InitializeComponent();
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClassesStreamingVideoDataContext db = new DataClassesStreamingVideoDataContext();

            var res = from v in db.VISIONEs
                      where DateTime.Today == v.data
                      orderby v.ora descending
                      select v;
            visioniView.DataSource = res;
        }
    }
}
