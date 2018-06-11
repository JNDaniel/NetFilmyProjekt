namespace NetFilmyProjekt
{
    partial class kraje
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
            this.filmdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmdbDataSet = new NetFilmyProjekt.filmdbDataSet();
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.krajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.krajTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.KrajTableAdapter();
            this.krajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajText = new System.Windows.Forms.TextBox();
            this.usunBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.krajidDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.krajBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(299, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // filmdbDataSetBindingSource
            // 
            this.filmdbDataSetBindingSource.DataSource = this.filmdbDataSet;
            this.filmdbDataSetBindingSource.Position = 0;
            // 
            // filmdbDataSet
            // 
            this.filmdbDataSet.DataSetName = "filmdbDataSet";
            this.filmdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // krajBindingSource
            // 
            this.krajBindingSource.DataMember = "Kraj";
            this.krajBindingSource.DataSource = this.dataSet1;
            // 
            // krajTableAdapter
            // 
            this.krajTableAdapter.ClearBeforeFill = true;
            // 
            // krajidDataGridViewTextBoxColumn
            // 
            this.krajidDataGridViewTextBoxColumn.DataPropertyName = "kraj_id";
            this.krajidDataGridViewTextBoxColumn.HeaderText = "kraj_id";
            this.krajidDataGridViewTextBoxColumn.Name = "krajidDataGridViewTextBoxColumn";
            this.krajidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // krajText
            // 
            this.krajText.Location = new System.Drawing.Point(95, 56);
            this.krajText.Name = "krajText";
            this.krajText.Size = new System.Drawing.Size(112, 20);
            this.krajText.TabIndex = 1;
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(370, 390);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(75, 23);
            this.usunBtn.TabIndex = 2;
            this.usunBtn.Text = "USUŃ";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KRAJ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(114, 108);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 4;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // kraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.krajText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kraje";
            this.Text = "kraje";
            this.Load += new System.EventHandler(this.kraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource filmdbDataSetBindingSource;
        private filmdbDataSet filmdbDataSet;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource krajBindingSource;
        private DataSet1TableAdapters.KrajTableAdapter krajTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox krajText;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
    }
}