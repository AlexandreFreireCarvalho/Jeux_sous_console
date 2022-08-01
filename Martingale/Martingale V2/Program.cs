using System;
namespace Martingale_V2

//Le 11/09 2020
//FREIRE CARVALHO ALEXANDRE
{
    class Program
    {
        static void Main(string[] args)
        {
            int fonds = 100;//fonds de départ
            Console.WriteLine("Fonds de base : " + fonds);
            //int mise;//mise de jeu
            int gain;
            int perte;
            int partie = 0;
            int gainsTotaux = 0;
            int pertesTotales = 0;
            int couleurChoisie = 0;
            int couleurHas=0;
            string choixCouleur;
            string miseDeJeu;
            string saisieCouleur;
            //Si je perds je double mais je gagne je ne double pas
            //Donc je ne choisis pas la couleur, je choisis si je gagne ou pas

            while (fonds > 0)
            {
                partie++;
                Console.WriteLine("Partie numéro : " + partie);
                Console.WriteLine("Choisissez la couleur à miser (n/r) : ");
                saisieCouleur = Console.ReadLine();
                ///////////////////////////////////////////////
                Random couleurHasard = new Random();
                couleurHas = couleurHasard.Next(1, 3);
                //Console.WriteLine(/*"has" + */couleurHas);
                //////////////////////////////////////////////////////////////
                if ((saisieCouleur == "n" || saisieCouleur == "r") && couleurChoisie == couleurHas)
                {

                }







                if (saisieCouleur == "n")
                {
                    Console.WriteLine("Choisissez votre mise !");
                    miseDeJeu = Console.ReadLine();
                    bool success = Int32.TryParse(miseDeJeu, out int mise);
                    //mise = int.Parse(miseDeJeu);
                    ///////////////////////////////////////////////
                    //Random couleurHasard = new Random();       //
                    //couleurHas = couleurHasard.Next(1, 3);     //
                    //Console.WriteLine(/*"has" + */couleurHas); //
                    ///////////////////////////////////////////////
                    couleurChoisie = 1;
                    //Console.WriteLine("Line56" + couleurChoisie);
                    if (couleurChoisie == couleurHas)//noire gagné
                    {
                        Console.WriteLine("La couleur Noire est tombé vous avez : gagné!");
                        gain = mise;
                        fonds = fonds + mise + gain;
                        gainsTotaux = gainsTotaux + gain;
                        Console.WriteLine("Fonds restant après Gain : " + fonds);
                        Console.WriteLine("Gains Totaux : " + gainsTotaux);
                        Console.WriteLine("Pertes Totales : " + pertesTotales);
                        Console.WriteLine("Total Gains-Pertes : " + (gainsTotaux - pertesTotales));
                        Console.WriteLine("-----------------------------------------------------");

                    }
                    else
                    {
                        Console.WriteLine("La couleur Rouge est tombée vous avez : Perdu!");
                        perte = mise;
                        fonds = fonds - mise;
                        pertesTotales = pertesTotales + perte;
                        Console.WriteLine("Fonds restant après Perte : " + fonds);
                        Console.WriteLine("Gains Totaux : " + gainsTotaux);
                        Console.WriteLine("Pertes Totales : " + pertesTotales);
                        Console.WriteLine("Total Gains-Pertes : " + (gainsTotaux - pertesTotales));
                        Console.WriteLine("-----------------------------------------------------");
                    }
                }
                else if (saisieCouleur == "r") //rouge gagné
                {
                    Console.WriteLine("Choisissez votre mise !");
                    miseDeJeu = Console.ReadLine();
                    bool success = Int32.TryParse(miseDeJeu, out int mise);
                    ///////////////////////////////////////////////
                    // Random couleurHasard = new Random();      //
                    // couleurHas = couleurHasard.Next(1, 3);    //
                    // Console.WriteLine(/*"has" + */couleurHas);//
                    ///////////////////////////////////////////////
                    couleurChoisie = 2;
                    Console.WriteLine(couleurChoisie);
                    if (couleurChoisie == couleurHas)
                    {
                        Console.WriteLine("La couleur Rouge est tombée vous avez : Gagné!");
                        gain = mise;
                        fonds = fonds + mise + gain;
                        gainsTotaux = gainsTotaux + gain;
                        Console.WriteLine("Fonds restant après Gain : " + fonds);
                        Console.WriteLine("Gains Totaux : " + gainsTotaux);
                        Console.WriteLine("Pertes Totales : " + pertesTotales);
                        Console.WriteLine("Total Gains-Pertes : " + (gainsTotaux - pertesTotales));
                        Console.WriteLine("-----------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("La couleur Noire est tombée vous avez : Perdu!");
                        perte = mise;
                        fonds = fonds - mise;
                        pertesTotales = pertesTotales + perte;
                        Console.WriteLine("Fonds restant après Perte : " + fonds);
                        Console.WriteLine("Gains Totaux : " + gainsTotaux);
                        Console.WriteLine("Pertes Totales : " + pertesTotales);
                        Console.WriteLine("Total Gains-Pertes : " + (gainsTotaux - pertesTotales));
                        Console.WriteLine("-----------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                }
            }
        }
    }
}



