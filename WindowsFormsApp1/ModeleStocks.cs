namespace WindowsFormsApp1
{
    public class ModeleStocks
    {
        public void charger_Stocks()
        {
            Controleur.VmodeleC.charger("SELECT NOMMARQUE, CODEMODELE, TAILLE, DESCRIPTIFCOULEURS, PRIX, NOMLIBELLE FROM marque INNER JOIN modele ON marque.IDMARQUE=modele.IDMARQUE INNER JOIN categorie ON modele.IDCATEGORIE=categorie.IDCATEGORIE ORDER BY NOMMARQUE;", Controleur.VmodeleC.DT[1]);
        }
    }
}