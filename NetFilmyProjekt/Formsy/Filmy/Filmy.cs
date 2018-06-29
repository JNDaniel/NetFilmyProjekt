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
                    Film toChange = context.Film.Find(id);

                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
