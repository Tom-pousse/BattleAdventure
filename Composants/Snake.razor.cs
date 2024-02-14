using Microsoft.AspNetCore.Components.Web;
using System;

namespace BattleAdventure.Composants
{
    public partial class Snake
    {
        int countX = 0;
        int countY =0;

        int PositionTop = 0;
        int PositionLeft = 1;
        int moved = 1;
        
        int GenX = 0;
        int GenY = 3;
        string radius = "0";
        
        

        string CubeStyle => $"top: {PositionTop}%; left: {PositionLeft}%;border-radius: {radius}px;";/* */
        string GenCube => $"top: {GenX}%; left: {GenY}%;";

        protected override void OnInitialized()
        {
           
            base.OnInitialized();
            GenX = RandomPos();
            GenY = RandomPos();
            Console.WriteLine("genX : "+ GenX + "genY : "+ GenY);
        }

        void Move(KeyboardEventArgs args)
        {
            
            Console.WriteLine("genX : " + GenX + "genY : " + GenY);
            Console.WriteLine(args.Key);
            switch (args.Key.ToLower()) 
            {
                case "z":
                    if (radius == "0")
                    {
                        radius = "15px 0"; ;
                        Console.WriteLine("test");
                    }else
                    {
                        radius = "0";
                    }
                    
                    
                    PositionTop -= moved; 
                    countX--;
                    Console.WriteLine("hauteur :" + countX + ",largeur: " + countY);
                    if (countX <= -48)
                    {
                        PositionTop = 47;
                        countX = 47;
                        Console.WriteLine("je switch" + countX);
                    }
                    if (countX == GenX && countY == (GenY+3))
                    {
                        
                        MiamTest();
                    }
                    break;
                case "s":
                    if (radius == "0")
                    {
                        radius = "15px 0px"; ;
                        Console.WriteLine("test");
                    }
                    else
                    {
                        radius = "0";
                    }
                    PositionTop += moved;
                    countX++;
                    Console.WriteLine("hauteur :" + countX + ",largeur: " + countY);
                    if (countX >= 48)
                    {
                        PositionTop = -47;
                        countX = -47;
                        Console.WriteLine("je switch" + countX);
                    }
                    if (countX == GenX && countY == (GenY + 3))
                    {
                        MiamTest();
                        

                    }
                    break;
                case "q":
                    if (radius == "0")
                    {
                        radius = "15px 0px" ;
                        Console.WriteLine("test");
                    }
                    else
                    {
                        radius = "0";
                    }
                    PositionLeft -= moved;
                    countY--;
                    Console.WriteLine("hauteur :" + countX + ",largeur: " + countY);
                    if (countY <= -48)
                    {
                        PositionLeft = 47;
                        countY = 47;
                        Console.WriteLine("je switch" + countY);
                    }
                    if (countX == GenX && countY == (GenY + 3))
                    {
                        MiamTest();
                        

                    }
                    break;
                case "d":
                    if (radius == "0")
                    {
                        radius = "15px 0px" ;
                        Console.WriteLine("test");
                    }
                    else
                    {
                        radius = "0";
                    }
                    PositionLeft += moved;
                    countY++;
                    Console.WriteLine("hauteur :" + countX + ",largeur: " + countY);
                    if (countY >= 48)
                    {
                        PositionLeft = -47;
                        countY = -47;
                        Console.WriteLine("je switch" + countY);
                    }
                    if (countX == GenX && countY == (GenY + 3))
                    {
                        MiamTest();


                    }
                    break;
            }
            StateHasChanged();
            Console.WriteLine("hauteur :" + countX + ",largeur: " + countY);
        }

        public int  RandomPos()
        {
            Random random = new Random();
             int x = random.Next(-48, 49);
            
            return x;
        }

        public void MiamTest()
        {
            
                GenX = RandomPos();
                GenY = RandomPos();
                StateHasChanged();

               
            
           
        }

    }
}
