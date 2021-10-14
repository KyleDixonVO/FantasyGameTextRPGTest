using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Cool_Fantasy_Game__The_Movie__The_Game
{
    class Program
    {

            //experience
            static float badGuyXP = 10.0f;
            static float koboldXP = badGuyXP / 2.0f;
            static float goblinXP = badGuyXP * 2.0f;
            static float orcXP = badGuyXP * 3.5f;
            static float lichXP = badGuyXP * 10.0f;
            static float enemiesKilled;
            static float experience = 0.0f;
            
            //player resources
            static float playerHealth = 100.0f;
            static int lives = 1;
            static int spellSlots = 5;
            static float shieldAbsorb = 6.5f;
            
            //damage values
            static float swordDamage = 10.0f;
            
            static float orcDamage = 10.0f;

            //enemy resources
            static float orcHealth = 100.0f;

            //misc strings
            static string attack = "attack";
            static string block = "block";
            static string run = "run";
            static string cast = "cast";
            static string orc;
            static string userInput = null;
            static string magicMissle = "magic missle";
            static string HUD = "showHUD";
            
            static bool doAttack = attack.Equals(userInput);
            static bool doBlock = block.Equals(userInput);
            static bool doCast = cast.Equals(userInput);
            static bool doRun = run.Equals(userInput);
            static bool doMagicMissle = magicMissle.Equals(userInput);
            static bool showHUD = HUD.Equals(userInput);

        static void Main(string[] args)
        {
            Combat();
            
            
            
            
            

           

            
            
        }
        
        static void inputManager()
        {
                doAttack = attack.Equals(userInput);
                doBlock = block.Equals(userInput);
                doCast = cast.Equals(userInput);
                doRun = run.Equals(userInput);
                showHUD = HUD.Equals(userInput);

                if (doAttack == true)
                { 
                    orcHealth = orcHealth - swordDamage;
                    Console.WriteLine("Orc Health: " + orcHealth);
                }
                
               else if (doBlock == true)
                { 
                    playerHealth = playerHealth - (orcDamage - shieldAbsorb);
                    Console.WriteLine("Player Health: " + playerHealth);
                
                }
                
                else if (doCast == true)
                { 
                    castMenu();
                }

                else if (doRun == true)
                { 
                    Console.WriteLine("Coward");
                }

                else if (showHUD == true)
                { 
                    ShowHUD();
                    userInput = Console.ReadLine();
                    inputManager();      
                }

                else
                {
                    Console.WriteLine("Invalid Command");
                    userInput = Console.ReadLine();
                    inputManager();
                }

                userInput = Console.ReadLine();
                inputManager();
        }

        static void castMenu()
        {
                Console.WriteLine("What do you wish to cast?");
                Console.WriteLine("Spellslots: " + spellSlots);
                Console.WriteLine("//Options In Development.");
                userInput = Console.ReadLine();
               
                spellMenu();
            
        }

        static void spellMenu()
        {
                doMagicMissle = magicMissle.Equals(userInput);
                if (doMagicMissle == true)
                {   
                    spellSlots = spellSlots -1;
                    Console.ReadKey();
                    Console.WriteLine("Spellslots: " + spellSlots);
                    orcHealth = orcHealth - 35.0f;
                    Console.WriteLine("Orc Health: " + orcHealth);
                    Console.ReadKey(true);    
                }

                else
                {
                    Console.WriteLine("Invalid Command");
                    userInput = Console.ReadLine();
                    
                    spellMenu();
                }
        }
      
       static void Combat()
       {
                Console.WriteLine("An orc attacks!");
                Console.WriteLine("Orc Health: " + orcHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("attack / block / cast / run");
                Console.WriteLine("//Some features are broken at the moment");
                if (orcHealth <= 0)
                {
                    
                }
                userInput = Console.ReadLine();
                inputManager();

                
                Console.ReadKey(true);
       }
       
       static void PlayerStats()
       {
                experience = experience;

       }

       static void ShowHUD()
       { 
        Console.WriteLine("Player Lives: " + lives);
        Console.WriteLine("Player Health: " + playerHealth);
        Console.WriteLine("Spellslots: " + spellSlots);
        Console.WriteLine("Weapon Damage: " + swordDamage);
        Console.ReadKey(true);
       }
    }



    

}

        

   
    

