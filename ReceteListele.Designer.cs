namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    partial class ReceteListele
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
            this.receteListeleBaslikLbl = new System.Windows.Forms.Label();
            this.receteListelePaneli = new System.Windows.Forms.Panel();
            this.receteListeleDataGridView = new System.Windows.Forms.DataGridView();
            this.receteListelePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receteListeleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // receteListeleBaslikLbl
            // 
            this.receteListeleBaslikLbl.AutoSize = true;
            this.receteListeleBaslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.receteListeleBaslikLbl.ForeColor = System.Drawing.Color.Red;
            this.receteListeleBaslikLbl.Location = new System.Drawing.Point(353, 39);
            this.receteListeleBaslikLbl.Name = "receteListeleBaslikLbl";
            this.receteListeleBaslikLbl.Size = new System.Drawing.Size(201, 36);
            this.receteListeleBaslikLbl.TabIndex = 2;
            this.receteListeleBaslikLbl.Text = "Reçete Listesi";
            // 
            // receteListelePaneli
            // 
            this.receteListelePaneli.BackColor = System.Drawing.Color.MistyRose;
            this.receteListelePaneli.Controls.Add(this.receteListeleDataGridView);
            this.receteListelePaneli.Location = new System.Drawing.Point(70, 112);
            this.receteListelePaneli.Name = "receteListelePaneli";
            this.receteListelePaneli.Size = new System.Drawing.Size(808, 368);
            this.receteListelePaneli.TabIndex = 3;
            // 
            // receteListeleDataGridView
            // 
            this.receteListeleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receteListeleDataGridView.Location = new System.Drawing.Point(21, 19);
            this.receteListeleDataGridView.Name = "receteListeleDataGridView";
            this.receteListeleDataGridView.RowHeadersWidth = 51;
            this.receteListeleDataGridView.RowTemplate.Height = 24;
            this.receteListeleDataGridView.Size = new System.Drawing.Size(767, 332);
            this.receteListeleDataGridView.TabIndex = 0;
            // 
            // ReceteListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(952, 526);
            this.Controls.Add(this.receteListelePaneli);
            this.Controls.Add(this.receteListeleBaslikLbl);
            this.Name = "ReceteListele";
            this.Text = "ReceteListele";
            this.Load += new System.EventHandler(this.ReceteListele_Load);
            this.receteListelePaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receteListeleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receteListeleBaslikLbl;
        private System.Windows.Forms.Panel receteListelePaneli;
        private System.Windows.Forms.DataGridView receteListeleDataGridView;
    }
}