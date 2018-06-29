using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFilmyProjekt.Formsy.Rezyserzy
{
    public partial class Filmy_rezysera : Form
    {
        public Filmy_rezysera()
        {
            InitializeComponent();
        }
        private void Filmy_rezysera_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Film' table. You can move, or remove it, as needed.
            using (filmdbEntities context = new filmdbEntities())
            {
                Rezyser r = context.Rezyser.FirstOrDefault(a => a.rezyser_id == Rezyserzy.idRezysera);
                directorFilms.DataSource = r.Film.ToList();
            }
            this.filmTableAdapter.Fill(this.dataSet1.Film);


        }
        private void usunBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                Film toDelete = null;
                for (int index = 0; index < directorFilms.SelectedRows.Count; index++)
                {
                    var selectedRow = directorFilms.SelectedRows[index];
                    toDelete = context.Film.Attach((Film)selectedRow.DataBoundItem);
                }
                Rezyser a = context.Rezyser.Find(Rezyserzy.idRezysera);
                a.Film.Remove(toDelete);
                context.SaveChanges();
                directorFilms.DataSource = a.Film.ToList();
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = allFilmsGrid.BindingContext[allFilmsGrid.DataSource, allFilmsGrid.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Film"].Rows.IndexOf(findRow);
                try
                {
                    int id = filmTableAdapter.GetData().ElementAt(rowIndex).film_id;
                    Film toAdd = context.Film.FirstOrDefault(k => k.film_id == id);

                    Rezyser a = context.Rezyser.Find(Rezyserzy.idRezysera);

                    if (!a.Film.Contains(toAdd))
                    {
                        a.Film.Add(toAdd);
                        context.SaveChanges();
                        directorFilms.DataSource = a.Film.ToList();
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

        private void directorFilms_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
