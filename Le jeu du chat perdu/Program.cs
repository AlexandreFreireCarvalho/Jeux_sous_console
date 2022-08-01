using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_jeu_du_chat_perdu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random chatATrouver = new Random();
            int chatATrouver2 = chatATrouver.Next(0,51);
            //int chatATrouver = new Random().Next(0, 51);
            Console.WriteLine("le chat se cache à l'étage : " + chatATrouver2);
            int nombreDEssai = 0;
            bool trouve = false;
            Console.WriteLine("Veuillez trouver le chat parmis les 50 étages de l'immeuble");
            while (!trouve)
            {
                string saisie = Console.ReadLine();
                int etageSaisie =  int.Parse(saisie);
                if (etageSaisie > 0 && etageSaisie <= 50 )
                {
                    if (etageSaisie == chatATrouver2)
                        trouve = true;
                    else
                    {
                        if (etageSaisie < chatATrouver2)
                            Console.WriteLine("Plus haut ...");
                        else
                            Console.WriteLine("Plus bas ...");
                    }
                    nombreDEssai++;
                }
                else
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
            }
            Console.WriteLine("Vous avez trouvé le chat en " + nombreDEssai + " essai(s)");
        }
    
    }
}
