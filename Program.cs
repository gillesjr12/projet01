using System.Security.Cryptography.X509Certificates;

namespace Projet01
{

    class Program

    {
        public static void Main()
        {

            Console.Clear();
            Console.WriteLine("Bonjour, nous allons calculez les jours ainsi que si c'est une annee bissextile avec l'annee et le mois.");
            Console.WriteLine("Choisissez un mois.");
            Console.WriteLine(" Janvier = [1]/n" +
                              " Fevrier = [2]/n" +
                              " Mars = [3]/n" +
                              " Avril = [4]/n"+
                              " Mai = [5]/n" +
                              " Juin = [6]/n" +
                              " Juillet = [7]/n"+
                              " Aout = [8]/n" +
                              " Septembre = [9]/n" +
                              " Octobre = [10]/n" +
                              " Novembre = [11]/n" +
                              " Decembre = [12]/n");
            
            int ChoixMois = int.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("Parfait, maintenant renter un annee");
            int ChoixAnnee = int.Parse(Console.ReadLine());

            string AnneeBissextile;
            if ((ChoixAnnee % 4 = 0) && (ChoixAnnee % 100 = 0)
        }
    }
    
    
    
}

