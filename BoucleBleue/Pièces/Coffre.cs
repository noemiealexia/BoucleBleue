﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Coffre : Room
    {
        internal override void ViewDescription()
        {
            Console.WriteLine("\n\tTu regardes dans le grand coffre à jouets, mais tu sens une pression dans ton dos qui te fait tomber à l'intérieur." +
                "\n\tLe couvercle du coffre à jouets se referme au dessus de toi. Tu entends les peluches rirent." +
                "\n\tTu essaies de leur dire que ce n'est pas drôle et de te laisser sortir, mais ils ne font que ricaner plus fort." +
                "\n\tTu aperçois une [clé] bleue sur le sol.");
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "non":

                    Console.WriteLine("\nEffrayée, tu te mets à cogner sur le couvercle du coffre, mais les oursons se moquent de toi." +
                        "\nUne autre voix que celles des peluches retentit autour de toi. Plus forte, plus calme et plus grave." +
                        "\nMEURS." +
                        "\nLes poupées ne rient plus." +
                        "\nLe liquide noir continue de couler autour de toi, tu penses te noyer dedans." +
                        "\nTu te mets à crier." +
                        "\nToi: NON. NON. NON. NON. NON." +
                        "\nLes peluches ouvrent le courvecle et laisse sortir. Leur sourire est déstabilisant.");
                    Jeu.HasRedKey = true;
                    Jeu.nextRoom = "Jaune";
                    break;
                case "clé":
                    Console.WriteLine("\nTu prends la clé bleue." +
                    "\nTu sens une goutte tomber sur ta joue. Tu y touches, le liquide est visceux et noir. Tu ne sais pas c'est quoi." +
                    "\nLorsque tes yeux s'ajustent à la noirceur, tu remarques des mots engravés dans le coffre." +
                    "\nRESTE POUR TOUJOURS." +
                    "\nPoupée, veux-tu rester pour toujours?" +
                    "\n[OUI] ou [NON]");
                    break;
                case "oui":
                    Console.WriteLine("\nIci pour toujours.");
                    for (int i = 7; i >= 0; i--)
                    {
                        Console.WriteLine("Pour toujours.");
                        Console.ReadKey();
                    }
                    Console.WriteLine("\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 01: POUR TOUJOURS - - -");
                    Jeu.Fin01 = true;
                    Jeu.isFinished = true;
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }

    }
}
