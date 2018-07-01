namespace NetFilmyProjekt.Formsy.Filmy
{
    partial class Filmy
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
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jezykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.filmTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.FilmTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.langText = new System.Windows.Forms.TextBox();
            this.boxOfficeText = new System.Windows.Forms.TextBox();
            this.zmienBtn = new System.Windows.Forms.Button();
            this.usunBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.actorsEditBtn = new System.Windows.Forms.Button();
            this.directorsEditBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.genreList = new System.Windows.Forms.ListBox();
            this.genresEditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.actorsList = new System.Windows.Forms.ListBox();
            this.directorsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.rokprodDataGridViewTextBoxColumn,
            this.boxofficeDataGridViewTextBoxColumn,
            this.jezykDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(266, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(535, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
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
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TYTUŁ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ROK PROD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "JĘZYK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "BOX OFFICE";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(94, 42);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(126, 20);
            this.titleText.TabIndex = 5;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(94, 73);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(126, 20);
            this.yearText.TabIndex = 7;
            // 
            // langText
            // 
            this.langText.Location = new System.Drawing.Point(94, 105);
            this.langText.Name = "langText";
            this.langText.Size = new System.Drawing.Size(126, 20);
            this.langText.TabIndex = 8;
            // 
            // boxOfficeText
            // 
            this.boxOfficeText.Location = new System.Drawing.Point(94, 139);
            this.boxOfficeText.Name = "boxOfficeText";
            this.boxOfficeText.Size = new System.Drawing.Size(126, 20);
            this.boxOfficeText.TabIndex = 9;
            // 
            // zmienBtn
            // 
            this.zmienBtn.Location = new System.Drawing.Point(114, 208);
            this.zmienBtn.Name = "zmienBtn";
            this.zmienBtn.Size = new System.Drawing.Size(75, 23);
            this.zmienBtn.TabIndex = 10;
            this.zmienBtn.Text = "ZMIEŃ";
            this.zmienBtn.UseVisualStyleBackColor = true;
            this.zmienBtn.Click += new System.EventHandler(this.zmienBtnClick);
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(114, 237);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(75, 23);
            this.usunBtn.TabIndex = 11;
            this.usunBtn.Text = "USUŃ";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtnClick);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(114, 179);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 12;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtnClick);
            // 
            // actorsEditBtn
            // 
            this.actorsEditBtn.Location = new System.Drawing.Point(104, 282);
            this.actorsEditBtn.Name = "actorsEditBtn";
            this.actorsEditBtn.Size = new System.Drawing.Size(106, 39);
            this.actorsEditBtn.TabIndex = 13;
            this.actorsEditBtn.Text = "EDYCJA AKTORÓW";
            this.actorsEditBtn.UseVisualStyleBackColor = true;
            this.actorsEditBtn.Click += new System.EventHandler(this.actorsEdit_Click);
            // 
            // directorsEditBtn
            // 
            this.directorsEditBtn.Location = new System.Drawing.Point(104, 327);
            this.directorsEditBtn.Name = "directorsEditBtn";
            this.directorsEditBtn.Size = new System.Drawing.Size(106, 39);
            this.directorsEditBtn.TabIndex = 14;
            this.directorsEditBtn.Text = "EDYCJA REŻYSERÓW";
            this.directorsEditBtn.UseVisualStyleBackColor = true;
            this.directorsEditBtn.Click += new System.EventHandler(this.directorsEditClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "GATUNKI";
            // 
            // genreList
            // 
            this.genreList.FormattingEnabled = true;
            this.genreList.Location = new System.Drawing.Point(700, 254);
            this.genreList.Name = "genreList";
            this.genreList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.genreList.Size = new System.Drawing.Size(88, 160);
            this.genreList.TabIndex = 17;
            // 
            // genresEditBtn
            // 
            this.genresEditBtn.Location = new System.Drawing.Point(104, 372);
            this.genresEditBtn.Name = "genresEditBtn";
            this.genresEditBtn.Size = new System.Drawing.Size(106, 42);
            this.genresEditBtn.TabIndex = 18;
            this.genresEditBtn.Text = "EDYCJA GATUNKÓW";
            this.genresEditBtn.UseVisualStyleBackColor = true;
            this.genresEditBtn.Click += new System.EventHandler(this.genresEditClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "AKTORZY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "REŻYSERZY";
            // 
            // actorsList
            // 
            this.actorsList.FormattingEnabled = true;
            this.actorsList.Location = new System.Drawing.Point(266, 254);
            this.actorsList.Name = "actorsList";
            this.actorsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.actorsList.Size = new System.Drawing.Size(209, 160);
            this.actorsList.TabIndex = 21;
            // 
            // directorsList
            // 
            this.directorsList.FormattingEnabled = true;
            this.directorsList.Location = new System.Drawing.Point(481, 254);
            this.directorsList.Name = "directorsList";
            this.directorsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.directorsList.Size = new System.Drawing.Size(213, 160);
            this.directorsList.TabIndex = 22;
            // 
            // Filmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directorsList);
            this.Controls.Add(this.actorsList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genresEditBtn);
            this.Controls.Add(this.genreList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.directorsEditBtn);
            this.Controls.Add(this.actorsEditBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.zmienBtn);
            this.Controls.Add(this.boxOfficeText);
            this.Controls.Add(this.langText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Filmy";
            this.Text = "Filmy";
            this.Load += new System.EventHandler(this.Filmy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DataSet1TableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox langText;
        private System.Windows.Forms.TextBox boxOfficeText;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jezykDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button zmienBtn;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button actorsEditBtn;
        private System.Windows.Forms.Button directorsEditBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox genreList;
        private System.Windows.Forms.Button genresEditBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox actorsList;
        private System.Windows.Forms.ListBox directorsList;
    }
}