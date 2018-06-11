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
    public partial class kraje : Form
    {
        public kraje()
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
                    context.SaveChanges();
                    this.krajTableAdapter.Fill(this.dataSet1.Kraj);
                    krajText.Text = "";
                    MessageBox.Show("Poprawnie wstawiono " + k.nazwa);
                }
                
                
            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            

            using (filmdbEntities context = new filmdbEntities())
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int id = krajTableAdapter.GetData().ElementAt(rowIndex).kraj_id;
                Kraj toDelete = context.Kraj.FirstOrDefault(k => k.kraj_id == id);
                Console.WriteLine(toDelete);
                //context.Kraj.Remove(toDelete);
                // context.SaveChanges();
                //dataGridView1.Rows.RemoveAt(rowIndex);
                this.krajTableAdapter.Fill(this.dataSet1.Kraj);
                // MessageBox.Show("Poprawnie usunięto " + toDelete.nazwa);
            }




        }
    }
}
