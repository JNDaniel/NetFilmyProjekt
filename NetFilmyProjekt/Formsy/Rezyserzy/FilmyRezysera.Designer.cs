namespace NetFilmyProjekt.Formsy.Rezyserzy
{
    partial class Filmy_rezysera
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allFilmsGrid = new System.Windows.Forms.DataGridView();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jezykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.usunBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.filmTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.FilmTableAdapter();
            this.directorFilms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allFilmsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filmy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filmy reżysera";
            // 
            // allFilmsGrid
            // 
            this.allFilmsGrid.AllowUserToAddRows = false;
            this.allFilmsGrid.AllowUserToDeleteRows = false;
            this.allFilmsGrid.AllowUserToOrderColumns = true;
            this.allFilmsGrid.AutoGenerateColumns = false;
            this.allFilmsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allFilmsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.rokprodDataGridViewTextBoxColumn,
            this.boxofficeDataGridViewTextBoxColumn,
            this.jezykDataGridViewTextBoxColumn});
            this.allFilmsGrid.DataSource = this.filmBindingSource;
            this.allFilmsGrid.Location = new System.Drawing.Point(207, 257);
            this.allFilmsGrid.MultiSelect = false;
            this.allFilmsGrid.Name = "allFilmsGrid";
            this.allFilmsGrid.ReadOnly = true;
            this.allFilmsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allFilmsGrid.Size = new System.Drawing.Size(546, 187);
            this.allFilmsGrid.TabIndex = 7;
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "film_id";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "film_id";
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokprodDataGridViewTextBoxColumn
            // 
            this.rokprodDataGridViewTextBoxColumn.DataPropertyName = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn.HeaderText = "rok_prod";
            this.rokprodDataGridViewTextBoxColumn.Name = "rokprodDataGridViewTextBoxColumn";
            this.rokprodDataGridViewTextBoxColumn.ReadOnly = true;
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
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(47, 117);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(75, 23);
            this.usunBtn.TabIndex = 5;
            this.usunBtn.Text = "USUŃ";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(47, 333);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 6;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // directorFilms
            // 
            this.directorFilms.AllowUserToAddRows = false;
            this.directorFilms.AllowUserToDeleteRows = false;
            this.directorFilms.AllowUserToOrderColumns = true;
            this.directorFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorFilms.Location = new System.Drawing.Point(207, 34);
            this.directorFilms.MultiSelect = false;
            this.directorFilms.Name = "directorFilms";
            this.directorFilms.ReadOnly = true;
            this.directorFilms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorFilms.Size = new System.Drawing.Size(546, 187);
            this.directorFilms.TabIndex = 10;
            this.directorFilms.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.directorFilms_DataError);
            // 
            // Filmy_rezysera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directorFilms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allFilmsGrid);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.dodajBtn);
            this.Name = "Filmy_rezysera";
            this.Text = "Filmy_rezysera";
            this.Load += new System.EventHandler(this.Filmy_rezysera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allFilmsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView allFilmsGrid;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Button dodajBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DataSet1TableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jezykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView directorFilms;
    }
}