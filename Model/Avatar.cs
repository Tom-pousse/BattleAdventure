namespace BattleAdventure.Model
{
    public class Avatar
    {
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        public string Nom { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        public string Type { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Force { get; set; }
        public int Endurance { get; set; }
        public int Agilite { get; set; }
        public int Vie { get; set; }
        public int Dommage { get; set; }

        Random random = new Random();
        public int CalculDamage()
        {
            int Critique = random.Next(1, 3);
            int DegatTotal = (Force * 4) + (Critique * Agilite);

            return DegatTotal;
        }

        public int CalculVie()
        {
            int Hp = (Endurance * 10) + (Level * 80) + (Agilite * 1) + (Force * 2);

            return Hp;
        }

        public int Attaque(Monstre monstreA, Monstre monstreB)
        {
            if (monstreB.Vie < 0 || monstreA.Vie < 0)
            {
                Console.WriteLine("Perdu");
            }
            else
            {
                CalculDamage();
                monstreB.Vie -= monstreA.Dommage;
                Console.WriteLine(monstreB.Vie);
            }
            return monstreB.Vie;
        }

        public override string ToString()
        {
            return $"\n Nom: {Nom}\n Type: {Type}\n Force: {Force}\n Endurance: {Endurance}\n Agilite: {Agilite}\n Points de vie: {Vie}\n Dommage: {Dommage}";
        }
    }
}
