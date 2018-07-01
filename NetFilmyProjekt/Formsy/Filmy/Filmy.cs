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
    public partial class Filmy : Form
    {
        public Filmy()
        {
            InitializeComponent();
        }

        public static int filmId
        {
            get;
            set;
        }


        private void Filmy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.dataSet1.Film);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Film"].Rows.IndexOf(findRow);
                try
                {
                    int id = filmTableAdapter.GetData().ElementAt(rowIndex).film_id;
                    filmId = id;
                    Film toChange = context.Film.Find(filmId);

                    titleText.Text = toChange.tytul;
                    yearText.Text = toChange.rok_prod.ToString();
                    langText.Text = toChange.jezyk;
                    boxOfficeText.Text = toChange.box_office.ToString();

                    genreList.Items.Clear();
                    foreach (Gatunek g in toChange.Gatunek)
                    {
                        genreList.Items.Add(g);
                    }
                    actorsList.Items.Clear();
                    foreach (Aktor a in toChange.Aktor)
                    {
                        actorsList.Items.Add(a);
                    }
                    directorsList.Items.Clear();
                    foreach (Rezyser r in toChange.Rezyser)
                    {
                        directorsList.Items.Add(r);
                    }





                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                context.SaveChanges();
            }
        }



        private void genresEditClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.Hide();
                Form edycjaGatunkow = new EdycjaGatunkow();
                edycjaGatunkow.ShowDialog();
                this.Show();
                using (filmdbEntities context = new filmdbEntities())
                {
                    genreList.Items.Clear();
                    Film toChange = context.Film.Find(filmId);
                    foreach (Gatunek g in toChange.Gatunek)
                    {
                        Gatunek item = context.Gatunek.Find(g.gatunek_id);
                        genreList.Items.Add(g);
                        //filmgenres.SetItemChecked(filmgenres.Items.IndexOf(item.nazwa), true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak zaznaczenia");
            }
            

        }

        private void zmienBtnClick(object sender, EventArgs e)
        {
            if (titleText.Text != "")
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    BindingManagerBase bm = null;
                    bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                    DataRow findRow = ((DataRowView)bm.Current).Row;
                    int rowIndex = dataSet1.Tables["Film"].Rows.IndexOf(findRow);
                    int id = filmTableAdapter.GetData().ElementAt(rowIndex).film_id;
                    Film toChange = context.Film.FirstOrDefault(k => k.film_id == id);
                    toChange.tytul = titleText.Text;
                    toChange.rok_prod = short.Parse(yearText.Text);
                    toChange.jezyk = langText.Text;
                    toChange.box_office =  long.Parse(boxOfficeText.Text);
                    context.SaveChanges();
                    this.filmTableAdapter.Fill(this.dataSet1.Film);
                }
            }
            else
            {
                MessageBox.Show("Tytuł nie może być pusty");
            }
        }

        private void dodajBtnClick(object sender, EventArgs e)
        {
            if (titleText.Text != "")
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    Film toChange = new Film();
                    toChange.tytul = titleText.Text;
                    toChange.jezyk = langText.Text;
                    try
                    {
                        toChange.rok_prod = short.Parse(yearText.Text);
                        toChange.box_office = long.Parse(boxOfficeText.Text);
                        context.Film.Add(toChange);
                        context.SaveChanges();
                        this.filmTableAdapter.Fill(this.dataSet1.Film);
                        MessageBox.Show("Pomyślnie dodano nowy film");
                    }
                    catch(System.FormatException ex)
                    {
                        MessageBox.Show("Błąd formatu roku lub box office");
                        toChange = null;
                    }
                    titleText.Text = "";
                    yearText.Text = "";
                    langText.Text = "";
                    boxOfficeText.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tytuł nie może być pusty");
            }
        }

        private void usunBtnClick(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Film"].Rows.IndexOf(findRow);
                int id = filmTableAdapter.GetData().ElementAt(rowIndex).film_id;
                Film toChange = context.Film.FirstOrDefault(k => k.film_id == id);
                context.Film.Remove(toChange);
                try
                {
                    context.SaveChanges();
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    this.filmTableAdapter.Fill(this.dataSet1.Film);
                    MessageBox.Show("Poprawnie usunięto");
                    titleText.Text = "";
                    yearText.Text = "";
                    langText.Text = "";
                    boxOfficeText.Text = "";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void actorsEdit_Click(object sender, EventArgs e)
        {
           if(dataGridView1.SelectedRows.Count!=0)
            {
                this.Hide();
                Form edycjaAktorow = new EdycjaAktorow();
                edycjaAktorow.ShowDialog();
                this.Show();
                using (filmdbEntities context = new filmdbEntities())
                {
                    actorsList.Items.Clear();
                    Film toChange = context.Film.Find(filmId);
                    foreach (Aktor a in toChange.Aktor)
                    {
                        actorsList.Items.Add(a);
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak zaznaczenia");
            }
        }

        private void directorsEditClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.Hide();
                Form edycjaRezyserow = new EdycjaRezyserow();
                edycjaRezyserow.ShowDialog();
                this.Show();
                using (filmdbEntities context = new filmdbEntities())
                {
                    directorsList.Items.Clear();
                    Film toChange = context.Film.Find(filmId);
                    foreach (Rezyser r in toChange.Rezyser)
                    {
                        directorsList.Items.Add(r);
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak zaznaczenia");
            }
        }

     
    }
}
