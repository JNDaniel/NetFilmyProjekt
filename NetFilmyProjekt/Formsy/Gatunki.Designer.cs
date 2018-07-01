namespace NetFilmyProjekt.Formsy
{
    partial class Gatunki
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
            this.changeBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usunBtn = new System.Windows.Forms.Button();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genresGW = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gatunekTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.GatunekTableAdapter();
            this.gatunekidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.genresGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(167, 137);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 12;
            this.changeBtn.Text = "ZMIEŃ";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(167, 166);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 11;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "GATUNEK";
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(167, 195);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(75, 23);
            this.usunBtn.TabIndex = 9;
            this.usunBtn.Text = "USUŃ";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(149, 76);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(112, 20);
            this.genreText.TabIndex = 8;
            // 
            // genresGW
            // 
            this.genresGW.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.genresGW.AllowUserToAddRows = false;
            this.genresGW.AllowUserToDeleteRows = false;
            this.genresGW.AllowUserToOrderColumns = true;
            this.genresGW.AutoGenerateColumns = false;
            this.genresGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gatunekidDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn});
            this.genresGW.DataSource = this.gatunekBindingSource;
            this.genresGW.Location = new System.Drawing.Point(353, 32);
            this.genresGW.MultiSelect = false;
            this.genresGW.Name = "genresGW";
            this.genresGW.ReadOnly = true;
            this.genresGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genresGW.Size = new System.Drawing.Size(244, 353);
            this.genresGW.TabIndex = 7;
            this.genresGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genresGW_CellClick);
            this.genresGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.genresGW_DataBindingComplete);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gatunekBindingSource
            // 
            this.gatunekBindingSource.DataMember = "Gatunek";
            this.gatunekBindingSource.DataSource = this.dataSet1;
            // 
            // gatunekTableAdapter
            // 
            this.gatunekTableAdapter.ClearBeforeFill = true;
            // 
            // gatunekidDataGridViewTextBoxColumn
            // 
            this.gatunekidDataGridViewTextBoxColumn.DataPropertyName = "gatunek_id";
            this.gatunekidDataGridViewTextBoxColumn.HeaderText = "gatunek_id";
            this.gatunekidDataGridViewTextBoxColumn.Name = "gatunekidDataGridViewTextBoxColumn";
            this.gatunekidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Gatunki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.genresGW);
            this.Name = "Gatunki";
            this.Text = "Gatunki";
            this.Load += new System.EventHandler(this.Gatunki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genresGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.TextBox genreText;
        public System.Windows.Forms.DataGridView genresGW;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gatunekBindingSource;
        private DataSet1TableAdapters.GatunekTableAdapter gatunekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatunekidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
    }
}