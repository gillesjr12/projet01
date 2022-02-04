using System;
using System.Data.SqlClient;
using System.Threading;


namespace Dices
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // initialisation des variables de résultats
            int playerRoll,computerRoll;
            Random randomInt = new Random();
            // initialisation des variables statistiques
            int gamesPlayed = 0, gamesWon = 0, gamesLost = 0, gamesTied = 0;
            // Initialisation des variables de contrôle
            bool programIsRunning = true;
            ConsoleKeyInfo keyPressed;
            //Instructions
            Console.WriteLine("Bienvenue au jeu de dés ! " +
                                  "\n Appuyez sur ESPACE pour jouer, " +
                                  "\n S pour voir les statistiques " +
                                  "\n et Q pour quitter");
            // tant que program is running = vrai, on "loop"
            while (programIsRunning)
            {
                keyPressed = Console.ReadKey();
                // si la touche espace est appuyée, on joue
                if (keyPressed.Key == ConsoleKey.Spacebar)
                {
                    // effacer l'écran
                    Console.Clear();
                    // ajouter 1 au nombre de parties jouees
                    gamesPlayed++;
                    // generer les scores des deux joueurs
                    playerRoll = randomInt.Next(1, 6);
                    computerRoll = randomInt.Next(1, 6);
                    // comparer les scores
                    // si les scores ne sont pas égaux, verifier...
                    if (playerRoll != computerRoll)
                    {
                        // si joueur à gagné
                        if (playerRoll > computerRoll)
                        {
                            
                            ShowScores(playerRoll,computerRoll,"Win");
                            Console.WriteLine("Vous avez gagné");
                            PlaySong("Win");
                            gamesWon++;
                        }
                        else
                        {
                            // sinon le joueur à perdu
                            ShowScores(playerRoll,computerRoll,"Lose");
                            Console.WriteLine("Vous avez perdu");
                            PlaySong("Lose");
                            gamesLost++;
                        }
                    }
                    else
                    {
                        // sinon, les scores sont égaux
                        ShowScores(playerRoll,computerRoll,"Equal");
                        Console.WriteLine("Le score est égal");
                        PlaySong("Equal");
                        gamesTied++;
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                // si la touche q est appuyée
                else if (keyPressed.Key == ConsoleKey.Q)
                {
                    programIsRunning = false;
                }
                else if (keyPressed.Key == ConsoleKey.S)
                {
                    Console.WriteLine("Statistiques : Sur un total de "+ gamesPlayed + " parties dont " + gamesTied + " nulles" +
                                      "\n Vous avez gagné " + gamesWon + " parties contre " 
                                      + gamesLost + " pour votre adversaire");
                    
                }
            }
        }

        public static void GenererDe(int score)
        {
            switch (score)
            {
             case 1:
                 Console.WriteLine("~~~~~~~");
                 Console.WriteLine("|     |");
                 Console.WriteLine("|  *  |");
                 Console.WriteLine("|     |");
                 Console.WriteLine("~~~~~~~");
                 break;
             case 2:
                 Console.WriteLine("~~~~~~~");
                 Console.WriteLine("| *   |");
                 Console.WriteLine("|     |");
                 Console.WriteLine("|   * |");
                 Console.WriteLine("~~~~~~~");
                 break;
             case 3:
                 Console.WriteLine("~~~~~~~");
                 Console.WriteLine("| *   |");
                 Console.WriteLine("|  *  |");
                 Console.WriteLine("|   * |");
                 Console.WriteLine("~~~~~~~");
                 break;
             case 4:
                 Console.WriteLine("~~~~~~~");
                 Console.WriteLine("| * * |");
                 Console.WriteLine("|     |");
                 Console.WriteLine("| * * |");
                 Console.WriteLine("~~~~~~~");
                 break;
             case 5:
                 Console.WriteLine("~~~~~~~");
                 Console.WriteLine("| * * |");
                 Console.WriteLine("|  *  |");
                 Console.WriteLine("| * * |");
                 Console.WriteLine("~~~~~~~");
                 break;
             case 6:
                 Console.WriteLine("~~~~~~~");
                 Console.WriteLine("| * * |");
                 Console.WriteLine("| * * |");
                 Console.WriteLine("| * * |");
                 Console.WriteLine("~~~~~~~");
                 break;
            }
        }

        public static void PlaySong(string status)
        {
            switch (status)
            {
                case "Win":
                    Console.Beep(260,100);
                    Console.Beep(329,100);
                    Console.Beep(392,100);
                    Console.Beep(523,100);
                    break;
                case "Lose":
                    Console.Beep(523,100);
                    Console.Beep(392,100);
                    Console.Beep(329,100);
                    Console.Beep(260,100);
                    break;
                case "Equal":
                    Console.Beep(260,100);
                    Console.Beep(523,100);
                    Console.Beep(260,100);
                    Console.Beep(523,100);
                    break;
            }
        }

        public static void ShowScores(int _playerRoll,int _computerRoll, string status)
        {
            bool upDown = true;
            Random valeur = new Random();
            // generer une série de valeurs random (10) dans une table
            for (int i = 0;i<10;i++)
            {
                var nextValue = valeur.Next(1, 6);
                //dessiner le de du joueur
                GenererDe(nextValue);
                if (upDown)
                {
                    Console.Beep(260,100);
                    upDown = !upDown;
                }
                else
                {
                    Console.Beep(523,100);
                    upDown = !upDown;
                }

                // attendre un peu
                Thread.Sleep(300);
                // effacer ecran
                Console.Clear();
            }

            switch (status)
            {
                case "Win":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Lose":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Equal":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                
            }

            GenererDe(_playerRoll);
            Console.WriteLine("Vous avez obtenu " + _playerRoll);
            
            GenererDe(_computerRoll);
            Console.WriteLine("et votre adversaire " + _computerRoll);
        }
    }
}