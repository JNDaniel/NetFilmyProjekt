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
    public partial class Kraje : Form
    {
        public Kraje()
        {
            InitializeComponent();
        }

        private void kraje_Load(object sender, EventArgs e)
        {
            this.krajTableAdapter.Fill(this.dataSet1.Kraj);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (!krajText.Equals(""))
            {
                using(filmdbEntities context = new filmdbEntities())
                {
                    Kraj k = new Kraj();
                    k.nazwa = krajText.Text;
                    context.Kraj.Add(k);
                    try
                    {
                        context.SaveChanges();
                        this.krajTableAdapter.Fill(this.dataSet1.Kraj);
                        MessageBox.Show("Poprawnie wstawiono " + k.nazwa);
                    }
                    catch(System.Data.Entity.Infrastructure.DbUpdateException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        krajText.Text = "";
                    } 
                }
                
                
            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {

            using (filmdbEntities context = new filmdbEntities())
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int id = krajTableAdapter.GetData().ElementAt(rowIndex).kraj_id;
                Console.WriteLine(krajTableAdapter.GetData().ElementAt(rowIndex).kraj_id);
                Kraj toDelete = context.Kraj.FirstOrDefault(k => k.kraj_id == id);
                Console.WriteLine(toDelete.nazwa);
                context.Kraj.Remove(toDelete);
                context.SaveChanges();
                dataGridView1.Rows.RemoveAt(rowIndex);
                this.krajTableAdapter.Fill(this.dataSet1.Kraj);

                 MessageBox.Show("Poprawnie usunięto " + toDelete.nazwa);
            }

        }


        private void dataGridView1_DataBindingComplete(object sender,
            DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int id = krajTableAdapter.GetData().ElementAt(rowIndex).kraj_id;
                Kraj toChange = context.Kraj.FirstOrDefault(k => k.kraj_id == id);
                krajText.Text = toChange.nazwa;
            }
                
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if(krajText.Text != "")
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    int id = krajTableAdapter.GetData().ElementAt(rowIndex).kraj_id;
                    Kraj toChange = context.Kraj.FirstOrDefault(k => k.kraj_id == id);
                    toChange.nazwa = krajText.Text;
                    context.SaveChanges();
                    this.krajTableAdapter.Fill(this.dataSet1.Kraj);
                }
            }
            else
            {
                MessageBox.Show("Nie możesz zmienić na pustą nazwę");
            }
            

        }
    }
}
