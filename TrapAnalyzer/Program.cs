using System;
using TrapAnalyzer;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        /// 

        //PLAYER GEAR
        private static PlayerGear ParseGear(string[] args)
        {
            
        }
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>

        //TRAP TYPE
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
                if (gear < trap)
                {
                    return GameStatus.Dies; //Dies 
                }
                if (gear > trap)
                {
                    return GameStatus.Survives; // Player Survives
                }
        }
        

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>

        //SURVIVES
        private static void DisplayResult(TrapType trap, bool survives)
        {
            switch (result)
            {
                case GameStatus.Dies:
                    Console.WriteLine($"Player dies due to {trap}");
                    break;
                case GameStatus.PlayerSurvives:
                    Console.WriteLine($"Player survives {trap}");
                    break;
                
        }
    
}
