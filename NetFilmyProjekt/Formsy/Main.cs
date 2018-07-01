using NetFilmyProjekt.Formsy;
using NetFilmyProjekt.Formsy.Filmy;
using NetFilmyProjekt.Formsy.Rezyserzy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFilmyProjekt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmdbDataSet.Film' table. You can move, or remove it, as needed.
            //this.filmTableAdapter.Fill(this.filmdbDataSet.Film);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kraje = new Kraje();
            kraje.ShowDialog();
            this.Show();


        }

        private void aktorzyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form aktorzy = new Aktorzy();
            aktorzy.ShowDialog();
            this.Show();
        }

        private void rezyserzyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form rezyserzy = new Rezyserzy();
            rezyserzy.ShowDialog();
            this.Show();
            
        }

        private void filmyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form filmy = new Filmy();
            filmy.ShowDialog();
            this.Show();
        }

        private void genresBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form gatunki = new Gatunki();
            gatunki.ShowDialog();
            this.Show();
        }
    }
}
