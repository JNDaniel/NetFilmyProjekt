namespace NetFilmyProjekt.Formsy.Filmy
{
    partial class EdycjaRezyserow
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
            this.allDirectors = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narodowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataurodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.usunBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.directorsInFilm = new System.Windows.Forms.DataGridView();
            this.aktorTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.AktorTableAdapter();
            this.rezyserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezyserTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.RezyserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.allDirectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsInFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezyserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Wszyscy reżsyerzy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reżyserzy w filmie";
            // 
            // allDirectors
            // 
            this.allDirectors.AllowUserToAddRows = false;
            this.allDirectors.AllowUserToDeleteRows = false;
            this.allDirectors.AllowUserToOrderColumns = true;
            this.allDirectors.AutoGenerateColumns = false;
            this.allDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDirectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.narodowoscDataGridViewTextBoxColumn,
            this.dataurodzeniaDataGridViewTextBoxColumn});
            this.allDirectors.DataSource = this.rezyserBindingSource;
            this.allDirectors.Location = new System.Drawing.Point(207, 257);
            this.allDirectors.MultiSelect = false;
            this.allDirectors.Name = "allDirectors";
            this.allDirectors.ReadOnly = true;
            this.allDirectors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allDirectors.Size = new System.Drawing.Size(546, 187);
            this.allDirectors.TabIndex = 13;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narodowoscDataGridViewTextBoxColumn
            // 
            this.narodowoscDataGridViewTextBoxColumn.DataPropertyName = "narodowosc";
            this.narodowoscDataGridViewTextBoxColumn.HeaderText = "narodowosc";
            this.narodowoscDataGridViewTextBoxColumn.Name = "narodowoscDataGridViewTextBoxColumn";
            this.narodowoscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataurodzeniaDataGridViewTextBoxColumn
            // 
            this.dataurodzeniaDataGridViewTextBoxColumn.DataPropertyName = "data_urodzenia";
            this.dataurodzeniaDataGridViewTextBoxColumn.HeaderText = "data_urodzenia";
            this.dataurodzeniaDataGridViewTextBoxColumn.Name = "dataurodzeniaDataGridViewTextBoxColumn";
            this.dataurodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktorBindingSource
            // 
            this.aktorBindingSource.DataMember = "Aktor";
            this.aktorBindingSource.DataSource = this.dataSet1;
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
            this.usunBtn.TabIndex = 11;
            this.usunBtn.Text = "USUŃ";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(47, 333);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 12;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // directorsInFilm
            // 
            this.directorsInFilm.AllowUserToAddRows = false;
            this.directorsInFilm.AllowUserToDeleteRows = false;
            this.directorsInFilm.AllowUserToOrderColumns = true;
            this.directorsInFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorsInFilm.Location = new System.Drawing.Point(207, 34);
            this.directorsInFilm.MultiSelect = false;
            this.directorsInFilm.Name = "directorsInFilm";
            this.directorsInFilm.ReadOnly = true;
            this.directorsInFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorsInFilm.Size = new System.Drawing.Size(546, 187);
            this.directorsInFilm.TabIndex = 10;
            this.directorsInFilm.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.directorsInFilm_DataError);
            // 
            // aktorTableAdapter
            // 
            this.aktorTableAdapter.ClearBeforeFill = true;
            // 
            // rezyserBindingSource
            // 
            this.rezyserBindingSource.DataMember = "Rezyser";
            this.rezyserBindingSource.DataSource = this.dataSet1;
            // 
            // rezyserTableAdapter
            // 
            this.rezyserTableAdapter.ClearBeforeFill = true;
            // 
            // EdycjaRezyserow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allDirectors);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.directorsInFilm);
            this.Name = "EdycjaRezyserow";
            this.Text = "EdycjaRezyserow";
            this.Load += new System.EventHandler(this.EdycjaRezyserow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allDirectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsInFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezyserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView allDirectors;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narodowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataurodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aktorBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.DataGridView directorsInFilm;
        private DataSet1TableAdapters.AktorTableAdapter aktorTableAdapter;
        private System.Windows.Forms.BindingSource rezyserBindingSource;
        private DataSet1TableAdapters.RezyserTableAdapter rezyserTableAdapter;
    }
}