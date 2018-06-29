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
            //this.filmTableAdapter.Fill(this.dataSet1.Film);
            using (filmdbEntities context = new filmdbEntities())
            {
                Aktor a = context.Aktor.FirstOrDefault(k => k.aktor_id == Aktorzy.aktorId);
                aktorsFilmGrid.DataSource = a.Film.ToList();
            }
            this.filmTableAdapter.Fill(this.dataSet1.Film);

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
                   
                    Aktor a = context.Aktor.FirstOrDefault(k => k.aktor_id == Aktorzy.aktorId);

                    if (!a.Film.Contains(toAdd))
                    {
                        a.Film.Add(toAdd);
                        context.SaveChanges();
                        aktorsFilmGrid.DataSource = a.Film.ToList();
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
                Film toDelete = null;
                for (int index = 0; index < aktorsFilmGrid.SelectedRows.Count; index++)
                {
                    var selectedRow = aktorsFilmGrid.SelectedRows[index];
                    toDelete = context.Film.Attach((Film)selectedRow.DataBoundItem);
                }
                Aktor a = context.Aktor.FirstOrDefault(k => k.aktor_id == Aktorzy.aktorId);  
                a.Film.Remove(toDelete);
                context.SaveChanges();
                aktorsFilmGrid.DataSource = a.Film.ToList();
            }
        }


        

        private void allFilmsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

  
 }

