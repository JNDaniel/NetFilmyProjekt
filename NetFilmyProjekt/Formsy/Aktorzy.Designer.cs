namespace NetFilmyProjekt
{
    partial class Aktorzy
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
            this.aktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataurodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narodowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.aktorTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.AktorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.imieTxt = new System.Windows.Forms.TextBox();
            this.nazwiskoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.narodowoscTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataUrTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zmienBtn = new System.Windows.Forms.Button();
            this.usunBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.filmyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aktoridDataGridViewTextBoxColumn,
            this.dataurodzeniaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.narodowoscDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aktorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(254, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // aktoridDataGridViewTextBoxColumn
            // 
            this.aktoridDataGridViewTextBoxColumn.DataPropertyName = "aktor_id";
            this.aktoridDataGridViewTextBoxColumn.HeaderText = "aktor_id";
            this.aktoridDataGridViewTextBoxColumn.Name = "aktoridDataGridViewTextBoxColumn";
            this.aktoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataurodzeniaDataGridViewTextBoxColumn
            // 
            this.dataurodzeniaDataGridViewTextBoxColumn.DataPropertyName = "data_urodzenia";
            this.dataurodzeniaDataGridViewTextBoxColumn.HeaderText = "data_urodzenia";
            this.dataurodzeniaDataGridViewTextBoxColumn.Name = "dataurodzeniaDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // narodowoscDataGridViewTextBoxColumn
            // 
            this.narodowoscDataGridViewTextBoxColumn.DataPropertyName = "narodowosc";
            this.narodowoscDataGridViewTextBoxColumn.HeaderText = "narodowosc";
            this.narodowoscDataGridViewTextBoxColumn.Name = "narodowoscDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
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
            // aktorTableAdapter
            // 
            this.aktorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IMIE";
            // 
            // imieTxt
            // 
            this.imieTxt.Location = new System.Drawing.Point(101, 52);
            this.imieTxt.Name = "imieTxt";
            this.imieTxt.Size = new System.Drawing.Size(122, 20);
            this.imieTxt.TabIndex = 2;
            // 
            // nazwiskoTxt
            // 
            this.nazwiskoTxt.Location = new System.Drawing.Point(101, 93);
            this.nazwiskoTxt.Name = "nazwiskoTxt";
            this.nazwiskoTxt.Size = new System.Drawing.Size(122, 20);
            this.nazwiskoTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAZWISKO";
            // 
            // narodowoscTxt
            // 
            this.narodowoscTxt.Location = new System.Drawing.Point(101, 130);
            this.narodowoscTxt.Name = "narodowoscTxt";
            this.narodowoscTxt.Size = new System.Drawing.Size(122, 20);
            this.narodowoscTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NARODOWOŚĆ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataUrTxt
            // 
            this.dataUrTxt.Location = new System.Drawing.Point(101, 167);
            this.dataUrTxt.Name = "dataUrTxt";
            this.dataUrTxt.Size = new System.Drawing.Size(122, 20);
            this.dataUrTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DATA UR";
            // 
            // zmienBtn
            // 
            this.zmienBtn.Location = new System.Drawing.Point(101, 210);
            this.zmienBtn.Name = "zmienBtn";
            this.zmienBtn.Size = new System.Drawing.Size(122, 23);
            this.zmienBtn.TabIndex = 9;
            this.zmienBtn.Text = "ZMIEŃ";
            this.zmienBtn.UseVisualStyleBackColor = true;
            this.zmienBtn.Click += new System.EventHandler(this.zmienBtn_Click);
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(101, 239);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(122, 23);
            this.usunBtn.TabIndex = 10;
            this.usunBtn.Text = "USUŃ";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(101, 268);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(122, 23);
            this.dodajBtn.TabIndex = 11;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // filmyBtn
            // 
            this.filmyBtn.Location = new System.Drawing.Point(101, 297);
            this.filmyBtn.Name = "filmyBtn";
            this.filmyBtn.Size = new System.Drawing.Size(122, 23);
            this.filmyBtn.TabIndex = 12;
            this.filmyBtn.Text = "POKAŻ FILMY";
            this.filmyBtn.UseVisualStyleBackColor = true;
            this.filmyBtn.Click += new System.EventHandler(this.filmyBtn_Click);
            // 
            // Aktorzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filmyBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.zmienBtn);
            this.Controls.Add(this.dataUrTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.narodowoscTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazwiskoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imieTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Aktorzy";
            this.Text = "Aktorzy";
            this.Load += new System.EventHandler(this.Aktorzy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aktorBindingSource;
        private DataSet1TableAdapters.AktorTableAdapter aktorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataurodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narodowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imieTxt;
        private System.Windows.Forms.TextBox nazwiskoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox narodowoscTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dataUrTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zmienBtn;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button filmyBtn;
    }
}