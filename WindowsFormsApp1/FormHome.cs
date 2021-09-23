using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Controleur.initConnexion();
            Controleur.VmodeleC.seconnecter();
            if (Controleur.VmodeleC.ConnOpen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
                // throw new System.ArgumentException("Erreur dans la connexion", "connexion");
                Application.Exit();
            }
            else
            {
                // MessageBox.Show("BD connectée");
            }
        }



        private void FormConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controleur.VmodeleC.sedeconnecter();
            Application.Exit();
        }

        private void buttonVente_Click(object sender, EventArgs e)
        {
            VenteReservation VR = new VenteReservation();
            VR.Show();
        }

        private void buttonGds_Click(object sender, EventArgs e)
        {
            GestionStock GS = new GestionStock();
            GS.Show();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
            
        
    }
}