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
                Controleur.VmodeleS.charger_Stocks();
                if (Controleur.VmodeleC.chargement)
                {
                    bS1 = new BindingSource();
                    bS1.DataSource = Controleur.VmodeleC.DT[1];
                    dgvFormations.DataSource = bS1;
                    dgvFormations.Columns[0].HeaderText = "NOM_MARQUE";
                    dgvFormations.Columns[1].HeaderText = "NOM_MODELE";
                    dgvFormations.Refresh();
                    dgvFormations.Visible = true;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chargerComboBoxModif()
        {
            CBMA.Items.Clear();
            if (Controleur.VmodeleC.DT[2].Rows.Count == 0)
            {
                CBMA.Items.Add("ERROR !");
            }
            else
            {
                for (int i = 0; i < Controleur.VmodeleC.DT[2].Rows.Count; i++)
                {
                    CBMA.Items.Add(Controleur.VmodeleC.DT[2].Rows[i]["NOMMARQUE"].ToString());
                }
            }
        }


        private void GestionStock_Load(object sender, EventArgs e)
        {
            Controleur.initStocks();
            chargerComboBoxModif();
        }

        private void CBMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            var marque = CBMA.SelectedIndex + 1;
            MessageBox.Show("" + marque);
            Controleur.VmodeleS.charger_StocksModele(marque);
            chargerComboBoxModif();
        }
    }
}