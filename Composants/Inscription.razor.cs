using BattleAdventure.Model;
using Microsoft.AspNetCore.Components;

namespace BattleAdventure.Composants
{
    public partial class Inscription
    {

#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        private string Nom { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        private string Prenom { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        private string Email { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        private string MotDePasse { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.

        private Player LeJoueur = new();



        public bool Utilisateur = false;

        //si je ne déclare pas le parameter la valeur n'est pas comprise pour le transfere
        //Action<T> est générique env dotnet, eventcallback est spécifique à blazor.
        [Parameter]
        public required EventCallback<bool> ValeurDeUtilisateur { get; set; }


#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        private async Task InscriptionUtilisateur()
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            if (Nom != null && Prenom != null && Email != null && MotDePasse != null)
            {

                LeJoueur.Nom = Nom;
                LeJoueur.Prenom = Prenom;
                LeJoueur.Email = Email;
                LeJoueur.MotDePasse = MotDePasse;



                Console.WriteLine($"Mon joueur: {LeJoueur}");
                //Dans le modele de Joueur j'ai fais un overyde sur tostring pour afficher directement les valeur et eviter de faire cela : 
                //Console.WriteLine($"Mon joueur: Nom={LeJoueur.Nom}, Prenom={LeJoueur.Prenom}, Email={LeJoueur.Email}, MotDePasse={LeJoueur.MotDePasse}");

                if (LeJoueur != null)
                {
                    Utilisateur = true;
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                    ValeurDeUtilisateur.InvokeAsync(Utilisateur);
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                }
                else
                {
                    Console.WriteLine("oups c'est vide faut gerer l'erreur");
                }
            }
            else { Console.WriteLine("pouet ta une valeur nulleeeeeeeuxxxxxx nanananeeeeerrrrrrrreeeeeeuuuuuuuuuu"); }



        }

    }
}

