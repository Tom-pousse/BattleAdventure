namespace BattleAdventure.Pages
{
    public partial class Jeu
    {

        string EnvoiePageJeu ="";
        string test = "";
        protected override void OnInitialized()
        {
            base.OnInitialized();
            test = EnvoiePageJeu;
            Console.WriteLine("page jeu"+test);
        }

        //private void RetourCallback(string retour)
        //{
        //    Console.WriteLine($"Mon enfant me dit: {retour}");
        //}

    }
}

