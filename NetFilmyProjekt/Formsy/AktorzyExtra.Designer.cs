namespace NetFilmyProjekt.Formsy
{
    partial class AktorzyExtra
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
            this.genresGW = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new NetFilmyProjekt.DataSet1();
            this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gatunekTableAdapter = new NetFilmyProjekt.DataSet1TableAdapters.GatunekTableAdapter();
            this.gatunekidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearsList = new System.Windows.Forms.ListBox();
            this.actorsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.genresGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.genresGW.Location = new System.Drawing.Point(12, 85);
            this.genresGW.MultiSelect = false;
            this.genresGW.Name = "genresGW";
            this.genresGW.ReadOnly = true;
            this.genresGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genresGW.Size = new System.Drawing.Size(244, 353);
            this.genresGW.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aktorzy w gatunku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dostępne lata";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gatunki";
            // 
            // yearsList
            // 
            this.yearsList.FormattingEnabled = true;
            this.yearsList.Location = new System.Drawing.Point(298, 85);
            this.yearsList.Name = "yearsList";
            this.yearsList.Size = new System.Drawing.Size(201, 342);
            this.yearsList.TabIndex = 14;
            this.yearsList.SelectedIndexChanged += new System.EventHandler(this.yearsList_SelectedIndexChanged);
            // 
            // actorsList
            // 
            this.actorsList.FormattingEnabled = true;
            this.actorsList.Location = new System.Drawing.Point(547, 85);
            this.actorsList.Name = "actorsList";
            this.actorsList.Size = new System.Drawing.Size(213, 342);
            this.actorsList.TabIndex = 15;
            // 
            // AktorzyExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actorsList);
            this.Controls.Add(this.yearsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genresGW);
            this.Name = "AktorzyExtra";
            this.Text = "AktorzyExtra";
            this.Load += new System.EventHandler(this.AktorzyExtra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genresGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView genresGW;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gatunekBindingSource;
        private DataSet1TableAdapters.GatunekTableAdapter gatunekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatunekidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox yearsList;
        private System.Windows.Forms.ListBox actorsList;
    }
}