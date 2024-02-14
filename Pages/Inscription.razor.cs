namespace BattleAdventure.Pages
{
    public partial class Inscription
    {
        public Inscription() { info = login; }
        bool logOrReg = false;
        string login = "Déja un compte ?";
        string registred = "Pas encore inscrit ?";

        string info = "";
        protected override void OnInitialized()
        {
            base.OnInitialized();
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            TransmissionDeValeur(logOrReg);
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
        }

        private void InversLog()
        {
            logOrReg = !logOrReg;
            if (logOrReg == false)
            {
                info = login;
            }
            else
            {
                info = registred;
            }
        }

#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        private async Task TransmissionDeValeur(bool MaValeurDeComposantInscritpion)
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            if (MaValeurDeComposantInscritpion)
            {
                InversLog();
            }
            else
            {
                Console.WriteLine("nop");
            }
        }
    }
}
