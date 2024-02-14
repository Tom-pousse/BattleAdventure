namespace BattleAdventure.Composants;



public partial class Connexion
{

#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
    private string Email { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
    private string MotDePasse { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.

#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
    private async Task ConnexionUtilisateur()
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
    {
        if (Email != null && MotDePasse != null)
        {

            Console.WriteLine($"email: {Email}");
            Console.WriteLine($"mdp: {MotDePasse}");

            NavigationManager.NavigateTo("Jeu");
        }
        else
        {
            Console.WriteLine("Faut ecrire !!");
        }
    }
}
