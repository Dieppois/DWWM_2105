
namespace WinFormsEmprunt
{
    partial class Emprunt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCapitalEmprunte = new System.Windows.Forms.Label();
            this.lblTauxInteretAnnuel = new System.Windows.Forms.Label();
            this.lblNbrAnneeRbmt = new System.Windows.Forms.Label();
            this.txtCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.txtTauxInteretAnnuel = new System.Windows.Forms.TextBox();
            this.txtNbrAnneeRbmt = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.lblMensualite = new System.Windows.Forms.Label();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.txtInteret = new System.Windows.Forms.TextBox();
            this.lblInteret = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapitalEmprunte
            // 
            this.lblCapitalEmprunte.AutoSize = true;
            this.lblCapitalEmprunte.Location = new System.Drawing.Point(198, 80);
            this.lblCapitalEmprunte.Name = "lblCapitalEmprunte";
            this.lblCapitalEmprunte.Size = new System.Drawing.Size(105, 15);
            this.lblCapitalEmprunte.TabIndex = 0;
            this.lblCapitalEmprunte.Text = "Capital Emprunte :";
            // 
            // lblTauxInteretAnnuel
            // 
            this.lblTauxInteretAnnuel.AutoSize = true;
            this.lblTauxInteretAnnuel.Location = new System.Drawing.Point(198, 121);
            this.lblTauxInteretAnnuel.Name = "lblTauxInteretAnnuel";
            this.lblTauxInteretAnnuel.Size = new System.Drawing.Size(118, 15);
            this.lblTauxInteretAnnuel.TabIndex = 1;
            this.lblTauxInteretAnnuel.Text = "Taux Interet Annuel : ";
            // 
            // lblNbrAnneeRbmt
            // 
            this.lblNbrAnneeRbmt.AutoSize = true;
            this.lblNbrAnneeRbmt.Location = new System.Drawing.Point(198, 160);
            this.lblNbrAnneeRbmt.Name = "lblNbrAnneeRbmt";
            this.lblNbrAnneeRbmt.Size = new System.Drawing.Size(105, 15);
            this.lblNbrAnneeRbmt.TabIndex = 2;
            this.lblNbrAnneeRbmt.Text = "Nbr Annee Rbmt : ";
            // 
            // txtCapitalEmprunte
            // 
            this.txtCapitalEmprunte.Location = new System.Drawing.Point(372, 80);
            this.txtCapitalEmprunte.Name = "txtCapitalEmprunte";
            this.txtCapitalEmprunte.Size = new System.Drawing.Size(100, 23);
            this.txtCapitalEmprunte.TabIndex = 5;
            // 
            // txtTauxInteretAnnuel
            // 
            this.txtTauxInteretAnnuel.Location = new System.Drawing.Point(372, 121);
            this.txtTauxInteretAnnuel.Name = "txtTauxInteretAnnuel";
            this.txtTauxInteretAnnuel.Size = new System.Drawing.Size(100, 23);
            this.txtTauxInteretAnnuel.TabIndex = 6;
            // 
            // txtNbrAnneeRbmt
            // 
            this.txtNbrAnneeRbmt.Location = new System.Drawing.Point(372, 160);
            this.txtNbrAnneeRbmt.Name = "txtNbrAnneeRbmt";
            this.txtNbrAnneeRbmt.Size = new System.Drawing.Size(100, 23);
            this.txtNbrAnneeRbmt.TabIndex = 7;
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.Red;
            this.buttonRun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRun.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonRun.Location = new System.Drawing.Point(260, 221);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(212, 71);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Tag = "";
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // txtMensualite
            // 
            this.txtMensualite.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMensualite.Location = new System.Drawing.Point(602, 250);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.Size = new System.Drawing.Size(100, 23);
            this.txtMensualite.TabIndex = 9;
            // 
            // lblMensualite
            // 
            this.lblMensualite.AutoSize = true;
            this.lblMensualite.Location = new System.Drawing.Point(522, 253);
            this.lblMensualite.Name = "lblMensualite";
            this.lblMensualite.Size = new System.Drawing.Size(74, 15);
            this.lblMensualite.TabIndex = 10;
            this.lblMensualite.Text = "Mensualite : ";
            // 
            // dgv3
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(183, 328);
            this.dgv3.Name = "dgv3";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv3.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv3.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv3.RowTemplate.Height = 25;
            this.dgv3.Size = new System.Drawing.Size(589, 277);
            this.dgv3.TabIndex = 11;
            // 
            // txtInteret
            // 
            this.txtInteret.Location = new System.Drawing.Point(602, 207);
            this.txtInteret.Name = "txtInteret";
            this.txtInteret.Size = new System.Drawing.Size(100, 23);
            this.txtInteret.TabIndex = 12;
            // 
            // lblInteret
            // 
            this.lblInteret.AutoSize = true;
            this.lblInteret.Location = new System.Drawing.Point(522, 210);
            this.lblInteret.Name = "lblInteret";
            this.lblInteret.Size = new System.Drawing.Size(66, 15);
            this.lblInteret.TabIndex = 13;
            this.lblInteret.Text = "InteretTotal";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(560, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.Onverra);
            // 
            // Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 617);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblInteret);
            this.Controls.Add(this.txtInteret);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.txtNbrAnneeRbmt);
            this.Controls.Add(this.txtTauxInteretAnnuel);
            this.Controls.Add(this.txtCapitalEmprunte);
            this.Controls.Add(this.lblNbrAnneeRbmt);
            this.Controls.Add(this.lblTauxInteretAnnuel);
            this.Controls.Add(this.lblCapitalEmprunte);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.lblMensualite);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Emprunt";
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCapitalEmprunte;
        private System.Windows.Forms.Label lblTauxInteretAnnuel;
        private System.Windows.Forms.Label lblNbrAnneeRbmt;
        private System.Windows.Forms.TextBox txtCapitalEmprunte;
        private System.Windows.Forms.TextBox txtTauxInteretAnnuel;
        private System.Windows.Forms.TextBox txtNbrAnneeRbmt;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox txtMensualite;
        private System.Windows.Forms.Label lblMensualite;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.TextBox txtInteret;
        private System.Windows.Forms.Label lblInteret;
        private System.Windows.Forms.ListBox listBox1;
    }
    #endregion
}