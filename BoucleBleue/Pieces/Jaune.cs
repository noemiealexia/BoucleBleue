using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Jaune : Room
    {

        internal override void ViewDescription()
        {
            if (Jeu.HasRedKey)
            {
                Console.WriteLine("\n\tLa chambre est jaune, il y a une dizaine d'[oursons] en peluche qui t'observent." +
                "\n\tIls ricanent en te regardant. Ils semblent menaçants et agressifs." +
                "\n\tIl y a un grand [coffre] à jouets, des [chaises], un [ballon] gonflable et des petites [tables]." +
                "\n\tUne [porte blanche] est à l'Ouest, une [porte rose] à l'Est.");


            }
            else
            {
                Console.WriteLine("\n\tLa chambre est jaune, il y a une dizaine d'[oursons] en peluche qui t'observent." +
                "\n\tIls te sourient et te disent bonjour. Ils semblent doux et gentils." +
                "\n\tIl y a un grand [coffre] à jouets, des [chaises], un [ballon] gonflable et des petites [tables]." +
                "\n\tUne [porte blanche] est à l'Ouest, une [porte rose] à l'Est.");
            }
          
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte blanche":
                    if (Jeu.HasOrangeKey)
                    {
                        Console.WriteLine("Tu ouvres la porte et entres dans la pièce.");
                        Jeu.nextRoom = "Blanche";
                    }
                    else
                    {
                        Console.WriteLine("La porte est verrouillée.");
                    }
                    break;
                case "porte rose":
                    Console.WriteLine("Tu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Rose";
                    break;
                case "oursons":
                    if (Jeu.HasRedKey)
                    {
                        Console.WriteLine("\nTu t'agenouilles devant l'ourson bleu.");
                        Console.WriteLine("\nPeluche: HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA.\nToi: Pourquoi as-tu fait ça peluche?! J'ai eu peur!\nPeluche: HAHAHAHAHAHAHAHAHAHAHAHA MEURS.\nPeu importe ce que tu essaies de dire à peluche, il ne fait que ricaner comme les autres peluches. Tu te relèves.");

                    }
                    else if (Jeu.HasKnife)
                    {
                        Console.WriteLine("\nTu t'approches de Peluche avec ton couteau derrière le dos." +
                                          "\nLes oursons ricanent toujours. Lorsque Peluche se rend compte de ce que tu t'apprêtes de faire, il est trop tard." +
                                          "\nTu lui coupes le ventre et regardes à l'intérieur, il n'y a rien." +
                                          "\nLes autres oursons te sautent dessus. Ils prennent ton couteau et te tranchent la gorge." +
                                          "\nLe dernier son que tu entends est Peluche qui, même éventré, rit de toi." +
                                          "\nPeluche: HAHAHAHAHAHAHAHHAHAHAHAHAHAHAHAHAHAHA.");

                        Console.WriteLine("\n\n\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 03: Mauvais choix  - - -");
                        Jeu.Fin03 = true;
                        Console.Clear();
                        Jeu.nextRoom = "Noire";
                        Jeu.HasKnife = false;
                    }
                    else
                    {
                        Console.WriteLine("\nTu t'agenouilles devant un ourson bleu.");
                        Console.WriteLine("\nOurs: Bonjour, poupée. Tu es très jolie aujourd'hui.\nToi: Merci Ours. Quel est ton nom?\nOurs: Je m'appelle Peluche. Tous les oursons s'appellent Peluche ici.\nToi: C'est un très joli nom. Mon nom à moi c'est - \nPeluche te coupe la parole.\nPeluche: Je sais qui tu es, boucle.\nToi: Est-ce que c'est la boucle dans mes cheveux qui te l'a dit?\nPeluche: Tu devrais regarder dans le coffre à jouets, poupée. Il y a quelque chose pour toi à l'intérieur.\nToi: Pour moi?! Merci Peluche! Je t'adore!");
                    }
                    break;
                case "chaises":
                    Console.WriteLine("\nTu t'assoies à côté d'un ourson.");
                    if (Jeu.HasRedKey)
                    {
                        Console.WriteLine("\nLa présence à côté de toi est effrayante. L'ourson semble chuchoter un mot en répétition.\nLorsque tu t'approches pour entendre ce qu'il dit, il se met à crier dans ton oreille.");
                        for (int i = 7; i >= 0; i--)
                        {

                            Console.WriteLine("\n\tMEURS.");
                            Thread.Sleep(700);
                        }
                        Console.WriteLine("\nChoquée, tu te relèves et t'en vas.");
                    }
                    else
                    {
                        Console.WriteLine("\nSa présence est calmante. Son regard semble rempli d'amour. Tu te sens joyeuse. Ton coeur de poupée est heureux.");

                    }
                        break;
                case "ballon":
                    Console.WriteLine("\nTu sautes sur le ballon pendant quelques minutes.");
                    break;
                case "tables":
                    Console.WriteLine("\nTu montes sur la table et la vue d'en haut te permet de remarquer une petite clé en arrière du coffre à jouets.");
                    Jeu.Tables = true;
                    break;
                case "coffre":
                    if (Jeu.HasRedKey)
                    {
                        Console.WriteLine("\nTu ne veux pas retourner à l'intérieur. Les poupées ne te laisseraient sûrement pas sortir une autre fois.");
                    }
                    else if (Jeu.Tables == true)
                    {
                        Console.WriteLine("\nTu prends la petite clé et tu l'insères dans le coffre à jouets.");

                        Jeu.nextRoom = "Coffre";
                    }
                    else
                    {
                        Console.WriteLine("\nTu ouvres le coffre à jouets, mais il n'y a rien à l'intérieur.");
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }

        }

         
    }
}
