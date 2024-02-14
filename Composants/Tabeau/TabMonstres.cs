using BattleAdventure.Model;
using System;

namespace BattleAdventure.Composants.Tabeau
{
    public class TabMonstres
    {
        string[] TableauMonstres = new string[]
        {
            "/css/Monstre/SerpR.png",
            "/css/Monstre/SerpVBg.png",
            "/css/Monstre/ChampR.png",
            "/css/Monstre/ChampV.png",
            "/css/Monstre/SldR.png",
            "/css/Monstre/SldV.png",
        };

        public string SelectMonstres()
        {
            
            
            Random random = new Random();
            int MonstreMax = TableauMonstres.Length;
            int Value = random.Next(0,MonstreMax );
            Console.WriteLine(Value.ToString());


            return TableauMonstres[Value];
        }
    } 


}
