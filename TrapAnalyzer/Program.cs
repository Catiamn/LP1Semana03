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
            //Gear available
            PlayerGear playerGear = PlayerGear.Helmet | PlayerGear.Shield | PlayerGear.Boots;

            foreach (PlayerGear gear in Enum.GetValues(typeof(PlayerGear)))
            {
                playerGear &= gear;
            }
            foreach (string arg in args.ToList().Slice(1, args.ToList().Count-1))
            {
                PlayerGear gear = Enum.Parse<PlayerGear>(arg);
                if (gear != PlayerGear.None)
                {
                    playerGear ^= gear;
                }
            }
            return playerGear;
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
            switch (trap)
            {
                case TrapType.FallingRocks:
                    return int rock = 1
                case TrapType.SpinningBlades:
                    return int blades = 2
                case TrapType.PoisonGas:
                    return int poison = 3
                case TrapType.LavaPit:
                    return int lava = 4
            }   
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

