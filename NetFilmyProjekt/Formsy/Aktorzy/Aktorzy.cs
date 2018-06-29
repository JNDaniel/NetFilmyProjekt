using NetFilmyProjekt.Formsy;
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
    public partial class Aktorzy : Form
    {
        public Aktorzy()
        {
            InitializeComponent();
        }

        public static int aktorId
        {
            get;
            set;
        }
        private void Aktorzy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Aktor' table. You can move, or remove it, as needed.
            this.aktorTableAdapter.Fill(this.dataSet1.Aktor);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Aktor"].Rows.IndexOf(findRow);
                try
                {
                    int id = aktorTableAdapter.GetData().ElementAt(rowIndex).aktor_id;
                    Aktor toChange = context.Aktor.FirstOrDefault(k => k.aktor_id == id);
                    imieTxt.Text = toChange.imie;
                    nazwiskoTxt.Text = toChange.nazwisko;
                    narodowoscTxt.Text = toChange.narodowosc;
                    dataUrTxt.Text = toChange.data_urodzenia;
                }
                catch(System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }        
            }
        }

        private void zmienBtn_Click(object sender, EventArgs e)
        {
            if(imieTxt.Text != "" && nazwiskoTxt.Text != "")
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    BindingManagerBase bm = null;
                    bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                    DataRow findRow = ((DataRowView)bm.Current).Row;
                    int rowIndex = dataSet1.Tables["Aktor"].Rows.IndexOf(findRow);
                    int id = aktorTableAdapter.GetData().ElementAt(rowIndex).aktor_id;
                    Aktor toChange = context.Aktor.FirstOrDefault(k => k.aktor_id == id);
                    toChange.imie = imieTxt.Text;
                    toChange.nazwisko = nazwiskoTxt.Text;
                    toChange.narodowosc = narodowoscTxt.Text;
                    toChange.data_urodzenia = dataUrTxt.Text;
                    context.SaveChanges();
                    this.aktorTableAdapter.Fill(this.dataSet1.Aktor);
                }
            }
            else
            {
                MessageBox.Show("Imie i nazwisko nie mogą być puste");
            }

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (imieTxt.Text != "" && nazwiskoTxt.Text != "")
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    Aktor toChange = new Aktor();
                    toChange.imie = imieTxt.Text;
                    toChange.nazwisko = nazwiskoTxt.Text;
                    toChange.narodowosc = narodowoscTxt.Text;
                    toChange.data_urodzenia = dataUrTxt.Text;
                    context.Aktor.Add(toChange);
                    context.SaveChanges();
                    this.aktorTableAdapter.Fill(this.dataSet1.Aktor);
                    MessageBox.Show("Pomyślnie dodano nowego aktora");
                    imieTxt.Text = "";
                    nazwiskoTxt.Text = "";
                    narodowoscTxt.Text = "";
                    dataUrTxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Imie i nazwisko nie mogą być puste");
            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Aktor"].Rows.IndexOf(findRow);
                int id = aktorTableAdapter.GetData().ElementAt(rowIndex).aktor_id;
                Aktor toChange = context.Aktor.FirstOrDefault(k => k.aktor_id == id);
                context.Aktor.Remove(toChange);
                try
                {
                    context.SaveChanges();
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    this.aktorTableAdapter.Fill(this.dataSet1.Aktor);
                    MessageBox.Show("Poprawnie usunięto");
                    imieTxt.Text = "";
                    nazwiskoTxt.Text = "";
                    narodowoscTxt.Text = "";
                    dataUrTxt.Text = "";
                }
                catch(System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void filmyBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                if(dataGridView1.SelectedCells.Count == 0 )
                {
                    MessageBox.Show("Brak zaznaczenia");
                    return;
                }
                BindingManagerBase bm = null;
                bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Aktor"].Rows.IndexOf(findRow);
                try
                {
                    int id = aktorTableAdapter.GetData().ElementAt(rowIndex).aktor_id;
                    Aktor toChange = context.Aktor.FirstOrDefault(k => k.aktor_id == id);
                    foreach(Film f in toChange.Film)
                    {
                        Console.WriteLine(f.tytul);
                    }
                    aktorId = id;
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Hide();
                Form filmy = new FilmyAktora();
                filmy.ShowDialog();
                this.Show();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
