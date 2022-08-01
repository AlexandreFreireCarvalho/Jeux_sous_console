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
            Random etageATrouver = new Random();
            int etageATrouver2 = etageATrouver.Next(0, 51);

            Random salleAtrouver = new Random();
            int salleATrouver2 = salleAtrouver.Next(0, 9);

            //int chatATrouver = new Random().Next(0, 51);
            Console.WriteLine("le chat se cache à l'étage : " + etageATrouver2);
            Console.WriteLine("le chat se cache dans la salle : " + salleATrouver2);
            int nombreDEssai = 0;
            bool etageTrouve = false;
            bool salleTrouve = false;
            Console.WriteLine("Veuillez trouver le chat parmis les 50 étages de l'immeuble");
            while (!etageTrouve)
            {
                string saisie = Console.ReadLine();
                int etageSaisie = int.Parse(saisie);
                if (etageSaisie > -1 && etageSaisie < 51)
                {
                    if (etageSaisie == etageATrouver2)
                    {
                        etageTrouve = true;
                        Console.WriteLine("Veuillez trouver le chat parmis les 8 salles de l'étage");
                        string saisie2 = Console.ReadLine();
                        int salleSaisie = int.Parse(saisie2);
                        while (!salleTrouve)
                        { 
                            if(salleSaisie > 0 && salleSaisie <= 8)
                            {
                                if (salleSaisie == salleATrouver2)
                                {
                                    salleTrouve = true;
                                }
                                else
                                {
                                    if (etageSaisie < etageATrouver2)
                                    {
                                        Console.WriteLine("Plus haut ...");
                                        nombreDEssai++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Plus bas ...");
                                        nombreDEssai++;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                            }
                        }
                    }
                    else
                    {
                        if (etageSaisie < etageATrouver2)
                        {
                            Console.WriteLine("Plus haut ...");
                        }
                        else
                        {
                            Console.WriteLine("Plus bas ...");
                        }
                    }
                    nombreDEssai++;
                }
                else
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
            }
            Console.WriteLine("Vous avez trouvé le chat en " + nombreDEssai + " essai(s)");
            Console.ReadKey();
        }

    }
}
