using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace GSB
{
    internal class Program
    {
        static void Main()
        {
            AccesDonnees connexion = new AccesDonnees();
            //connexion.connectionMysQl();
            
            //connexion.selectV();
            DateTime aDateTime = new DateTime(2005, 8, 20, 12, 1, 10);
            //Console.WriteLine(GestionsDates.GetMoisPrecedent(aDateTime));
            //Console.WriteLine(GestionsDates.GetMoisPrecedent());
            //Console.WriteLine(GestionsDates.GetMoisSuivant());
            //Console.WriteLine(GestionsDates.GetMoisSuivant(aDateTime));
            //Console.WriteLine(GestionsDates.entre(14,20));
            //Console.WriteLine(GestionsDates.entre(14,20,2));
            //var a= GestionsDates.GetMoisPrecedent();
            //Console.WriteLine(a);
            
            connexion.getInfosVisiteur("dandre","opgg5");
            Console.ReadLine();
          }
    }
}
