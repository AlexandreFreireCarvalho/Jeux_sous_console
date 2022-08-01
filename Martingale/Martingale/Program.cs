using System;
namespace La_Martingale
    //Le 11/09 2020
    //FREIRE CARVALHO ALEXANDRE
{
    class Program
    {
        static void Main(string[] args)
        {
            int fonds = 100;//fonds de départ
            Console.WriteLine("Fonds de base : " + fonds);
            int mise;//mise de jeu
            int gain;
            int perte;
            int partie = 0;
            int gainsTotaux = 0;
            int pertesTotales = 0;
            int couleurChoisie;
            string choixCouleur;
            string miseDeJeu;
            string saisieCouleur;


            while (fonds > 0)
            {
                partie++;
                Console.WriteLine("Partie numéro : " + partie);
                Console.WriteLine("Choisissez la couleur à miser (n/r) : ");
                saisieCouleur = Console.ReadLine();
                //////////////////////////////////////////////////////////////
                if (saisieCouleur == "n")
                {
                    Console.WriteLine("Choisissez votre mise !");
                    miseDeJeu = Console.ReadLine();
                    mise = int.Parse(miseDeJeu);
                    ///////////////////////////////////////////////
                    Random couleurHasard = new Random();
                    int couleurHas = couleurHasard.Next(1, 3);
                    //Console.WriteLine(/*"has" + */couleurHas);
                    ///////////////////////////////////////////////
                    couleurChoisie = 1;
                    //Console.WriteLine("Line56" + couleurChoisie);
                    if (couleurChoisie == couleurHas)
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
                else if (saisieCouleur == "r")
                {
                    Console.WriteLine("Choisissez votre mise !");
                    miseDeJeu = Console.ReadLine();
                    mise = int.Parse(miseDeJeu);
                    ///////////////////////////////////////////////
                    Random couleurHasard = new Random();
                    int couleurHas = couleurHasard.Next(1, 3);
                    //Console.WriteLine(/*"has" + */couleurHas);
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



