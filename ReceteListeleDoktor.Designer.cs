namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    partial class ReceteListeleDoktor
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
            this.receteListelePaneli = new System.Windows.Forms.Panel();
            this.receteListeleDataGridView = new System.Windows.Forms.DataGridView();
            this.receteListeleBaslikLbl = new System.Windows.Forms.Label();
            this.receteListelePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receteListeleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // receteListelePaneli
            // 
            this.receteListelePaneli.BackColor = System.Drawing.Color.MistyRose;
            this.receteListelePaneli.Controls.Add(this.receteListeleDataGridView);
            this.receteListelePaneli.Location = new System.Drawing.Point(46, 98);
            this.receteListelePaneli.Name = "receteListelePaneli";
            this.receteListelePaneli.Size = new System.Drawing.Size(1106, 437);
            this.receteListelePaneli.TabIndex = 5;
            // 
            // receteListeleDataGridView
            // 
            this.receteListeleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receteListeleDataGridView.Location = new System.Drawing.Point(20, 18);
            this.receteListeleDataGridView.Name = "receteListeleDataGridView";
            this.receteListeleDataGridView.RowHeadersWidth = 51;
            this.receteListeleDataGridView.RowTemplate.Height = 24;
            this.receteListeleDataGridView.Size = new System.Drawing.Size(1061, 394);
            this.receteListeleDataGridView.TabIndex = 0;
            // 
            // receteListeleBaslikLbl
            // 
            this.receteListeleBaslikLbl.AutoSize = true;
            this.receteListeleBaslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.receteListeleBaslikLbl.ForeColor = System.Drawing.Color.Red;
            this.receteListeleBaslikLbl.Location = new System.Drawing.Point(470, 44);
            this.receteListeleBaslikLbl.Name = "receteListeleBaslikLbl";
            this.receteListeleBaslikLbl.Size = new System.Drawing.Size(201, 36);
            this.receteListeleBaslikLbl.TabIndex = 4;
            this.receteListeleBaslikLbl.Text = "Reçete Listesi";
            // 
            // ReceteListeleDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1200, 599);
            this.Controls.Add(this.receteListelePaneli);
            this.Controls.Add(this.receteListeleBaslikLbl);
            this.Name = "ReceteListeleDoktor";
            this.Text = "ReceteListeleDoktor";
            this.Load += new System.EventHandler(this.ReceteListeleDoktor_Load);
            this.receteListelePaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receteListeleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel receteListelePaneli;
        private System.Windows.Forms.DataGridView receteListeleDataGridView;
        private System.Windows.Forms.Label receteListeleBaslikLbl;
    }
}