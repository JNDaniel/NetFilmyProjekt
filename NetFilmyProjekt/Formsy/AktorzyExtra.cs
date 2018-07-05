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
    public partial class AktorzyExtra : Form
    {
        public AktorzyExtra()
        {
            InitializeComponent();
        }
        static int idGatunku
        {
            get;
            set;
        }
        static short rok
        {
            get;
            set;
        }

        private void AktorzyExtra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Gatunek' table. You can move, or remove it, as needed.
            this.gatunekTableAdapter.Fill(this.dataSet1.Gatunek);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void genresGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actorsList.DataSource = null;
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = genresGW.BindingContext[genresGW.DataSource, genresGW.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Gatunek"].Rows.IndexOf(findRow);
                try
                {
                    int id = gatunekTableAdapter.GetData().ElementAt(rowIndex).gatunek_id;
                    idGatunku = id;
                    var films = context.Film.Where(f => f.Gatunek.Any(g => g.gatunek_id == id)).ToList();
                    HashSet<Int16?> years = new HashSet<Int16?>();
                    foreach(Film f in films)
                    {
                        years.Add(f.rok_prod);
                    }
                    yearsList.DataSource = years.ToList();
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void yearsGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void genresGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            genresGW.ClearSelection();
        }

        private void yearsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chosenYear = int.Parse(yearsList.SelectedItem.ToString());
            
            using (filmdbEntities db = new filmdbEntities())
            {
                //var actors = db.Aktor.Intersect(db.Film.Where(f => f.rok_prod == chosenYear).Intersect(db.Gatunek.Where(g => g.gatunek_id == idGatunku)));
                var actors = db.Aktor.SqlQuery(String.Format("select distinct * from Aktor a join film_aktor fa on a.aktor_id = fa.aktor_id join Film f on fa.film_id = f.film_id join film_gatunek fg on f.film_id = fg.film_id where fg.gatunek_id = {0} and f.rok_prod={1}",idGatunku,chosenYear)).ToList();
                actorsList.DataSource = actors;
             //
            }

        }
    }
}
