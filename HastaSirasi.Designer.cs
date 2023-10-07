namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    partial class HastaSirasi
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
            this.hastaSirasiPaneli = new System.Windows.Forms.Panel();
            this.hastaSirasiDataGridView = new System.Windows.Forms.DataGridView();
            this.hastaSirasiBaslikLbl = new System.Windows.Forms.Label();
            this.hastaSirasiPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaSirasiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaSirasiPaneli
            // 
            this.hastaSirasiPaneli.BackColor = System.Drawing.Color.MistyRose;
            this.hastaSirasiPaneli.Controls.Add(this.hastaSirasiDataGridView);
            this.hastaSirasiPaneli.Location = new System.Drawing.Point(40, 93);
            this.hastaSirasiPaneli.Name = "hastaSirasiPaneli";
            this.hastaSirasiPaneli.Size = new System.Drawing.Size(1104, 406);
            this.hastaSirasiPaneli.TabIndex = 5;
            // 
            // hastaSirasiDataGridView
            // 
            this.hastaSirasiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaSirasiDataGridView.Location = new System.Drawing.Point(33, 27);
            this.hastaSirasiDataGridView.Name = "hastaSirasiDataGridView";
            this.hastaSirasiDataGridView.RowHeadersWidth = 51;
            this.hastaSirasiDataGridView.RowTemplate.Height = 24;
            this.hastaSirasiDataGridView.Size = new System.Drawing.Size(1040, 353);
            this.hastaSirasiDataGridView.TabIndex = 0;
            // 
            // hastaSirasiBaslikLbl
            // 
            this.hastaSirasiBaslikLbl.AutoSize = true;
            this.hastaSirasiBaslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaSirasiBaslikLbl.ForeColor = System.Drawing.Color.Navy;
            this.hastaSirasiBaslikLbl.Location = new System.Drawing.Point(468, 36);
            this.hastaSirasiBaslikLbl.Name = "hastaSirasiBaslikLbl";
            this.hastaSirasiBaslikLbl.Size = new System.Drawing.Size(174, 36);
            this.hastaSirasiBaslikLbl.TabIndex = 4;
            this.hastaSirasiBaslikLbl.Text = "Hasta Sırası";
            // 
            // HastaSirasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1186, 533);
            this.Controls.Add(this.hastaSirasiPaneli);
            this.Controls.Add(this.hastaSirasiBaslikLbl);
            this.Name = "HastaSirasi";
            this.Text = "HastaSirasi";
            this.Load += new System.EventHandler(this.HastaSirasi_Load);
            this.hastaSirasiPaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hastaSirasiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel hastaSirasiPaneli;
        private System.Windows.Forms.DataGridView hastaSirasiDataGridView;
        private System.Windows.Forms.Label hastaSirasiBaslikLbl;
    }
}