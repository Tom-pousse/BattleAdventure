using Microsoft.AspNetCore.Components;

namespace BattleAdventure.Composants
{
    public partial class Combats
    {
        [Parameter]
        public string DonneesDeLElementParent { get; set; }
        int life = 100;
        int Mana = 100;

        string MessageInfoCombat = "Vs";
        

        [Parameter]
        public bool EnvoieDeFuiteCombat { get; set; }
        [Parameter]
        public EventCallback<bool> EventCallback { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Console.WriteLine("test" + DonneesDeLElementParent);
        }

        public void Attaque()
        {

        }

        public void Items()
        {

        }

        public void Fuite()
        {
            Random random = new Random();
            int result = random.Next(0, 3);
            if (result == 2)
            {
                EnvoieDeFuiteCombat = false;
            //Console.WriteLine("reussi");
            //    Console.WriteLine(EventCallback.InvokeAsync(EnvoieDeFuiteCombat));
                EventCallback.InvokeAsync(EnvoieDeFuiteCombat);
                    MessageInfoCombat = "Vous avez fuis";
               
                
            }else 
                //Console.WriteLine("raté");
                MessageInfoCombat = "Vous n'avez pas réussi à fuire";
            

        }



    }
}
