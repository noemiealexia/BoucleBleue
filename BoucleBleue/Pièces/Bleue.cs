using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoucleBleue.Pièces
{
    internal class Bleue : Room
    {
        internal override void ViewDescription()
        {
            Console.WriteLine("\n\tTu te retrouves dans une pièce peinturée tout en bleu." +
                "\n\tLes lumières clignotent. Tu ressens un effroiement, mais tu ne sais pas pourquoi." +
                "\n\tUne petite musique rentit dans la pièce. On dirait une chanson venant d'une boîte à musique." +
                "\n\tLa pièce semble complètement vide, excepté une [poupée] assise sur une chaise. Son regard est aussi vide que la pièce." +
                "\n\tCette salle t'engenre un malaise profond. Tu veux partir." +
                "\n\tIl n'y a pourtant rien qui cloche à première vue. Tu ne sais pas pourquoi tu te sens comme ça." +
                "\n\tUne petite voix à l'intérieur de toi te dit de partir de cette pièce le plus vite possible." +
                "\n\tTu ressens l'anxiété et la panique monter en toi. Dépêches-toi.");
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "poupée":
                    if (Jeu.Fin03 == true)
                    {
                        Console.WriteLine("\nLa poupée est magnifique. Elle a une belle boucle bleue dans ses cheveux." +
                                          "\nElle te regarde. Elle semble terrifiée de toi." +
                                          "\nPoupée: Ne me tues pas. Ça fait mal, BOUCLE." +
                                          "\nToi: Quoi? Mais bien sur que non poupée, je ne te tuerais pas." +
                                          "\nPoupée: Souviens-toi, BOUCLE." +
                                          "\nTu es destabilisée. Tu ne sais pas de quoi la poupée parle. Elle doit être folle." +
                                          "\nPoupée: Sors d'ici, BOUCLE." +
                                          "\nElle te remet une petite clé blanche."
                                          );
                        Jeu.HasGreenKey = true;
                        Jeu.HasOrangeKey = true;
                    }
                    else if (Jeu.HasYellowKey)
                    {
                        Console.WriteLine("\nLa poupée voit le couteau que tu as dans les mains. Elle semble excitée." +
                                          "\nPoupée: OUI. TUES MOI." +
                                          "\nTu coupes le ventre de la poupée. Elle semble regretter ses mots immédiatement." +
                                          "\nPoupée: NON. STOP. ÇA FAIT MAL." +
                                          "\nLe ventre de la poupée ne contient rien. Tu essaies ses yeux. La poupée crie de douleur." +
                                          "\nDerrière ses yeux tu trouves une clé en or.");
                        Console.WriteLine("\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 03:  - - -");
                        Jeu.Fin02 = true;
                        Jeu.isFinished = true;
                    }
                    else
                    {
                        Console.WriteLine("\nLa poupée est magnifique. Elle a une belle boucle bleue dans ses cheveux." +
                        "\nTu l'observes. Elle ne dit rien. Ses yeux sont vers toi, mais elle ne semble pas te regarder." +
                        "\nToi: Quel est ton nom poupée?" +
                        "\nPoupée: ..." +
                        "\nToi: Est-ce que je peux t'aider? Où sommes-nous?" +
                        "\nPoupée: ..." +
                        "\nTu saisies la poupée dans tes bras, elle semble t'apercevoir pour la première fois. Elle sourit." +
                        "\nPoupée: Bonjour toi! Wow comme tu es jolie! Je suis jalouse!" +
                        "\nToi: Est-ce que ça va? Cet endroit est étrange. Je ne sais pas où je suis." +
                        "\nPoupée: Mais voyons Boucle, tu es chez toi." +
                        "\nLe sourire de la poupée disparait. Ses yeux deviennent rouges et pleins de sang." +
                        "\nPoupée: TUE-MOI. JE T'EN SUPPLIE." +
                        "\nLa poupée qui s'était mise à crier quelques secondes plus tôt retrouve son regard vide. Elle est calme. Ses yeux sont de nouveau normaux." +
                        "\nToi: Quoi?" +
                        "\nPoupée: J'ai dit, tu es chez toi. Comme je suis chez moi. Nous sommes tous les deux où nous devons être." +
                        "\nToi: ... Pourquoi veux-tu que je te tues?" +
                        "\nLa poupée semble horrifiée." +
                        "\nPoupée: Me tuer?! Mais bien sûr que non, nous sommes bien ici, ne trouves-tu pas?" +
                        "\n[Oui] ou [Non]?");

                        Jeu.HasGreenKey = true;
                    }
                    break;
                case "oui":
                     Console.WriteLine("\nPoupée: Bien sûr, hihihihihi. Quelles drôles d'idées tu as, boucle." +
                         "\nToi: Tu sembles me connaître. Est-ce qu'on s'est déjà rencontré?" +
                         "\nDu sang coule des yeux de la poupée." +
                         "\nPoupée: TUES-MOI." +
                         "\nLa poupée semble complètement différente. Elle crie et le sang abondant coulant de ses yeux la rend terrifiante.\nTu recules tranquillement, continuer de lui parler n'est pas une bonne idée." +
                         "\nTu te retournes vers la poupée lorsque tu entends un objet métallique tomber au sol." +
                         "\nElle semble de retour à la normale. Une petite clé blanche est par terre. Tu la prends.");
                    Jeu.HasOrangeKey = true;
                    break;
                case "non":
                    //image de Boucle bleue creepy
                    Console.WriteLine("\nLa musique arrête. Un silence terrifiant t'enveloppe. La poupée ne sourit plus.");
                    for (int i = 3;i >= 0; i--)
                    {
                        Console.WriteLine("\nNous sommes bien ici.");
                    }
                    Console.WriteLine("\nNOUS SOMMES BIEN ICI.");
                    //image de Boucle sans yeux
                    Console.WriteLine("\nTu n'es pas certaine d'où cette voix provient... Es-tu en train de devenir folle?\nEst-ce que ça venait de... ta tête?\nAvant de pouvoir répondre, les mains de la poupée sont autour de ton cou." +
                                      "\nPoupée: MAUDITE BOUCLE. JE VEUX MOURIR.\nLes mains de la poupée serrent ton cou." +
                                      "\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 02: Nous sommes bien ici - - - ");

                    Jeu.Fin02 = true;
                    Jeu.isFinished = true;
                    break;
                case "porte rose":
                    Console.WriteLine("Tu ouvres la porte et entre dans la chambre rose.");
                    Jeu.nextRoom = "Rose";
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }     
            
        }
    }
}
