using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Fin : Room
    {
        internal override void ViewDescription()
        {
      
                Console.WriteLine("\n\n\tTes yeux de poupée s'ouvrent sur une chambre bleue. Les lumières clignotent et une chanson de boîte à musique retentit." +
                    "\n\tTu es assise sur une chaise et tu attends." +
                    "\n\tUne poupée arrive vers toi. Elle te ressemble. Elle est identique à toi." +
                    "\n\tC'est toi. La toi du futur, la toi du passé." +
                    "\n\tTu sens une présence te regarder, quelque chose au delà de la poupée devant toi. Une entitée qui te veut du mal." +
                    "\n\tTu entends la poupée parler, mais tu ne l'écoutes pas, tu regardes le vide en essayant de te concentrer sur la présence de l'entité." +
                    "\n\tLa poupée te saisit dans ses bras. Pauvre poupée, elle ne sait pas encore qu'elle deviendra toi." +
                    "\n\tTu fais de ton mieux pour prétendre être heureuse de la voir. Tu veux la laisser quelques minutes de plus dans l'ignorance de son sort." +
                    "\n\tToi: Bonjour toi! Wow comme tu es jolie! Je suis jalouse!" +
                    "\n\tPoupée: Est-ce que ça va ? Cet endroit est étrange. Je ne sais pas où je suis." +
                    "\n\tTa vie est une BOUCLE. La seule façon de t'en sortir est de mourir." +
                    "\n\tTout ce qui te reste à faire c'est supplier l'autre toi de te tuer.");

        }

        internal override void ReceiveChoice(string choice)
        {

            Console.ReadLine();
            Jeu.Fin05 = true;
            Jeu.isFinished = true;
          
        }
    }
}
