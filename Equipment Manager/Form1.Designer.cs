namespace Equipment_Manager
{
    partial class FrmPosudbe
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
            this.dgvPosudbe = new System.Windows.Forms.DataGridView();
            this.btnNovaPosudba = new System.Windows.Forms.Button();
            this.btnUrediPosudbu = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosudbe
            // 
            this.dgvPosudbe.AllowUserToOrderColumns = true;
            this.dgvPosudbe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosudbe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudbe.Location = new System.Drawing.Point(12, 12);
            this.dgvPosudbe.Name = "dgvPosudbe";
            this.dgvPosudbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosudbe.Size = new System.Drawing.Size(776, 370);
            this.dgvPosudbe.TabIndex = 0;
            // 
            // btnNovaPosudba
            // 
            this.btnNovaPosudba.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaPosudba.Location = new System.Drawing.Point(588, 388);
            this.btnNovaPosudba.Name = "btnNovaPosudba";
            this.btnNovaPosudba.Size = new System.Drawing.Size(200, 50);
            this.btnNovaPosudba.TabIndex = 1;
            this.btnNovaPosudba.Text = "Nova posudba";
            this.btnNovaPosudba.UseVisualStyleBackColor = true;
            this.btnNovaPosudba.Click += new System.EventHandler(this.btnNovaPosudba_Click);
            // 
            // btnUrediPosudbu
            // 
            this.btnUrediPosudbu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediPosudbu.Location = new System.Drawing.Point(12, 388);
            this.btnUrediPosudbu.Name = "btnUrediPosudbu";
            this.btnUrediPosudbu.Size = new System.Drawing.Size(200, 50);
            this.btnUrediPosudbu.TabIndex = 2;
            this.btnUrediPosudbu.Text = "Uredi posudbu";
            this.btnUrediPosudbu.UseVisualStyleBackColor = true;
            this.btnUrediPosudbu.Click += new System.EventHandler(this.btnUrediPosudbu_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(218, 388);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(200, 50);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUrediPosudbu);
            this.Controls.Add(this.btnNovaPosudba);
            this.Controls.Add(this.dgvPosudbe);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPosudbe";
            this.Text = "FrmPosudbe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosudbe;
        private System.Windows.Forms.Button btnNovaPosudba;
        private System.Windows.Forms.Button btnUrediPosudbu;
        private System.Windows.Forms.Button btnObrisi;
    }
}

