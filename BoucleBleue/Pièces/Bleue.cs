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
            Console.WriteLine("@Tu te retrouves dans une chambre toute bleue. Les lumières clignotent, mais tout semble tranquille. Tu ressens un certain sentiment de vide, et en même temps tu aperçois une paire de yeux qui t'observent. Une [poupée] est assise sur une chaise au bout de la pièce. Elle porte une jolie robe bleue et rose, et a plusieurs boucleS dans ses cheveux. Elle te sourit et avec un signe de la main, t'invite à s'approcher d'elle.");
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "poupée":
                    //dialogue
                    break;
                case "porte rose":
                    Console.WriteLine("Tu ouvres la porte et entre dans la chambre rose.");
                    // nextRoomToGo = "Jaune";
                    Jeu.nextRoom = "Rose";
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }     
            
        }
    }
}
