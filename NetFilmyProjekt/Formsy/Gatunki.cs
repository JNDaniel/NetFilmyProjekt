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
    public partial class Gatunki : Form
    {
        public Gatunki()
        {
            InitializeComponent();
        }

        int idGatunku
        {
            set;
            get;
        }

        private void Gatunki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Gatunek' table. You can move, or remove it, as needed.
            this.gatunekTableAdapter.Fill(this.dataSet1.Gatunek);
        }

        private void genresGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            genresGW.ClearSelection();
        }

        private void genresGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                BindingManagerBase bm = null;
                bm = genresGW.BindingContext[genresGW.DataSource, genresGW.DataMember];
                DataRow findRow = ((DataRowView)bm.Current).Row;
                int rowIndex = dataSet1.Tables["Gatunek"].Rows.IndexOf(findRow);
                idGatunku = gatunekTableAdapter.GetData().ElementAt(rowIndex).gatunek_id;
                Gatunek toChange = context.Gatunek.Find(idGatunku);
                genreText.Text = toChange.nazwa;
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (!genreText.Text.Trim().Equals(""))
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    Gatunek toChange = context.Gatunek.Find(idGatunku);
                    toChange.nazwa = genreText.Text;
                    try
                    {
                        context.SaveChanges();
                        this.gatunekTableAdapter.Fill(this.dataSet1.Gatunek);
                    }
                    catch(System.Data.Entity.Infrastructure.DbUpdateException ex)
                    {
                        MessageBox.Show("Istnieje rekord o nazwie " + genreText.Text);
                    }
                    finally
                    {
                        genreText.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie możesz zmienić na pustą nazwę");
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (!genreText.Text.Trim().ToString().Equals(""))
            {
                using (filmdbEntities context = new filmdbEntities())
                {
                    Gatunek k = new Gatunek();
                    k.nazwa = genreText.Text;
                    context.Gatunek.Add(k);
                    try
                    {
                        context.SaveChanges();
                        this.gatunekTableAdapter.Fill(this.dataSet1.Gatunek);
                        MessageBox.Show("Poprawnie wstawiono " + k.nazwa);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                    {
                        MessageBox.Show("Rekord "+"\""+k.nazwa+"\""+" istnieje już w bazie");
                    }
                    finally
                    {
                        genreText.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Pusty gatunek");
                genreText.Text = "";
            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            using (filmdbEntities context = new filmdbEntities())
            {
                int rowIndex = genresGW.CurrentCell.RowIndex;
                Gatunek toDelete = context.Gatunek.Find(idGatunku);
                context.Gatunek.Remove(toDelete);
                context.SaveChanges();
                genresGW.Rows.RemoveAt(rowIndex);
                this.gatunekTableAdapter.Fill(this.dataSet1.Gatunek);

                MessageBox.Show("Poprawnie usunięto " + toDelete.nazwa);
            }
        }
    }
}
