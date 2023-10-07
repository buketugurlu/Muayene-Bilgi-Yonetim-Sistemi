namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    partial class MuayeneBilgileriListele
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
            this.muayeneBilgileriListelePaneli = new System.Windows.Forms.Panel();
            this.muayeneBilgileriListeleDataGridView = new System.Windows.Forms.DataGridView();
            this.muayeneBilgileriListeleBaslikLbl = new System.Windows.Forms.Label();
            this.muayeneBilgileriListelePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBilgileriListeleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // muayeneBilgileriListelePaneli
            // 
            this.muayeneBilgileriListelePaneli.BackColor = System.Drawing.Color.MistyRose;
            this.muayeneBilgileriListelePaneli.Controls.Add(this.muayeneBilgileriListeleDataGridView);
            this.muayeneBilgileriListelePaneli.Location = new System.Drawing.Point(98, 111);
            this.muayeneBilgileriListelePaneli.Name = "muayeneBilgileriListelePaneli";
            this.muayeneBilgileriListelePaneli.Size = new System.Drawing.Size(808, 368);
            this.muayeneBilgileriListelePaneli.TabIndex = 5;
            // 
            // muayeneBilgileriListeleDataGridView
            // 
            this.muayeneBilgileriListeleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muayeneBilgileriListeleDataGridView.Location = new System.Drawing.Point(23, 17);
            this.muayeneBilgileriListeleDataGridView.Name = "muayeneBilgileriListeleDataGridView";
            this.muayeneBilgileriListeleDataGridView.RowHeadersWidth = 51;
            this.muayeneBilgileriListeleDataGridView.RowTemplate.Height = 24;
            this.muayeneBilgileriListeleDataGridView.Size = new System.Drawing.Size(766, 336);
            this.muayeneBilgileriListeleDataGridView.TabIndex = 0;
            // 
            // muayeneBilgileriListeleBaslikLbl
            // 
            this.muayeneBilgileriListeleBaslikLbl.AutoSize = true;
            this.muayeneBilgileriListeleBaslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muayeneBilgileriListeleBaslikLbl.ForeColor = System.Drawing.Color.Navy;
            this.muayeneBilgileriListeleBaslikLbl.Location = new System.Drawing.Point(381, 38);
            this.muayeneBilgileriListeleBaslikLbl.Name = "muayeneBilgileriListeleBaslikLbl";
            this.muayeneBilgileriListeleBaslikLbl.Size = new System.Drawing.Size(230, 36);
            this.muayeneBilgileriListeleBaslikLbl.TabIndex = 4;
            this.muayeneBilgileriListeleBaslikLbl.Text = "Muayene Listesi";
            // 
            // MuayeneBilgileriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1004, 516);
            this.Controls.Add(this.muayeneBilgileriListelePaneli);
            this.Controls.Add(this.muayeneBilgileriListeleBaslikLbl);
            this.Name = "MuayeneBilgileriListele";
            this.Text = "MuayeneBilgileriListele";
            this.Load += new System.EventHandler(this.MuayeneBilgileriListele_Load);
            this.muayeneBilgileriListelePaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBilgileriListeleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel muayeneBilgileriListelePaneli;
        private System.Windows.Forms.DataGridView muayeneBilgileriListeleDataGridView;
        private System.Windows.Forms.Label muayeneBilgileriListeleBaslikLbl;
    }
}