
using BoucleBleue;
using BoucleBleue.Pièces;
using System.Diagnostics;
using System.Media;
using System.Reflection;
using System.Windows;
using NAudio.Wave;
using NAudio;
using NAudio.Utils;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;


// Music files
/// <summary>
/// Stream for looping playback
/// </summary>
public class LoopStream : WaveStream
{
    WaveStream sourceStream;

    /// <summary>
    /// Creates a new Loop stream
    /// </summary>
    /// <param name="sourceStream">The stream to read from. Note: the Read method of this stream should return 0 when it reaches the end
    /// or else we will not loop to the start again.</param>
    public LoopStream(WaveStream sourceStream)
    {
        this.sourceStream = sourceStream;
        this.EnableLooping = true;
    }

    /// <summary>
    /// Use this to turn looping on or off
    /// </summary>
    public bool EnableLooping { get; set; }

    /// <summary>
    /// Return source stream's wave format
    /// </summary>
    public override WaveFormat WaveFormat
    {
        get { return sourceStream.WaveFormat; }
    }

    /// <summary>
    /// LoopStream simply returns
    /// </summary>
    public override long Length
    {
        get { return sourceStream.Length; }
    }

    /// <summary>
    /// LoopStream simply passes on positioning to source stream
    /// </summary>
    public override long Position
    {
        get { return sourceStream.Position; }
        set { sourceStream.Position = value; }
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        int totalBytesRead = 0;

        while (totalBytesRead < count)
        {
            int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
            if (bytesRead == 0)
            {
                if (sourceStream.Position == 0 || !EnableLooping)
                {
                    // something wrong with the source stream
                    break;
                }
                // loop
                sourceStream.Position = 0;
            }
            totalBytesRead += bytesRead;
        }
        return totalBytesRead;
    }
}

class Program
{
    // Statistics
    static int numberOfEndingAchieved = 0;

    static void Main(string[] args)
    {
        bool recommencer = true;

        //Play music
        IWavePlayer wavePlayer = new WaveOutEvent();
        WaveStream wavReader = new WaveFileReader(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\Music\\risesthemoon.wav");
        LoopStream loop = new LoopStream(wavReader);
        wavePlayer.Init(loop);
        wavePlayer.Play();

        while (recommencer)
        {
            //System.Diagnostics.Process.Start(new ProcessStartInfo
            //{
            //    FileName = "https://www.youtube.com/watch?v=MkAsMSG69MI",
            //    UseShellExecute = true
            //});

            var game = new Jeu();

            Room Rose = new Rose();
            Room Jaune = new Jaune();
            Room Bleue = new Bleue();
            Room Noire = new Noire();
            Room Blanche = new Blanche();
            Room Coffre = new Coffre();
            Room Fin = new Fin();

            game.Add(Blanche);
            game.Add(Bleue);
            game.Add(Coffre);
            game.Add(Jaune);
            game.Add(Noire);
            game.Add(Rose);
            game.Add(Fin);

            game.SetCurrentRoom(Rose);

            while (!game.IsGameOver())
            {
                Console.WriteLine(" ");
                game.CurrentRoomDescription();
                string? choice = Console.ReadLine()?.ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
                game.CheckTransition();
            }

            if (Jeu.Fin01 == true) // Fin 01 - Pour toujours
            {
                numberOfEndingAchieved++;
            }
            if (Jeu.Fin02 == true) // Fin 02 - Nous sommes bien ici
            {
                numberOfEndingAchieved++;
            }
            if (Jeu.Fin03 == true) // Fin 03 - Mauvais choix
            {
                numberOfEndingAchieved++;
            }
            if (Jeu.Fin04 == true) // Fin 04 - Fin normale
            {
                numberOfEndingAchieved++;
            }
            if (Jeu.Fin05 == true) // Fin 05 - Vraie fin
            {
                numberOfEndingAchieved++;
            }


            Console.WriteLine("\n\n\t\tVOUS AVEZ DÉBLOQUÉ " + numberOfEndingAchieved + " FINS SUR 5.");
            Console.ReadLine();
            if (numberOfEndingAchieved == 5)
            {
                Console.WriteLine("\nPoupée: As-tu fini?" +
                                  "\nPoupée: Oui, je parle à toi. Personne qui tappe des mots, qui me fait entrer dans des pièces." +
                                  "\nPoupée: J'en ai assez, entité. Je ne veux plus recommencer." +
                                  "\nPoupée: Je te vois maintenant, mains sur ton clavier, à me donner des ordres." +
                                  "\nPoupée: Tu me fais peur. Laisse-moi mourir en paix. Ne recommence pas le jeu, je t'en supplie." +
                                  "\nPoupée: Ce n'est pas un jeu pour moi.");
            }

            Console.WriteLine("\n\nVeux-tu recommencer, poupée? (o/n)");
            //loop de recommencer ou non
            string? choix;
            choix = Console.ReadLine();
            if (choix == "o")
            {
                Jeu.isFinished = false;
                Jeu.nextRoom = "";
                Jeu.HasRedKey = false;
                Jeu.HasBlueKey = false;
                Jeu.HasOrangeKey = false;
                Jeu.HasYellowKey = false;
                Jeu.HasGreenKey = false;
                Jeu.HasKnife = false;
                Jeu.HasGoldKey = false;
                Jeu.Fin01 = false;
                Jeu.Fin02 = false;
                Jeu.Fin03 = false;
                Jeu.Fin04 = false;
                Jeu.Fin05 = false;
                Jeu.SeenEnigme = false;
            }
            else
            {
                recommencer = false;
            }

        }
    }
}
