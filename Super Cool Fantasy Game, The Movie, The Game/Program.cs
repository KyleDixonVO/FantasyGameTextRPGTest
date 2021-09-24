using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Cool_Fantasy_Game__The_Movie__The_Game
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
            float badGuyXP;
            badGuyXP = 10.0f;
            float koboldXP = badGuyXP / 2.0f;
            float goblinXP = badGuyXP * 2.0f;
            float orcXP = badGuyXP * 3.5f;
            float lichXP = badGuyXP * 10.0f;
            float playerHealth;
            playerHealth = 100.0f;
            int lives;
            lives = 1;
            int spellSlots;
            spellSlots = 5;
            int enemiesKilled;
            float swordDamage;
            swordDamage = 10.0f;
            float orcHealth;
            orcHealth = 100.0f;
            float orcDamage;
            orcDamage = 10.0f;
            string attack = "attack";
            string block = "block";
            string run = "run";
            string cast = "cast";
            string orc;
            string userInput = null;
            float experience;
            float shieldAbsorb;
            shieldAbsorb = 6.5f;
            bool doAttack = attack.Equals(userInput);
            bool doBlock = block.Equals(userInput);
            bool doCast = cast.Equals(userInput);
            bool doRun = run.Equals(userInput);
            experience = 0.0f;

            Core();

            void inputManager()
            {

                
            }

            void castMenu()
            {
                Console.WriteLine("What do you wish to cast?");
                Console.WriteLine("Spellslots: " + spellSlots);
                Console.WriteLine("//Options In Development.");
                Console.ReadKey();
                            
                spellSlots = spellSlots -1;
                Console.ReadKey();
                Console.WriteLine("Spellslots: " + spellSlots);
            
            }

            void Core()
            {
                Console.WriteLine("An orc attacks!");
                Console.WriteLine("Orc Health: " + orcHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("attack / block / cast / run");
                Console.WriteLine("(I only have attack working at the moment)");
                userInput = Console.ReadLine();
                doAttack = attack.Equals(userInput);
                doBlock = block.Equals(userInput);
                doCast = cast.Equals(userInput);
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

             
                Console.ReadKey(true);
            }
            
        }

      

        

    }



    

}

        

   
    

