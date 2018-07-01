using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFilmyProjekt.Formsy.Filmy
{
    public partial class EdycjaGatunkow : Form
    {
        public EdycjaGatunkow()
        {
            InitializeComponent();
        }

        private void EdycjaGatunkow_Load(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                Film toChange = context.Film.Find(Filmy.filmId);
                var genres = context.Gatunek;
                foreach (Gatunek g in genres)
                {
                    filmgenres.Items.Add(g.nazwa);
                }

                foreach (Gatunek g in toChange.Gatunek)
                {
                    Gatunek item = context.Gatunek.Find(g.gatunek_id);
                    filmgenres.Items.Add(g);
                    filmgenres.SetItemChecked(filmgenres.Items.IndexOf(item.nazwa), true);
                }
            }
        }

        private void filmgenres_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            String actualGenre = filmgenres.Items[e.Index].ToString();
            Console.WriteLine("actualGenre " + actualGenre);

            using (filmdbEntities context = new filmdbEntities())
            {
                Film toChange = context.Film.Find(Filmy.filmId);
                Gatunek selected = context.Gatunek.FirstOrDefault(g => g.nazwa == actualGenre);
                Console.WriteLine("Znaleziono gatunek " + selected.nazwa + " o id " + selected.gatunek_id);
                if (e.NewValue.Equals(CheckState.Checked))
                {
                    Console.WriteLine("Dodanie gatunku " + selected.nazwa + " o id " + selected.gatunek_id);
                    toChange.Gatunek.Add(selected);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Usuniecie gatunku " + selected.nazwa + " o id " + selected.gatunek_id);
                    toChange.Gatunek.Remove(selected);
                    context.SaveChanges();
                }

            }
        }
    }
}
