using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exomagasincomplet
{
    internal class mesMethodes
    {
        static Dictionary<string, int> stock = new Dictionary<string, int>();
        static Dictionary<string, int> panier = new Dictionary<string, int>();
        const int prixCoca = 1;
        const int prixSandwish = 5;
        const int prixPorte = 200;
        internal static bool continuer = true;

        internal static void initialiser()
        {            
            panier.Add("Coca-Cola", 0);
            panier.Add("Sandwish", 0);
            panier.Add("Porte", 0);
            stock.Add("Coca-Cola", 4);
            stock.Add("Sandwish", 2);
            stock.Add("Porte", 3);
        }
        internal static void Affichage()
        {
            int counter = 1;
            foreach (KeyValuePair<string, int> st in stock)
            {
                Console.WriteLine($"{counter} : {st.Key} - {st.Value}");
                counter++;
            }
        Console.WriteLine("4 : quitter et faire le total des achats ");
        Console.WriteLine("veuillez choisir un article : ");
        int choixUtil = int.Parse(Console.ReadLine());
        Acheter(choixUtil);
        }


        static void Acheter(int choix)
        {
            switch (choix)
            {
                case 1:
                    stock["Coca-Cola"] -= 1;
                    panier["Coca-Cola"] += 1;
                    break;
                case 2:
                    stock["Sandwish"] -= 1;
                    panier["Sandwish"] += 1;
                    break;
                case 3:
                    stock["Porte"] -= 1;
                    panier["Porte"] += 1;
                    break;
                case 4:
                    addition();
                    continuer = false;
                    break;
            }
        }
        static void addition()
        {
            int total = 0;
            foreach (KeyValuePair<string, int> pa in panier)
            {

                if (pa.Key == "Coca-Cola") total = total + (prixCoca * pa.Value);
                if (pa.Key == "Sandwish") total = total + (prixSandwish * pa.Value);
                if (pa.Key == "Porte") total = total + (prixPorte * pa.Value);

            }

        Console.WriteLine($" vous devez payer {total} euro , merci pour votre achat et à la prochaine !");
        }
    }
}
