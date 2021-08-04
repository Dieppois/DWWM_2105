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
            int nbAnnee = int.Parse(this.txtNbrAnneeRbmt.Text);
            
            Credit monCredit = new Credit(capital,taux,nbAnnee);
            double temp = monCredit.CalculMensualite();
            this.txtMensualite.Text = Math.Round(temp,2).ToString() + "€";
            
            this.txtInteret.Text = Math.Round(monCredit.NbMois * temp - capital,2).ToString();
            dgv3.DataSource = monCredit.AfficheTab();

        }

        
    }   
}
