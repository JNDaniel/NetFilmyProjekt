namespace NetFilmyProjekt.Formsy
{
    partial class FilmyAktora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.FilmTableAdapter();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jezykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.boxofficeDataGridViewTextBoxColumn,
            this.jezykDataGridViewTextBoxColumn,
            this.rokprodDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(252, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dataSet1;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "film_id";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "film_id";
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boxofficeDataGridViewTextBoxColumn
            // 
            this.boxofficeDataGridViewTextBoxColumn.DataPropertyName = "box_office";
            this.boxofficeDataGridViewTextBoxColumn.HeaderText = "box_office";
            this.boxofficeDataGridViewTextBoxColumn.Name = "boxofficeDataGridViewTextBoxColumn";
            // 
            // jezykDataGridViewTextBoxColumn
            // 
            this.jezykDataGridViewTextBoxColumn.DataPropertyName = "jezyk";
            this.jezykDataGridViewTextBoxColumn.HeaderText = "jezyk";
            this.jezykDataGridViewTextBoxColumn.Name = "jezykDataGridViewTextBoxColumn";
            // 
            // rokprodDataGridViewTextBoxColumn
            // 
            this.rokprodDataGridViewTextBoxColumn.DataPropertyName = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn.HeaderText = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn.Name = "rokprodDataGridViewTextBoxColumn";
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            // 
            // FilmyAktora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmyAktora";
            this.Text = "FilmyAktora";
            this.Load += new System.EventHandler(this.FilmyAktora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DataSet1TableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jezykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
    }
}