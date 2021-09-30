namespace WindowsFormsApp1
{
    public class Controleur
    {
        private static ModeleConnexion vmodeleC;
        private static ModeleStocks vmodeleS;

        
        public static ModeleConnexion VmodeleC { get => vmodeleC; set => vmodeleC = value; }
        public static ModeleStocks VmodeleS { get => vmodeleS; set => vmodeleS = value; }

        public static void initConnexion()
        {
            VmodeleC = new ModeleConnexion();
        }
        
        public static void initStocks()
        {
            VmodeleS = new ModeleStocks();
        }
    
    }
}