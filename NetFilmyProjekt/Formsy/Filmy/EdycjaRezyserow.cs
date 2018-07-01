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
    public partial class EdycjaRezyserow : Form
    {
        public EdycjaRezyserow()
        {
            InitializeComponent();
        }

        private void EdycjaRezyserow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Rezyser' table. You can move, or remove it, as needed.
            this.rezyserTableAdapter.Fill(this.dataSet1.Rezyser);
            using (filmdbEntities context = new filmdbEntities())
            {
                Film a = context.Film.FirstOrDefault(k => k.film_id == Filmy.filmId);
                directorsInFilm.DataSource = a.Rezyser.ToList();
            }

        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                Rezyser toDelete = null;
                for (int index = 0; index < directorsInFilm.SelectedRows.Count; index++)
                {
                    var selectedRow = directorsInFilm.SelectedRows[index];
                    toDelete = context.Rezyser.Attach((Rezyser)selectedRow.DataBoundItem);
                }
                Film a = context.Film.FirstOrDefault(k => k.film_id == Filmy.filmId);
                a.Rezyser.Remove(toDelete);
                context.SaveChanges();
                directorsInFilm.DataSource = a.Rezyser.ToList();
            }

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = allDirectors.BindingContext[allDirectors.DataSource, allDirectors.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Rezyser"].Rows.IndexOf(findRow);
                try
                {
                    int id = rezyserTableAdapter.GetData().ElementAt(rowIndex).rezyser_id;
                    Rezyser toAdd = context.Rezyser.FirstOrDefault(k => k.rezyser_id == id);

                    Film a = context.Film.FirstOrDefault(k => k.film_id == Filmy.filmId);

                    if (!a.Rezyser.Contains(toAdd))
                    {
                        a.Rezyser.Add(toAdd);
                        context.SaveChanges();
                        directorsInFilm.DataSource = a.Rezyser.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Ten reżyser już jest w tym filmie");
                    }
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void directorsInFilm_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
