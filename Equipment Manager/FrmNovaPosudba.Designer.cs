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
            this.btnSave = new System.Windows.Forms.Button();
            this.cboOprema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCipZaposlenik
            // 
            this.cboCipZaposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCipZaposlenik.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCipZaposlenik.FormattingEnabled = true;
            this.cboCipZaposlenik.Location = new System.Drawing.Point(107, 84);
            this.cboCipZaposlenik.Name = "cboCipZaposlenik";
            this.cboCipZaposlenik.Size = new System.Drawing.Size(205, 27);
            this.cboCipZaposlenik.TabIndex = 0;
            // 
            // cboFoiZaposlenik
            // 
            this.cboFoiZaposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoiZaposlenik.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoiZaposlenik.FormattingEnabled = true;
            this.cboFoiZaposlenik.Location = new System.Drawing.Point(481, 84);
            this.cboFoiZaposlenik.Name = "cboFoiZaposlenik";
            this.cboFoiZaposlenik.Size = new System.Drawing.Size(205, 27);
            this.cboFoiZaposlenik.TabIndex = 1;
            // 
            // txtRazlogPosudbe
            // 
            this.txtRazlogPosudbe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazlogPosudbe.Location = new System.Drawing.Point(107, 241);
            this.txtRazlogPosudbe.Multiline = true;
            this.txtRazlogPosudbe.Name = "txtRazlogPosudbe";
            this.txtRazlogPosudbe.Size = new System.Drawing.Size(205, 67);
            this.txtRazlogPosudbe.TabIndex = 2;
            // 
            // dtpDatumPosudbe
            // 
            this.dtpDatumPosudbe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumPosudbe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPosudbe.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpDatumPosudbe.Location = new System.Drawing.Point(107, 165);
            this.dtpDatumPosudbe.Name = "dtpDatumPosudbe";
            this.dtpDatumPosudbe.ShowUpDown = true;
            this.dtpDatumPosudbe.Size = new System.Drawing.Size(205, 27);
            this.dtpDatumPosudbe.TabIndex = 5;
            this.dtpDatumPosudbe.Value = new System.DateTime(2022, 5, 26, 22, 38, 14, 0);
            // 
            // dtpDatumVracanja
            // 
            this.dtpDatumVracanja.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumVracanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumVracanja.Location = new System.Drawing.Point(481, 165);
            this.dtpDatumVracanja.Name = "dtpDatumVracanja";
            this.dtpDatumVracanja.ShowUpDown = true;
            this.dtpDatumVracanja.Size = new System.Drawing.Size(205, 27);
            this.dtpDatumVracanja.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(291, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboOprema
            // 
            this.cboOprema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOprema.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOprema.FormattingEnabled = true;
            this.cboOprema.Location = new System.Drawing.Point(481, 241);
            this.cboOprema.Name = "cboOprema";
            this.cboOprema.Size = new System.Drawing.Size(205, 27);
            this.cboOprema.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Upisnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Posuditelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Datum i vrijeme posudbe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum i vrijeme vraćanja opreme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Razlog posudbe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Oprema:";
            // 
            // FrmNovaPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOprema);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDatumVracanja);
            this.Controls.Add(this.dtpDatumPosudbe);
            this.Controls.Add(this.txtRazlogPosudbe);
            this.Controls.Add(this.cboFoiZaposlenik);
            this.Controls.Add(this.cboCipZaposlenik);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmNovaPosudba";
            this.Text = "FrmNovaPosudba";
            this.Load += new System.EventHandler(this.FrmNovaPosudba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCipZaposlenik;
        private System.Windows.Forms.ComboBox cboFoiZaposlenik;
        private System.Windows.Forms.TextBox txtRazlogPosudbe;
        private System.Windows.Forms.DateTimePicker dtpDatumPosudbe;
        private System.Windows.Forms.DateTimePicker dtpDatumVracanja;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboOprema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}