namespace Equipment_Manager
{
    partial class FrmNovaPosudba
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
            this.cboCipZaposlenik = new System.Windows.Forms.ComboBox();
            this.cboFoiZaposlenik = new System.Windows.Forms.ComboBox();
            this.txtRazlogPosudbe = new System.Windows.Forms.TextBox();
            this.dtpDatumPosudbe = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumVracanja = new System.Windows.Forms.DateTimePicker();
            this.clbOprema = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCipZaposlenik
            // 
            this.cboCipZaposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCipZaposlenik.FormattingEnabled = true;
            this.cboCipZaposlenik.Location = new System.Drawing.Point(55, 81);
            this.cboCipZaposlenik.Name = "cboCipZaposlenik";
            this.cboCipZaposlenik.Size = new System.Drawing.Size(205, 21);
            this.cboCipZaposlenik.TabIndex = 0;
            // 
            // cboFoiZaposlenik
            // 
            this.cboFoiZaposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoiZaposlenik.FormattingEnabled = true;
            this.cboFoiZaposlenik.Location = new System.Drawing.Point(55, 142);
            this.cboFoiZaposlenik.Name = "cboFoiZaposlenik";
            this.cboFoiZaposlenik.Size = new System.Drawing.Size(205, 21);
            this.cboFoiZaposlenik.TabIndex = 1;
            // 
            // txtRazlogPosudbe
            // 
            this.txtRazlogPosudbe.Location = new System.Drawing.Point(336, 82);
            this.txtRazlogPosudbe.Name = "txtRazlogPosudbe";
            this.txtRazlogPosudbe.Size = new System.Drawing.Size(205, 20);
            this.txtRazlogPosudbe.TabIndex = 2;
            // 
            // dtpDatumPosudbe
            // 
            this.dtpDatumPosudbe.Location = new System.Drawing.Point(55, 207);
            this.dtpDatumPosudbe.Name = "dtpDatumPosudbe";
            this.dtpDatumPosudbe.Size = new System.Drawing.Size(205, 20);
            this.dtpDatumPosudbe.TabIndex = 5;
            // 
            // dtpDatumVracanja
            // 
            this.dtpDatumVracanja.Location = new System.Drawing.Point(336, 143);
            this.dtpDatumVracanja.Name = "dtpDatumVracanja";
            this.dtpDatumVracanja.Size = new System.Drawing.Size(205, 20);
            this.dtpDatumVracanja.TabIndex = 6;
            // 
            // clbOprema
            // 
            this.clbOprema.FormattingEnabled = true;
            this.clbOprema.Location = new System.Drawing.Point(336, 207);
            this.clbOprema.Name = "clbOprema";
            this.clbOprema.Size = new System.Drawing.Size(205, 109);
            this.clbOprema.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 47);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNovaPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.clbOprema);
            this.Controls.Add(this.dtpDatumVracanja);
            this.Controls.Add(this.dtpDatumPosudbe);
            this.Controls.Add(this.txtRazlogPosudbe);
            this.Controls.Add(this.cboFoiZaposlenik);
            this.Controls.Add(this.cboCipZaposlenik);
            this.Name = "FrmNovaPosudba";
            this.Text = "FrmNovaPosudba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCipZaposlenik;
        private System.Windows.Forms.ComboBox cboFoiZaposlenik;
        private System.Windows.Forms.TextBox txtRazlogPosudbe;
        private System.Windows.Forms.DateTimePicker dtpDatumPosudbe;
        private System.Windows.Forms.DateTimePicker dtpDatumVracanja;
        private System.Windows.Forms.CheckedListBox clbOprema;
        private System.Windows.Forms.Button btnSave;
    }
}