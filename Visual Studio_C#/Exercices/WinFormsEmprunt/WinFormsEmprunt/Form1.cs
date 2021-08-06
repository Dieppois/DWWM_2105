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
            this.txtNbrAnneeRbmt.KeyPress += new KeyPressEventHandler(Keypressed);
        }
        private void Keypressed(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.Resultat();
            }                                    
        }
        private void ButtonRun_Click(object sender, EventArgs e)
        {
            this.Resultat();
        }
        private void Resultat()
        {
            DialogResult result = MessageBox.Show("Voulez-vous le resultat ?",
                                  "MessageBoxShow", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                double capital = double.Parse(this.txtCapitalEmprunte.Text);
                double taux = double.Parse(this.txtTauxInteretAnnuel.Text);
                int nbAnnee = int.Parse(this.txtNbrAnneeRbmt.Text);

                Credit monCredit = new Credit(capital, taux, nbAnnee);
                double temp = monCredit.CalculMensualite();
                this.txtMensualite.Text = Math.Round(temp, 2).ToString() + "€";

                this.txtInteret.Text = Math.Round(monCredit.NbMois * temp - capital, 2).ToString() + "€";
                dgv3.DataSource = monCredit.AfficheTab();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
        
        
        
        //ListBox
        //ListBox.ObjectCollection
        //ListBox.SelectedObjectCollection
        //ListBox.SelectedIndexCollection

        //SetSelected
        //SetSelectedItems
        //SetSelectedObjectCollection
        //SelectedIndices
        private void Onverra(object sender, EventArgs e)
        {
            // Create an instance of the ListBox.
            ListBox listBox1 = new ListBox();
            // Set the size and location of the ListBox.
            listBox1.Size = new System.Drawing.Size(200, 100);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Set the ListBox to display items in multiple columns.
            listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
            
                listBox1.Items.Add(txtCapitalEmprunte.Text);
                listBox1.Items.Add(txtTauxInteretAnnuel.Text);
                listBox1.Items.Add(txtNbrAnneeRbmt);
            
            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();

            // Select three items from the ListBox.
            listBox1.SetSelected(1, true);
            listBox1.SetSelected(2, true);
            listBox1.SetSelected(3, true);

            // Display the second selected item in the ListBox to the console.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedItems[1].ToString());
            // Display the index of the first selected item in the ListBox.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndices[0].ToString());
        }
    }    
}

