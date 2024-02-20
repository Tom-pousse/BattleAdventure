using BattleAdventure.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Timers;

namespace BattleAdventure.Composants
{

    public partial class Combats
    {
        private static System.Timers.Timer aTimer;

        [Parameter]
        public bool EnvoieDeFuiteCombat { get; set; }
        [Parameter]
        public EventCallback<bool> EventCallback { get; set; }
        [Parameter]
        public Avatar MonJoueur { get; set; }
        [Parameter]
        public string DonneesDeLElementParent { get; set; }

        bool Cliquer = true;

        Monstre monstre = new Monstre();
        int life = 100;
        int Mana = 100;
        int NewVie = 100;
        int LiveMonster = 100;
        int ManaMonster = 100;
        int NewVieMonster= 100;

        string MessageInfoCombat = "Vs";




        protected override void OnInitialized()
        {
            base.OnInitialized();


            if (MonJoueur.Level== 1)
            {
                monstre.Level = 1;
            StatMonstre();
                

            }else if (MonJoueur.Level == 2)
            {
                Random random = new Random();
                int lvl = random.Next(1,3);
                monstre.Level = lvl;
                StatMonstre();
            }
            else if (MonJoueur.Level == 3)
            {
                Random random = new Random();
                int lvl = random.Next(2, 4);
                monstre.Level = lvl;
                StatMonstre();
            }
            else if (MonJoueur.Level == 4)
            {
                Random random = new Random();
                int lvl = random.Next(3, 5);
                monstre.Level = lvl;
                StatMonstre();
            }
            else 
            {
                Random random = new Random();
                int lvl = random.Next(4, 6);
                monstre.Level = lvl;
                StatMonstre();
            }

            Console.WriteLine("test" + DonneesDeLElementParent);
            Console.WriteLine("récup du joueur:" + MonJoueur);
            Console.WriteLine("récup du monstre:" + monstre);
        }

        public void Attaquer()
        {
            Cliquer = false;
            int dmg = MonJoueur.CalculDamage(MonJoueur);
            MonJoueur.Dommage = dmg;
            MonJoueur.Attaque(MonJoueur, monstre);
            Console.WriteLine("MonJoueur.degat = " + MonJoueur.Dommage);
            Console.WriteLine("la vie de mon monstre" + monstre.Vie);
            NewVieMonster = LiveMonster - ((MonJoueur.Dommage * 100) / monstre.Vie);
            Console.WriteLine("les dégat de mon Joueur : " + MonJoueur.Dommage);
            Console.WriteLine("la vie de mon joueur : " + monstre.Vie);
            LiveMonster = NewVieMonster;
            if (LiveMonster > 0)
            {
                Console.WriteLine("réponse au combat");
                Timer();
            }
            else { 
            MessageInfoCombat = "Vous avez gagner !";
            Timer2();
        }
            StateHasChanged();

            Console.WriteLine("je refresh mmon visu");

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
            {

                //Console.WriteLine("raté");
                MessageInfoCombat = "Vous n'avez pas réussi à fuire";
            Cliquer = false;
            Timer();
            }

        }

        public void StatMonstre()
        {

            Random random = new Random();
            monstre.Nom = "";
            monstre.Type = "";


            if (monstre.Level == 1)
            {
                monstre.Force = random.Next(1, 5);
                monstre.Agilite = random.Next(1, 5); ;
                monstre.Endurance = random.Next(1, 5); ;
                monstre.Level = 1;
                monstre.Vie = monstre.CalculVie(monstre);
                monstre.Dommage = 0;
            }
            if (monstre.Level == 2)
            {
                monstre.Force = random.Next(3, 7);
                monstre.Agilite = random.Next(3, 7); ;
                monstre.Endurance = random.Next(3, 6); ;
                monstre.Level = 2;
                monstre.Vie = monstre.CalculVie(monstre);
                monstre.Dommage = 0;
            }
            if (monstre.Level == 3)
            {
                monstre.Force = random.Next(4, 8);
                monstre.Agilite = random.Next(4, 8); ;
                monstre.Endurance = random.Next(4, 9); ;
                monstre.Level = 3;
                monstre.Vie = monstre.CalculVie(monstre);
                monstre.Dommage = 0;
            }
            if (monstre.Level == 4)
            {
                monstre.Force = random.Next(5, 10);
                monstre.Agilite = random.Next(5, 10); ;
                monstre.Endurance = random.Next(5, 10); ;
                monstre.Level = 4;
                monstre.Vie = monstre.CalculVie(monstre);
                monstre.Dommage = 0;
            }
            if (monstre.Level == 5)
            {
                monstre.Force = random.Next(7, 12);
                monstre.Agilite = random.Next(7, 13); ;
                monstre.Endurance = random.Next(7, 12); ;
                monstre.Level = 4;
                monstre.Vie = monstre.CalculVie(monstre);
                monstre.Dommage = 0;
            }
            Console.WriteLine(monstre);
        }


        //Test de creation d'un timer
        public  void Timer()
        {
            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 4000;

            // Hook up the Elapsed event for the timer. 

            aTimer.Elapsed += OnTimedEvent;

            
            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = false;

            // Start the timer
            aTimer.Enabled = true;
            

        }

        public  void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("instant +4");
           
            RepEnemieAttaque();
            Cliquer = true;
            StateHasChanged();

        }
        public void RepEnemieAttaque()
        {
            int dmg = monstre.CalculDamage(monstre);
            monstre.Dommage = dmg;
            Console.WriteLine(" je lance ma reponse combat" + monstre);
            monstre.Attaque(monstre, MonJoueur);
            Console.WriteLine("Joueur" + MonJoueur.Vie);
            Console.WriteLine(monstre.Vie);
            NewVie = life - ((monstre.Dommage * 100) / MonJoueur.Vie);
            Console.WriteLine("les dégat de mon monstre : " + monstre.Dommage);
            Console.WriteLine("la vie de mon joueur : " + MonJoueur.Vie);
            life = NewVie;
            Console.WriteLine("la vie restante : "+life);
            StateHasChanged();

        }

        public void Timer2()
        {
            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 4000;

            // Hook up the Elapsed event for the timer. 

            aTimer.Elapsed += OnTimedEvent2;


            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = false;

            // Start the timer
            aTimer.Enabled = true;

        }
        public void OnTimedEvent2(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("++");

            EventCallback.InvokeAsync(EnvoieDeFuiteCombat);



        }

    }
}
// voir plus en détail static pas compris à déveloper