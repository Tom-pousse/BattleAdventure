using Microsoft.AspNetCore.Components.Web;
using System;
using BattleAdventure.Composants.Tabeau;

namespace BattleAdventure.Composants
{
    public partial class Snake
    {
        readonly TabMonstres _ImageMonstre = new TabMonstres();
        string ImageDeMonstre;
        int countX = 0;
        int countY =0;

        int PositionTop = 0;
        int PositionLeft = 1;
        int moved = 1;
        
        int GenX = 0;
        int GenY = 3;
        bool Movement = false;
        
        

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
                        
                        MiamTest();
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
                        MiamTest();
                        

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
                        MiamTest();
                        

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
                        MiamTest();


                    }
                    break;
            }
            StateHasChanged();
            //Console.WriteLine("hauteurX :" + countX + ",largeurY: " + countY);
                        //Console.WriteLine("genX : "+ GenX + "genY : "+ GenY);

        }

        public int  RandomPos()
        {
            Random random = new Random();
             int x = random.Next(-45, 45);
            
            return x;
        }

        public void MiamTest()
        {
            
                GenX = RandomPos();
                GenY = RandomPos();
            ImageDeMonstre = _ImageMonstre.SelectMonstres();
            StateHasChanged();

               
            
           
        }

        public bool PositionMiam(int X , int Y)
        {
           
            int[] carreX = { GenX - 1, GenX - 2, GenX - 3, GenX - 4, GenX - 5, GenX, GenX + 1, GenX + 2, GenX + 3};
            int[] carreY = { GenY, GenY + 1, GenY + 2, GenY + 3, GenY + 4, GenY + 5, GenY + 6, GenY + 7, GenY + 8 };
            if (carreX.Contains(X) && carreY.Contains(Y))
            {
                Console.WriteLine("correspondance trouvé !");
                if (false)
                {
                    return true;
                }else {
                
                   return false;
                }
                
                
            }

            return false;
               
            
        }

    }
}
