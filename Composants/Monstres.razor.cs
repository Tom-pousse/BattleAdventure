//using BattleAdventure.Model;

//namespace BattleAdventure.Composants
//{
//    public partial class Monstres
//    {
//            Monstre monstre = new Monstre();
//            bool Envoie = false;
//        public Monstres()
//        {

//            InitialistionDeMonstre(monstre);

//        }



//        public void InitialistionDeMonstre(Monstre Monstre1)
//        {


//            monstre.Nom = "";
//            monstre.Type = "";
//            monstre.Experience = 0;
//            monstre.Level = 0;
//            monstre.Force = 0;
//            monstre.Agilite = 0;
//            monstre.Endurance = 0;
//            monstre.Vie = monstre.CalculVie();
//            monstre.Dommage = 0;
//        }

//        public void StatMonstre2()
//        {

//            Random random = new Random();
//            monstre.Nom = "";
//            monstre.Type = "";


//            if (monstre.Level == 1)
//            {
//                monstre.Force = random.Next(1, 5);
//                monstre.Agilite = random.Next(1, 5); ;
//                monstre.Endurance = random.Next(1, 5); ;
//                monstre.Level = 1;
//                monstre.Vie = monstre.CalculVie();
//                monstre.Dommage = 0;
//            }
//            if (monstre.Level == 2)
//            {
//                monstre.Force = random.Next(3, 7);
//                monstre.Agilite = random.Next(3, 7); ;
//                monstre.Endurance = random.Next(3, 6); ;
//                monstre.Level = 2;
//                monstre.Vie = monstre.CalculVie();
//                monstre.Dommage = 0;
//            }
//            if (monstre.Level == 3)
//            {
//                monstre.Force = random.Next(4, 8);
//                monstre.Agilite = random.Next(4, 8); ;
//                monstre.Endurance = random.Next(4, 9); ;
//                monstre.Level = 3;
//                monstre.Vie = monstre.CalculVie();
//                monstre.Dommage = 0;
//            }
//            if (monstre.Level == 4)
//            {
//                monstre.Force = random.Next(5, 10);
//                monstre.Agilite = random.Next(5, 10); ;
//                monstre.Endurance = random.Next(5, 10); ;
//                monstre.Level = 4;
//                monstre.Vie = monstre.CalculVie();
//                monstre.Dommage = 0;
//            }
//            if (monstre.Level == 5)
//            {
//                monstre.Force = random.Next(7, 12);
//                monstre.Agilite = random.Next(7, 13); ;
//                monstre.Endurance = random.Next(7, 12); ;
//                monstre.Level = 4;
//                monstre.Vie = monstre.CalculVie();
//                monstre.Dommage = 0;
//            }
//            Console.WriteLine(monstre);
//        }

//    }
//}







//@* < div class= "card" >
//    @if(Envoie)
//    {
//        < div class= "card" >
//            < div class= "gray" > Nom : @MonPerso.Nom </ div >
//            < div class= "gray" > Type : @MonPerso.Type </ div >
//            < div class= "gray" > Level : @MonPerso.Level </ div >
//            < div class= "gray" > Exp : @MonPerso.Experience </ div >
//            < div class= "gray" > Point de vie : @MonPerso.Vie </ div >
//            < div class= "gray" > Force : @MonPerso.Force </ div >
//            < div class= "gray" > Endurance : @MonPerso.Endurance </ div >
//            < div class= "gray" > Agilité : @MonPerso.Agilite </ div >
//        </ div >
//    }
//    else
//{

//        < form @onsubmit = "MonPersoStat" >

//            < label class= "gray" for= "Nom" > Nom: @MonPerso.Nom </ label >
//            < input type = "text" class= "form-control" id = "Nom" @bind = "MonPerso.Nom" />
//            < label class= "gray" for= "Type" > Type: @MonPerso.Type </ label >
//            < input type = "text" class= "form-control" id = "Type" @bind = "MonPerso.Type" />
//            < div class= "gray" > Level : @MonPerso.Level </ div >
//            < div class= "gray" > Exp:  @MonPerso.Experience </ div >
//            < div class= "gray" > Point de vie : @MonPerso.Vie </ div >
//            < label class= "gray" for= "Force" > Force: @MonPerso.Force </ label >
//            < input type = "number" class= "form-control" id = "Force" @bind = "MonPerso.Force" />
//            < label class= "gray" for= "Endurance" > Endurance: @MonPerso.Endurance </ label >
//            < input type = "number" class= "form-control" id = "Endurance" @bind = "MonPerso.Endurance" />
//            < label class= "gray" for= "Agilite" > Agilite: @MonPerso.Agilite </ label >
//            < input type = "number" class= "form-control" id = "Agilite" @bind = "MonPerso.Agilite" />
//            < button type = "submit" > Valider </ button >
//        </ form >
//    }

//</ div > *@