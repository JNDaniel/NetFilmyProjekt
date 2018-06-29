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
            this.aktorsFilmGrid = new System.Windows.Forms.DataGridView();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jezykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.filmTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.FilmTableAdapter();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.allFilmsGrid = new System.Windows.Forms.DataGridView();
            this.filmidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxofficeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jezykDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokprodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.filmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usunBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aktorsFilmGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allFilmsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // aktorsFilmGrid
            // 
            this.aktorsFilmGrid.AllowUserToAddRows = false;
            this.aktorsFilmGrid.AllowUserToDeleteRows = false;
            this.aktorsFilmGrid.AllowUserToOrderColumns = true;
            this.aktorsFilmGrid.AutoGenerateColumns = false;
            this.aktorsFilmGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktorsFilmGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.boxofficeDataGridViewTextBoxColumn,
            this.jezykDataGridViewTextBoxColumn,
            this.rokprodDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn});
            this.aktorsFilmGrid.DataSource = this.filmBindingSource;
            this.aktorsFilmGrid.Location = new System.Drawing.Point(252, 33);
            this.aktorsFilmGrid.MultiSelect = false;
            this.aktorsFilmGrid.Name = "aktorsFilmGrid";
            this.aktorsFilmGrid.ReadOnly = true;
            this.aktorsFilmGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aktorsFilmGrid.Size = new System.Drawing.Size(546, 187);
            this.aktorsFilmGrid.TabIndex = 0;
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
            this.boxofficeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jezykDataGridViewTextBoxColumn
            // 
            this.jezykDataGridViewTextBoxColumn.DataPropertyName = "jezyk";
            this.jezykDataGridViewTextBoxColumn.HeaderText = "jezyk";
            this.jezykDataGridViewTextBoxColumn.Name = "jezykDataGridViewTextBoxColumn";
            this.jezykDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokprodDataGridViewTextBoxColumn
            // 
            this.rokprodDataGridViewTextBoxColumn.DataPropertyName = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn.HeaderText = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn.Name = "rokprodDataGridViewTextBoxColumn";
            this.rokprodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(92, 332);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 1;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // allFilmsGrid
            // 
            this.allFilmsGrid.AllowUserToAddRows = false;
            this.allFilmsGrid.AllowUserToDeleteRows = false;
            this.allFilmsGrid.AllowUserToOrderColumns = true;
            this.allFilmsGrid.AutoGenerateColumns = false;
            this.allFilmsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allFilmsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn1,
            this.boxofficeDataGridViewTextBoxColumn1,
            this.jezykDataGridViewTextBoxColumn1,
            this.rokprodDataGridViewTextBoxColumn1,
            this.tytulDataGridViewTextBoxColumn1});
            this.allFilmsGrid.DataSource = this.filmBindingSource2;
            this.allFilmsGrid.Location = new System.Drawing.Point(252, 256);
            this.allFilmsGrid.MultiSelect = false;
            this.allFilmsGrid.Name = "allFilmsGrid";
            this.allFilmsGrid.ReadOnly = true;
            this.allFilmsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allFilmsGrid.Size = new System.Drawing.Size(546, 187);
            this.allFilmsGrid.TabIndex = 2;
            this.allFilmsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allFilmsGrid_CellContentClick);
            // 
            // filmidDataGridViewTextBoxColumn1
            // 
            this.filmidDataGridViewTextBoxColumn1.DataPropertyName = "film_id";
            this.filmidDataGridViewTextBoxColumn1.HeaderText = "film_id";
            this.filmidDataGridViewTextBoxColumn1.Name = "filmidDataGridViewTextBoxColumn1";
            this.filmidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // boxofficeDataGridViewTextBoxColumn1
            // 
            this.boxofficeDataGridViewTextBoxColumn1.DataPropertyName = "box_office";
            this.boxofficeDataGridViewTextBoxColumn1.HeaderText = "box_office";
            this.boxofficeDataGridViewTextBoxColumn1.Name = "boxofficeDataGridViewTextBoxColumn1";
            this.boxofficeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // jezykDataGridViewTextBoxColumn1
            // 
            this.jezykDataGridViewTextBoxColumn1.DataPropertyName = "jezyk";
            this.jezykDataGridViewTextBoxColumn1.HeaderText = "jezyk";
            this.jezykDataGridViewTextBoxColumn1.Name = "jezykDataGridViewTextBoxColumn1";
            this.jezykDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rokprodDataGridViewTextBoxColumn1
            // 
            this.rokprodDataGridViewTextBoxColumn1.DataPropertyName = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn1.HeaderText = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn1.Name = "rokprodDataGridViewTextBoxColumn1";
            this.rokprodDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tytulDataGridViewTextBoxColumn1
            // 
            this.tytulDataGridViewTextBoxColumn1.DataPropertyName = "tytul";
            this.tytulDataGridViewTextBoxColumn1.HeaderText = "tytul";
            this.tytulDataGridViewTextBoxColumn1.Name = "tytulDataGridViewTextBoxColumn1";
            this.tytulDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // filmBindingSource2
            // 
            this.filmBindingSource2.DataMember = "Film";
            this.filmBindingSource2.DataSource = this.dataSet1;
            // 
            // filmBindingSource1
            // 
            this.filmBindingSource1.DataMember = "Film";
            this.filmBindingSource1.DataSource = this.dataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filmy aktora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filmy";
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(92, 116);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(75, 23);
            this.usunBtn.TabIndex = 1;
            this.usunBtn.Text = "USUŃ";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // FilmyAktora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allFilmsGrid);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.aktorsFilmGrid);
            this.Name = "FilmyAktora";
            this.Text = "FilmyAktora";
            this.Load += new System.EventHandler(this.FilmyAktora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aktorsFilmGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allFilmsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aktorsFilmGrid;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DataSet1TableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jezykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.DataGridView allFilmsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxofficeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jezykDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokprodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource filmBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.BindingSource filmBindingSource2;
    }
}