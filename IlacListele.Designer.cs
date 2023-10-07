namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    partial class IlacListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ilacListeleDataGridView = new System.Windows.Forms.DataGridView();
            this.ilacListeleBaslikLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilacListeleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.ilacListeleDataGridView);
            this.panel1.Location = new System.Drawing.Point(64, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 368);
            this.panel1.TabIndex = 0;
            // 
            // ilacListeleDataGridView
            // 
            this.ilacListeleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilacListeleDataGridView.Location = new System.Drawing.Point(15, 17);
            this.ilacListeleDataGridView.Name = "ilacListeleDataGridView";
            this.ilacListeleDataGridView.RowHeadersWidth = 51;
            this.ilacListeleDataGridView.RowTemplate.Height = 24;
            this.ilacListeleDataGridView.Size = new System.Drawing.Size(766, 333);
            this.ilacListeleDataGridView.TabIndex = 0;
            // 
            // ilacListeleBaslikLbl
            // 
            this.ilacListeleBaslikLbl.AutoSize = true;
            this.ilacListeleBaslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacListeleBaslikLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.ilacListeleBaslikLbl.Location = new System.Drawing.Point(397, 21);
            this.ilacListeleBaslikLbl.Name = "ilacListeleBaslikLbl";
            this.ilacListeleBaslikLbl.Size = new System.Drawing.Size(154, 36);
            this.ilacListeleBaslikLbl.TabIndex = 1;
            this.ilacListeleBaslikLbl.Text = "İlaç Listesi";
            // 
            // IlacListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(938, 514);
            this.Controls.Add(this.ilacListeleBaslikLbl);
            this.Controls.Add(this.panel1);
            this.Name = "IlacListele";
            this.Text = "IlacListele";
            this.Load += new System.EventHandler(this.IlacListele_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ilacListeleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ilacListeleBaslikLbl;
        private System.Windows.Forms.DataGridView ilacListeleDataGridView;
    }
}