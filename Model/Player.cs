namespace BattleAdventure.Model
{
    public class Player
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }

        
        public override string ToString()
        {
            return $"\n Nom: {Nom}\n Prenom: {Prenom}\n Email: {Email}\n MotDePasse: {MotDePasse}";
        }
    }

}
