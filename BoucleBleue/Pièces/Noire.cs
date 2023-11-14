﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Noire : Room
    {
        internal override void ViewDescription()
        {
            Console.WriteLine("\n\tLa pièce est peinturée de noir. L'atmosphère est horrible." +
                              "\n\tTu entends des centaines de cris aigus en écho. Le son est faible, mais assez dérangeant pour te rendre folle." +
                              "\n\tUn [mannequin] sans tête est au coin de la pièce. Tu sens qu'il est vivant et qu'il t'observe, malgré le fait qu'il n'a pas de visage." +
                              "\n\tLa seule porte est la [porte blanche] d'où tu proviens." +
                              "\n\tIl y a une [énigme] sur le mur à l'ouest et une [chaise] au sud de la pièce.");
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte blanche":
                    Console.WriteLine("\nTu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Blanche";
                    break;
                case "chaise":
                    Console.WriteLine("\nSur la chaise, il y a un [couteau] et une [note].");
                    break;
                case "couteau":
                    Console.WriteLine("\nTu prends le couteau.");
                    Jeu.HasKnife = true;
                    break;
                case "note":
                    Console.WriteLine("\nSur la note est écrit:\n\n");
                    Console.WriteLine("\t\t *********************** ");
                    Console.WriteLine("\t\t **                   ** ");
                    Console.WriteLine("\t\t **                   ** ");
                    Console.WriteLine("\t\t ** POUR SORTIR D'ICI ** ");
                    Console.WriteLine("\t\t **    TU DOIS TUER.  ** ");
                    Console.WriteLine("\t\t **                   ** ");
                    Console.WriteLine("\t\t **                   ** ");
                    Console.WriteLine("\t\t *********************** ");
                    Console.WriteLine("\nTu sais maintenant ce que tu dois faire, mais qui devrais-tu tuer?");
                    break;
                case "mannequin":
                    if (Jeu.HasKnife)
                    {
                       Console.WriteLine("\nTu coupes le ventre du mannequin." +
                                         "\nAu lieu de mourir, une tête pousse du cou du mannequin." +
                                         "\nIl n'y a pas de yeux, qu'une énorme bouche terrifiante et pleine de dents." +
                                         "\nSes crocs sur ton visage et une haleine horrible sont tes dernières sensations.");
                       Console.WriteLine("\n\n\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 03: Mauvais choix  - - -");
                       Jeu.Fin03 = true;
                       Jeu.isFinished = true;
                    }
                    else
                    {
                       Console.WriteLine("\nPeu importe ce que tu essaies de dire au mannequin, il ne te répond pas." +
                                         "\nUn grognement t'indique qu'il n'est pas ton ami." +
                                         "\nTu ressens même une haine envers toi. Tu recules doucement.");
                    }
                    break;
                case "énigme":
                    Console.WriteLine("\nSur le mur est écrit: " +
                                      "\n\tPlus je suis courte, plus je suis mauvaise. Plus je suis mauvaise, plus je trahis." +
                                      "\n\tQui suis-je?");
                    break;
                case "mémoire":
                    Console.WriteLine("\nTu entends un clic retentir de la pièce blanche.");
                    Jeu.HasYellowKey = true;
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }
    }
}
