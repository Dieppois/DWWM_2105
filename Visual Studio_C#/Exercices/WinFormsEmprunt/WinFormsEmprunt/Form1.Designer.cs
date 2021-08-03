
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
            this.lblCapitalEmprunte = new System.Windows.Forms.Label();
            this.lblTauxInteretAnnuel = new System.Windows.Forms.Label();
            this.lblNbrAnneeRbmt = new System.Windows.Forms.Label();
            this.txtCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.txtTauxInteretAnnuel = new System.Windows.Forms.TextBox();
            this.txtNbrAnneeRbmt = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.lblMensualite = new System.Windows.Forms.Label();
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
            this.buttonRun.Location = new System.Drawing.Point(198, 208);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(212, 71);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // txtMensualite
            // 
            this.txtMensualite.Location = new System.Drawing.Point(528, 237);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.Size = new System.Drawing.Size(100, 23);
            this.txtMensualite.TabIndex = 9;
            // 
            // lblMensualite
            // 
            this.lblMensualite.AutoSize = true;
            this.lblMensualite.Location = new System.Drawing.Point(443, 240);
            this.lblMensualite.Name = "lblMensualite";
            this.lblMensualite.Size = new System.Drawing.Size(74, 15);
            this.lblMensualite.TabIndex = 10;
            this.lblMensualite.Text = "Mensualite : ";
            // 
            // Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensualite);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.txtNbrAnneeRbmt);
            this.Controls.Add(this.txtTauxInteretAnnuel);
            this.Controls.Add(this.txtCapitalEmprunte);
            this.Controls.Add(this.lblNbrAnneeRbmt);
            this.Controls.Add(this.lblTauxInteretAnnuel);
            this.Controls.Add(this.lblCapitalEmprunte);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Emprunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapitalEmprunte;
        private System.Windows.Forms.Label lblTauxInteretAnnuel;
        private System.Windows.Forms.Label lblNbrAnneeRbmt;
        private System.Windows.Forms.TextBox txtCapitalEmprunte;
        private System.Windows.Forms.TextBox txtTauxInteretAnnuel;
        private System.Windows.Forms.TextBox txtNbrAnneeRbmt;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox txtMensualite;
        private System.Windows.Forms.Label lblMensualite;
    }
}