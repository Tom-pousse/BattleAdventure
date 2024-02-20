namespace BattleAdventure.Composants.Tabeau
{
    public class TabTextCombats
    {
        
        string[] TableauTextCombats = new string[]
         {
            "Ah, un puissant ennemie apparait !",
             "Vous êtes tombés sur un drôle de monstre !",
             "Bon sang ! Un ennemie !",
             "Banzaïïï !!",
         };

        string[] TableauTextQuestion = new string[]
         {
            "Que voulez vous faire ?",
             "Vous choisissez ?",
             "Vite ! Prennez une décision!",
             "Et donc ?",
         };

        string[] TableauTextFight = new string[]
         {
            "vous brandissez votre épé !",
             "vous approchez la bête !",
             "vous criez fort et foncez sur l'enemie !"
             
         };

        string[] TableauTextFightPrefix = new string[]
        {
            "Après une courte réflexion, ",
             "Sans sourciller, ",
             "Tel un Ours mal léché, ",
             "N'écoutant que votre courage, "
        };

        string[] TaleauTextFuite = new string[]
        {
            "WTFFFFFFF ! \n",
            "Vous mouillez votre armure. \n ",
            "Je veux ma maman !!! \n",
            "Merde j'suis un Ours mais il est plus gros que moi ! \n"
        };

        string[] TaleauTextFuiteSufix = new string[]
        {
            "*Vous partez en courrant !* ",
             "*Mais ou êtes passez ?*",
             "*Mes monstre aurons ta fourrure !*",
             "*Mouhahahahaha*"
        };

        public string simulateurDeReponse()
        {
            Random random = new Random();
            string response1 = TableauTextCombats[random.Next(0, TableauTextCombats.Length)];
            string response2 = TableauTextQuestion[random.Next(0, TableauTextCombats.Length)];
            string result = response1 + response2;
            return result;
        }

        public string simulateurDeReponseOui()
        {
            Random random = new Random();
            string response1 = TableauTextCombats[random.Next(0, TableauTextCombats.Length)];
            string response2 = TableauTextFight[random.Next(0, TableauTextCombats.Length)];
            string result = response1 + response2;
            return result;
        }

        public string simulateurDeReponseNon()
        {
            Random random = new Random();
            string response1 = TaleauTextFuite[random.Next(0, TableauTextCombats.Length)];
            string response2 = TaleauTextFuiteSufix[random.Next(0, TableauTextCombats.Length)];
            string result = response1 + response2;
            return result;
            
        }
       
    }
}
