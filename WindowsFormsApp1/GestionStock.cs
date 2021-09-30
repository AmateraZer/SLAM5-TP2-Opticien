using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GestionStock : Form
    {
        private BindingSource bS1;
        public GestionStock()
        {
            
            InitializeComponent();
            
            
            // instanciation du ModeleFormation VmodeleF
            Controleur.initStocks();
            if (Controleur.VmodeleC.ConnOpen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                // chargement des données de la table FORMATION via DT[1] et affichage dans un dataGridView
                Controleur.VmodeleS.charger_Stocks();
                if (Controleur.VmodeleC.chargement)
                {
                    bS1 = new BindingSource();

                    bS1.DataSource = Controleur.VmodeleC.DT[1];
                    dgvFormations.DataSource = bS1;
                    dgvFormations.Columns[0].HeaderText = "NOM_MARQUE";
                    dgvFormations.Columns[1].HeaderText = "NOM_MODELE";

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dgvFormations.Refresh();
                    dgvFormations.Visible = true;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}