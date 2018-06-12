using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFilmyProjekt.Formsy
{
    public partial class FilmyAktora : Form
    {
        public FilmyAktora()
        {
            InitializeComponent();
        }

        private void FilmyAktora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.dataSet1.Film);

        }
    }
}
