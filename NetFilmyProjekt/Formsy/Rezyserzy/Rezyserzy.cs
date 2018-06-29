//using System;
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
    public partial class Rezyserzy : Form
    {
        public static int idRezysera
        {
        get;
        set;
        }
        public Rezyserzy()
        {
            InitializeComponent();
        }

        private void Rezyserzy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Rezyser' table. You can move, or remove it, as needed.
            this.rezyserTableAdapter.Fill(this.dataSet1.Rezyser);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Rezyser"].Rows.IndexOf(findRow);
                try
                {
                    int id = rezyserTableAdapter.GetData().ElementAt(rowIndex).rezyser_id;
                    Rezyser toChange = context.Rezyser.Find(id);
                    imieTxt.Text = toChange.imie;
                    nazwiskoTxt.Text = toChange.nazwisko;
                    narodowoscTxt.Text = toChange.narodowosc;
                    dataUrTxt.Text = toChange.data_urodzenia;
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void zmienBtn_Click(object sender, EventArgs e)
        {
            if (imieTxt.Text != "" && nazwiskoTxt.Text != "")
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    BindingManagerBase bm = null;
                    bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                    DataRow findRow = ((DataRowView)bm.Current).Row;
                    int rowIndex = dataSet1.Tables["Rezyser"].Rows.IndexOf(findRow);
                    int id = rezyserTableAdapter.GetData().ElementAt(rowIndex).rezyser_id;
                    Rezyser toChange = context.Rezyser.Find(id);
                    toChange.imie = imieTxt.Text;
                    toChange.nazwisko = nazwiskoTxt.Text;
                    toChange.narodowosc = narodowoscTxt.Text;
                    toChange.data_urodzenia = dataUrTxt.Text;
                    context.SaveChanges();
                    this.rezyserTableAdapter.Fill(this.dataSet1.Rezyser);
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
                    Rezyser toChange = new Rezyser();
                    toChange.imie = imieTxt.Text;
                    toChange.nazwisko = nazwiskoTxt.Text;
                    toChange.narodowosc = narodowoscTxt.Text;
                    toChange.data_urodzenia = dataUrTxt.Text;
                    context.Rezyser.Add(toChange);
                    context.SaveChanges();
                    this.rezyserTableAdapter.Fill(this.dataSet1.Rezyser);
                    MessageBox.Show("Pomyślnie dodano nowego reżysera");
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
                int rowIndex = dataSet1.Tables["Rezyser"].Rows.IndexOf(findRow);
                int id = rezyserTableAdapter.GetData().ElementAt(rowIndex).rezyser_id;
                Rezyser toChange = context.Rezyser.Find(id);
                context.Rezyser.Remove(toChange);
                try
                {
                    context.SaveChanges();
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    this.rezyserTableAdapter.Fill(this.dataSet1.Rezyser);
                    MessageBox.Show("Poprawnie usunięto");
                    imieTxt.Text = "";
                    nazwiskoTxt.Text = "";
                    narodowoscTxt.Text = "";
                    dataUrTxt.Text = "";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void filmyBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Brak zaznaczenia");
                return;
            }
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Rezyser"].Rows.IndexOf(findRow);
                try
                {
                    int id = rezyserTableAdapter.GetData().ElementAt(rowIndex).rezyser_id;
                    idRezysera = id;
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            this.Hide();
            Form filmyRezysera = new Filmy_rezysera();
            filmyRezysera.ShowDialog();
            this.Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
