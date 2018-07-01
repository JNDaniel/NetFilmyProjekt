namespace NetFilmyProjekt.Formsy.Filmy
{
    partial class EdycjaGatunkow
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
            this.filmgenres = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // filmgenres
            // 
            this.filmgenres.FormattingEnabled = true;
            this.filmgenres.Location = new System.Drawing.Point(108, 12);
            this.filmgenres.Name = "filmgenres";
            this.filmgenres.Size = new System.Drawing.Size(611, 424);
            this.filmgenres.TabIndex = 16;
            this.filmgenres.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filmgenres_ItemCheck);
            // 
            // EdycjaGatunkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filmgenres);
            this.Name = "EdycjaGatunkow";
            this.Text = "EdycjaGatunkow";
            this.Load += new System.EventHandler(this.EdycjaGatunkow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox filmgenres;
    }
}