namespace WindowsFormsApp1
{
    public class ModeleStocks
    {
        public void charger_Stocks()
        {
            Controleur.VmodeleC.charger("SELECT NOMMARQUE, CODEMODELE, TAILLE, DESCRIPTIFCOULEURS, PRIX, NOMLIBELLE FROM marque INNER JOIN modele ON marque.IDMARQUE=modele.IDMARQUE INNER JOIN categorie ON modele.IDCATEGORIE=categorie.IDCATEGORIE ORDER BY NOMMARQUE;"
                , Controleur.VmodeleC.DT[1]);
        }
    
    
        public void charger_StocksMarque()
        {
        Controleur.VmodeleC.charger("SELECT * FROM marque ;"
            , Controleur.VmodeleC.DT[2]);
        }
        
        public void charger_StocksModele(int id)
        {
            Controleur.VmodeleC.charger("SELECT * FROM modele INNER join marque on modele.IDMARQUE=marque.IDMARQUE where modele.IDMARQUE="+id+";"
                , Controleur.VmodeleC.DT[3]);
        }
        
        
    }
}