using System;

class App
{
    static void Main(string[] args)
    {
            Console.Clear();
            Console.WriteLine("le Jeux du Papier , Pierre , Ciseaux");
            Console.Title = "jeux du papier , pierre Ciseaux";
            Console.WriteLine(" ");
            Console.WriteLine("Entrer un nom de Joueur");
            string Joueur = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bienvenu " + Joueur + " à toi de jouer");
            Console.WriteLine(" ");
            string choixcomputer;
            Console.WriteLine("Papier , pierre ou ciseaux ");
            Console.WriteLine(" ");
            string ChoixJoueur = Console.ReadLine();
            ChoixJoueur = ChoixJoueur.ToUpper();
            Console.Clear();
            Console.WriteLine("Vous avez choisi : " + ChoixJoueur);
            Console.WriteLine(" ");
            Random random = new Random();
               
            switch ( random.Next(1,4))
            {   
                case 1:
                        choixcomputer = "PAPIER";
                        Console.WriteLine("L'ordinateur à choisi : " + choixcomputer);
                        Console.WriteLine(" ");
                        if (String.Equals(choixcomputer,ChoixJoueur) == true)
                         {
                           Console.WriteLine("Match nul !!");
                         }
                        else if ( ChoixJoueur == "PIERRE")
                         {
                            Console.WriteLine("L'ordinateur gagne !!");
                         }
                        else 
                         {
                            Console.WriteLine("Vous gagnez !!");
                         }
                        break;
                case 2:
                        choixcomputer = "PIERRE";
                        Console.WriteLine("L'ordinateur à choisi : " + choixcomputer);
                        Console.WriteLine(" ");
                         if (String.Equals(choixcomputer,ChoixJoueur) == true)
                         {
                           Console.WriteLine("Match nul !!");
                         }
                        else if ( ChoixJoueur == "PAPIER")
                         {
                            Console.WriteLine("Vous gagnez !!");
                         }
                        else 
                         {
                            Console.WriteLine("L'ordinateur gagne !!!");
                         }
                        break;
                case 3:
                        choixcomputer = "CISEAUX";
                        Console.WriteLine("L'ordinateur à choisi : " + choixcomputer);
                        Console.WriteLine(" ");
                         if (String.Equals(choixcomputer,ChoixJoueur) == true)
                         {
                           Console.WriteLine("Match nul !!");
                         }
                        else if ( ChoixJoueur == "PAPIER")
                         {
                            Console.WriteLine("L'ordinateur gagne !!!");
                         }
                        else 
                         {
                            Console.WriteLine("Vous gagnez !!");
                         }
                        break;
            }
         
    }
}   

