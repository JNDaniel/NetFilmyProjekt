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
    public partial class EdycjaAktorow : Form
    {
        public EdycjaAktorow()
        {
            InitializeComponent();
        }

        private void EdycjaAktorow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Aktor' table. You can move, or remove it, as needed.
            this.aktorTableAdapter.Fill(this.dataSet1.Aktor);
            using (filmdbEntities context = new filmdbEntities())
            {
                Film a = context.Film.FirstOrDefault(k => k.film_id == Filmy.filmId);
                actorsInFilm.DataSource = a.Aktor.ToList();
            }

        }

        private void actorsInFilm_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = allActors.BindingContext[allActors.DataSource, allActors.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Aktor"].Rows.IndexOf(findRow);
                try
                {
                    int id = aktorTableAdapter.GetData().ElementAt(rowIndex).aktor_id;
                    Aktor toAdd = context.Aktor.FirstOrDefault(k => k.aktor_id == id);

                    Film a = context.Film.FirstOrDefault(k => k.film_id == Filmy.filmId);

                    if (!a.Aktor.Contains(toAdd))
                    {
                        a.Aktor.Add(toAdd);
                        context.SaveChanges();
                        actorsInFilm.DataSource = a.Aktor.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Ten aktor już jest w tym filmie");
                    }
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                Aktor toDelete = null;
                for (int index = 0; index < actorsInFilm.SelectedRows.Count; index++)
                {
                    var selectedRow = actorsInFilm.SelectedRows[index];
                    toDelete = context.Aktor.Attach((Aktor)selectedRow.DataBoundItem);
                }
                Film a = context.Film.FirstOrDefault(k => k.film_id == Filmy.filmId);
                a.Aktor.Remove(toDelete);
                context.SaveChanges();
                actorsInFilm.DataSource = a.Aktor.ToList();
            }
        }
    }
}
