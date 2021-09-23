namespace WindowsFormsApp1
{
    public class Controleur
    {
        private static ModeleConnexion vmodeleC;

        
        public static ModeleConnexion VmodeleC { get => vmodeleC; set => vmodeleC = value; }

        public static void initConnexion()
        {
            VmodeleC = new ModeleConnexion();
        }
    
    }
}