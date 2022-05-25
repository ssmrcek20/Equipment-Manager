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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosudbe
            // 
            this.dgvPosudbe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudbe.Location = new System.Drawing.Point(12, 12);
            this.dgvPosudbe.Name = "dgvPosudbe";
            this.dgvPosudbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosudbe.Size = new System.Drawing.Size(776, 322);
            this.dgvPosudbe.TabIndex = 0;
            // 
            // btnNovaPosudba
            // 
            this.btnNovaPosudba.Location = new System.Drawing.Point(624, 368);
            this.btnNovaPosudba.Name = "btnNovaPosudba";
            this.btnNovaPosudba.Size = new System.Drawing.Size(137, 52);
            this.btnNovaPosudba.TabIndex = 1;
            this.btnNovaPosudba.Text = "Nova posudba";
            this.btnNovaPosudba.UseVisualStyleBackColor = true;
            this.btnNovaPosudba.Click += new System.EventHandler(this.btnNovaPosudba_Click);
            // 
            // FrmPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovaPosudba);
            this.Controls.Add(this.dgvPosudbe);
            this.Name = "FrmPosudbe";
            this.Text = "FrmPosudbe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosudbe;
        private System.Windows.Forms.Button btnNovaPosudba;
    }
}

