namespace BattleAdventure.Model
{
    public class Avatar
    {
        public string Nom = "Winnie";
        public string Type = "Ours";
        public int Level = 1;
        public int Experience = 0;
        public int Force { get; set; }
        public int Endurance { get; set; }
        public int Agilite { get; set; }
        public int Vie { get; set; }
        public int Dommage { get; set; }

        Random random = new Random();
        public int CalculDamage(Avatar avatar)
        {
            int Critique = random.Next(1, 3);
            int DegatTotal = (avatar.Force * 4) + (Critique * Agilite);

            return DegatTotal;
        }

        public int CalculVie(Avatar avatar)
        {
            int Hp = (avatar.Endurance * 10) + (avatar.Level * 80) + (avatar.Agilite * 1) + (avatar.Force * 2);

            return Hp;
        }

        public int Attaque(Avatar monstreA, Monstre monstreB)
        {
            if (monstreB.Vie < 0 || monstreA.Vie < 0)
            {
                Console.WriteLine("MonstreA" + monstreA.Vie); 
                Console.WriteLine("MonstreB" + monstreB.Vie);
            }
            else
            {
                CalculDamage(monstreA);
                monstreB.Vie -= monstreA.Dommage;
                
                Console.WriteLine("MonstreA"+ monstreA.Vie); 
                Console.WriteLine("MonstreB"+ monstreB.Vie);
            }
            return monstreB.Vie;
        }

        public override string ToString()
        {
            return $"\n Nom: {Nom}\n Type: {Type}\n Force: {Force}\n Endurance: {Endurance}\n Agilite: {Agilite}\n Points de vie: {Vie}\n Dommage: {Dommage}";
        }

       
        


    }
}
