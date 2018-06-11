namespace NetFilmyProjekt
{
    partial class Form1
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
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmdbDataSet = new NetFilmyProjekt.filmdbDataSet();
            this.filmTableAdapter = new NetFilmyProjekt.filmdbDataSetTableAdapters.FilmTableAdapter();
            this.filmdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.filmdbDataSet;
            // 
            // filmdbDataSet
            // 
            this.filmdbDataSet.DataSetName = "filmdbDataSet";
            this.filmdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // filmdbDataSetBindingSource
            // 
            this.filmdbDataSetBindingSource.DataSource = this.filmdbDataSet;
            this.filmdbDataSetBindingSource.Position = 0;
            // 
            // filmBindingSource1
            // 
            this.filmBindingSource1.DataMember = "Film";
            this.filmBindingSource1.DataSource = this.filmdbDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "KRAJE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private filmdbDataSet filmdbDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private filmdbDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource1;
        private System.Windows.Forms.BindingSource filmdbDataSetBindingSource;
        private System.Windows.Forms.Button button1;
    }
}

