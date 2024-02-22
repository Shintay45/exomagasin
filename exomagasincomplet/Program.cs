using System.Net;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace exomagasincomplet
{
    internal class Program
         //Un magasin en ligne propose 3 articles
         //       Coca : 1€ (stock 4)
         //       Sandwich : 5€ (stock 2)
         //       Porte : 200€ (stock 3)

         //       Tant que l'utiliseur veut continuer ses achats, le programme
         //       continue à lui proposer la liste des articles en stock
         //       et lui demande de faire son choix(1 2 ou 3 )

         //       Quand il choisit d'arrêter, le programme affiche le total à payer
             
         //       L'affichage des articles (stocké dans une collection) 
         //       se fera à l'aide d'une méthode(void)

         //       Le panier du client doit également être stocké dans une collection

         //       le retrait d'un article du stock se fait via méthode

         //       créer une méthode qui calcule le total des achats
    {
        
        
        static void Main(string[] args)
        {

            mesMethodes.initialiser();
            while (mesMethodes.continuer)
            {
                mesMethodes.Affichage();
            }

            

        }
    }
}
