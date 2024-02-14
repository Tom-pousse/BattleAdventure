﻿using Microsoft.AspNetCore.Components.Web;
using System;
using BattleAdventure.Composants.Tabeau;

namespace BattleAdventure.Composants
{
    public partial class Snake
    {
        readonly TabMonstres _ImageMonstre = new TabMonstres();
        readonly TabTextCombats _Combats = new TabTextCombats();

        string ImageDeMonstre;
        string EvenText = "";
        string LeChoixDuCombatStyle = "display: none;";
        string ReponseDuChoix = "";
        string ChoixDuCombatBtnStyleOui = "display : none;";
        

        int countX = 0;
        int countY =0;
        int PositionTop = 0;
        int PositionLeft = 1;
        int moved = 1;
        int GenX = 0;
        int GenY = 3;

        bool Movement = false;
        bool ChoixUser;
        bool LockAction = false;
        
        

        string CubeStyle => $"top: {PositionTop}%; left: {PositionLeft}%;;";/* */
        string GenCube => $"top: {GenX}%; left: {GenY}%;";

        protected override void OnInitialized()
        {
            ImageDeMonstre = _ImageMonstre.SelectMonstres();
            base.OnInitialized();
            GenX = RandomPos();
            GenY = RandomPos();
            //Console.WriteLine("genX : "+ GenX + "genY : "+ GenY);
        }

        void Move(KeyboardEventArgs args)
        {
            if (LockAction == false) { 
            ChoixDuCombatBtnStyleOui = "display: none;";
            //Console.WriteLine("genX : " + GenX + "genY : " + GenY);
            //Console.WriteLine(args.Key);
            switch (args.Key.ToLower()) 
            {
                case "z":
                    Movement = !Movement;
                    PositionTop -= moved; 
                    countX--;
                    if (countX <= -48)
                    {
                        PositionTop = 47;
                        countX = 47;
                        //Console.WriteLine("je switch" + countX);
                    }
                    //if (countX == GenX && countY == (GenY+3))
                    if (PositionMiam(countX, countY) == true)
                    {
                        EvenText = _Combats.simulateurDeReponse();
                        LeChoixDuCombatStyle = "display: flex; justify-content: space-around;";
                        if (ChoixUser)
                        {
                            
                            ChoixUser = false;
                            StateHasChanged();
                            
                        }
                        else
                        {

                            StateHasChanged();
                        }
                    }
                    break;
                case "s":
                    Movement = !Movement;
                    PositionTop += moved;
                    countX++;
                    if (countX >= 48)
                    {
                        PositionTop = -47;
                        countX = -47;
                        //Console.WriteLine("je switch" + countX);
                    }
                    //if (countX == GenX && countY == (GenY + 3))
                    if (PositionMiam(countX, countY) == true)
                    {
                        EvenText = _Combats.simulateurDeReponse();
                        LeChoixDuCombatStyle = "display: flex; justify-content: space-around;";
                        if (ChoixUser)
                        {
                          
                            ChoixUser = false;
                            StateHasChanged();
                        }
                        else
                        {

                            StateHasChanged();
                        }
                    }
                    break;
                case "q":
                    Movement = !Movement;
                    PositionLeft -= moved;
                    countY--;
                    if (countY <= -48)
                    {
                        PositionLeft = 47;
                        countY = 47;
                        //Console.WriteLine("je switch" + countY);
                    }
                    //if (countX == GenX && countY == (GenY + 3))
                    if (PositionMiam(countX, countY) == true)
                    {
                        EvenText = _Combats.simulateurDeReponse();
                        LeChoixDuCombatStyle = "display: flex; justify-content: space-around;";
                        if (ChoixUser)
                        {
                           
                            ChoixUser = false;
                            StateHasChanged();
                        }
                        else
                        {

                            StateHasChanged();
                        }
                    }
                    break;
                case "d":
                    Movement = !Movement;
                    PositionLeft += moved;
                    countY++;
                    if (countY >= 48)
                    {
                        PositionLeft = -47;
                        countY = -47;
                        //Console.WriteLine("je switch" + countY);
                    }
                    //if (GenX == countX)
                    if (PositionMiam(countX, countY) == true)
                    {
                        EvenText = _Combats.simulateurDeReponse();
                        LeChoixDuCombatStyle = "display: flex; justify-content: space-around;";
                        if (ChoixUser)
                        {
                            
                            ChoixUser = false;
                            StateHasChanged();
                            
                        }
                        else
                        {

                            StateHasChanged();
                        }
                    }
                    break;
            }
            }
            StateHasChanged();
            //Console.WriteLine("hauteurX :" + countX + ",largeurY: " + countY);
            //Console.WriteLine("genX : " + GenX + "genY : " + GenY);

        }

        public int  RandomPos()
        {
            Random random = new Random();
             int x = random.Next(-45, 45);
            
            return x;
        }

        //pour faire aparaitre un monstre aléatoirement
        public void MiamTest()
        {
            
                GenX = RandomPos();
                GenY = RandomPos();
            ImageDeMonstre = _ImageMonstre.SelectMonstres();
            StateHasChanged();

        }

        //hitbox pour le monstre
        public bool PositionMiam(int X , int Y)
        {
           
            int[] carreX = { GenX - 1, GenX - 2, GenX - 3, GenX - 4, GenX - 5, GenX, GenX + 1, GenX + 2, GenX + 3};
            int[] carreY = { GenY, GenY + 1, GenY + 2, GenY + 3, GenY + 4, GenY + 5, GenY + 6, GenY + 7, GenY + 8 };
            if (carreX.Contains(X) && carreY.Contains(Y))
                {

                Console.WriteLine("correspondance trouvé !");
                //on block les mouvement
                LockAction = true;
                return true;
                
                
            }

            return false;
               
            
        }

        public void LeChoixDuCombatAccept()
        {
            ChoixUser = true;
            LeChoixDuCombatStyle = "display: none;";
            EvenText = "";
            ChoixDuCombatBtnStyleOui = "display : flex;justify-content: space-around; font-size:x-large;font-weight:800;";
            ReponseDuChoix = _Combats.simulateurDeReponseOui();
            // voir pour le combat
            MiamTest();
            LockAction = false;

        }
        public void LeChoixDuCombatRefused()
        {
            ChoixUser = false;
            LeChoixDuCombatStyle = "display: none;";
            EvenText = "";
            ChoixDuCombatBtnStyleOui = "display : flex;justify-content: space-around;font-size:x-large;font-weight:800;";
            ReponseDuChoix = _Combats.simulateurDeReponseNon();
            // voir pour la fuite
            MiamTest();
            LockAction = false;
        }

    }
}

// voir pour des zone de soin, rajouter des hp / dgts , interface de combats
