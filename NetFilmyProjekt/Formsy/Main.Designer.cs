namespace NetFilmyProjekt
{
    partial class Main
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
            this.krajeBtn = new System.Windows.Forms.Button();
            this.aktorzyBtn = new System.Windows.Forms.Button();
            this.rezyserzyBtn = new System.Windows.Forms.Button();
            this.filmyBtn = new System.Windows.Forms.Button();
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
            // krajeBtn
            // 
            this.krajeBtn.Location = new System.Drawing.Point(323, 34);
            this.krajeBtn.Name = "krajeBtn";
            this.krajeBtn.Size = new System.Drawing.Size(122, 68);
            this.krajeBtn.TabIndex = 0;
            this.krajeBtn.Text = "KRAJE";
            this.krajeBtn.UseVisualStyleBackColor = true;
            this.krajeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // aktorzyBtn
            // 
            this.aktorzyBtn.Location = new System.Drawing.Point(323, 108);
            this.aktorzyBtn.Name = "aktorzyBtn";
            this.aktorzyBtn.Size = new System.Drawing.Size(122, 68);
            this.aktorzyBtn.TabIndex = 1;
            this.aktorzyBtn.Text = "AKTORZY";
            this.aktorzyBtn.UseVisualStyleBackColor = true;
            this.aktorzyBtn.Click += new System.EventHandler(this.aktorzyBtn_Click);
            // 
            // rezyserzyBtn
            // 
            this.rezyserzyBtn.Location = new System.Drawing.Point(323, 182);
            this.rezyserzyBtn.Name = "rezyserzyBtn";
            this.rezyserzyBtn.Size = new System.Drawing.Size(122, 68);
            this.rezyserzyBtn.TabIndex = 2;
            this.rezyserzyBtn.Text = "REŻYSERZY";
            this.rezyserzyBtn.UseVisualStyleBackColor = true;
            this.rezyserzyBtn.Click += new System.EventHandler(this.rezyserzyBtn_Click);
            // 
            // filmyBtn
            // 
            this.filmyBtn.Location = new System.Drawing.Point(323, 256);
            this.filmyBtn.Name = "filmyBtn";
            this.filmyBtn.Size = new System.Drawing.Size(122, 68);
            this.filmyBtn.TabIndex = 3;
            this.filmyBtn.Text = "FILMY";
            this.filmyBtn.UseVisualStyleBackColor = true;
            this.filmyBtn.Click += new System.EventHandler(this.filmyBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filmyBtn);
            this.Controls.Add(this.rezyserzyBtn);
            this.Controls.Add(this.aktorzyBtn);
            this.Controls.Add(this.krajeBtn);
            this.Name = "Main";
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
        private System.Windows.Forms.Button krajeBtn;
        private System.Windows.Forms.Button aktorzyBtn;
        private System.Windows.Forms.Button rezyserzyBtn;
        private System.Windows.Forms.Button filmyBtn;
    }
}

