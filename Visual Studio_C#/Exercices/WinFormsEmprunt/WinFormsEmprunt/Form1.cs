using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibraryEmprunt;

namespace WinFormsEmprunt
{
    public partial class Emprunt : Form
    {
        public Emprunt()
        {
            InitializeComponent();
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            double capital = double.Parse(this.txtCapitalEmprunte.Text);
            double taux = double.Parse(this.txtTauxInteretAnnuel.Text);
            int nbAnnee = Int32.Parse(this.txtNbrAnneeRbmt.Text);

            //lblCapitalEmprunte = new System.Windows.Forms.Label();
            //this.lblTauxInteretAnnuel = new System.Windows.Forms.Label();
            //this.lblNbrAnneeRbmt = new System.Windows.Forms.Label();

            Credit monCredit = new Credit(capital,taux,nbAnnee);
            double temp = monCredit.CalculMensualite();
            this.txtMensualite.Text = temp.ToString();
        }       
    }   
}
