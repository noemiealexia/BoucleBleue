using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Blanche : Room
    {
        internal override void ViewDescription()
        {

        if (Jeu.HasYellowKey)
            {
                Console.WriteLine("\n\tLa pièce est maintenant éclairée. Elle est complètement blanche et sans décoration." +
                   "\n\tLe mur à l'ouest est recouvert de [sang]." +
                   "\n\tUne grande [porte rouge] semble indiquer la sortie." +
                   "\n\tUne [porte noire] est au sud et une [porte jaune] est à l'est.");


            }
            else
            {
                Console.WriteLine("\n\tLa pièce est complètement sombre." +
                                  "\n\tTu ne vois que la [porte jaune] derrière toi." +
                                  "\n\tTu pourrais aussi [explorer].");
            }
        }

        internal override async void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte noire":
                    Console.WriteLine("\nTu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Noire";
                    break;
                case "porte jaune":
                    Console.WriteLine("\nTu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Jaune";
                    break;
                case "explorer":
                    Console.WriteLine("\nVeux-tu aller au [nord], à l'[est], à l'[ouest] ou au [sud]?");
                    break;
                case "nord":
                    Console.WriteLine("\nTu sens une grande porte. Beaucoup plus grande que les autres. Elle est vérouillée.");
                    break;
                case "est":
                    Console.WriteLine("\nC'est la porte jaune, d'où tu proviens.");
                    break;
                case "sud":
                    Console.WriteLine("\nIl y a une [porte noire] dans laquelle tu peux entrer.");
                    break;
                case "ouest":
                    Console.WriteLine("\nDans la noirceur, tu mets tes mains sur le mur pour te retrouver. Tu sens tes mains tachées d'un liquide." +
                                      "\nTu les mets près de ton visage et tu réalises que c'est du sang." +
                                      "\nLe mur est couvert de sang. Tu recules.");
                    break;
                case "porte rouge":
                    if (Jeu.HasGoldKey)
                    {
                        Console.WriteLine("\nTu utilises la clé en or." +
                                          "\nTu sors par la porte rouge.\nPourquoi t'es-tu réveillée ici? Qui était la poupée que tu as tuée?" +
                                          "\nCe sont des questions pour plus tard. Enfin libre." +
                                          "\nTu es enfin sortie et pourtant, l'entité qui te terrifiait est encore présente." +
                                          "\nUne voix te dit que ce n'est pas fini, mais tu ne reconnais pas la voix." +
                                          "\nTu reconnais vaguement la pièce, mais tu es trop fatiguée pour y faire du sens. Tu t'endors.");
                        Console.WriteLine("\n\n\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 04: Fin normale - - -");
                        Jeu.Fin04 = true;
                        Jeu.isFinished = true;
                    }
                    else
                    {
                        Console.WriteLine("\nLa porte est vérouillée. Tu vois une serrure en or sur la porte.");
                    }
                    break;
                case "sang":
                    Console.WriteLine("\nLe sang continue de couler des murs." +
                                      "\nLe flot ne semble jamais s'arrêter." +
                                      "\nUne goutte vole sur ta joue, et tu dis 'Beurk' à voix haute." +
                                      "\nLe sang sur le mur change de forme et tu crois reconnaître des lettres.");
                    Console.WriteLine("\nM");
                    Thread.Sleep(1000);
                    Console.WriteLine("E");
                    Thread.Sleep(1000);        
                    Console.WriteLine("U");
                    Thread.Sleep(1000);
                    Console.WriteLine("R");
                    Thread.Sleep(1000);
                    Console.WriteLine("S");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nLe mur semble te parler. Lorsque tu dis quelque chose à voix haute, il te répond." +
                                      "\nPoupée: Me comprends-tu?");
                    Console.WriteLine("\nO");
                    Thread.Sleep(1000);
                    Console.WriteLine("U");
                    Thread.Sleep(1000);
                    Console.WriteLine("I");
                    Console.WriteLine("\nTu essaies de parler au mur. Mais il ne fait que répéter 'MEURS'...\nTu n'es pas certaine, mais tu crois que le mur attend quelque chose.\nPeut-être y a-t-il un mot qu'il aimerait entendre?");
                    break;
                case "boucle":
                    Console.WriteLine("\nEn disant le mot boucle, le sang coulant du mur s'éparpille sur tous les autres murs.\nBientôt, il coule même du plafond." +
                                      "\nEnfin, après avoir été recouvert du sang, tu le vois se transformer en bleu.\nTout d'un coup, tout autour de toi est bleu. Les murs, les meubles, ta robe, la boucle dans tes cheveux, ... maintenant bleus." +
                                      "\nTu ne te sens pas bien et tu t'évanouis.");
                    Console.WriteLine("\n\n\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 05: Vraie fin - - -");
                    Jeu.nextRoom = "Fin";
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }
    }
}
