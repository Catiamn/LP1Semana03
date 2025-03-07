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
            switch (gear)
            {
                case PlayerGear.Helmet:
                    return Helmet = 2;
                case PlayerGear.Shield:
                    return Shield = 3;
                case PlayerGear.Boots:
                    return Boots = 4;
            }
        }
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>

        //TRAP TYPE
        private static bool CanSurviveTrap(string[ ] args)
        {
            switch (trap)
            {
                case TrapType.FallingRocks:
                    return rock = 1;
                case TrapType.SpinningBlades:
                    return blades = 2;
                case TrapType.PoisonGas:
                    return poison = 3;
                case TrapType.LavaPit:
                    return lava = 4;
            }   
        }
        }
        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>

        //SURVIVES
        private static void DisplayResult(string [] arg)
        {
            if (PlayerGear < TrapType)
                    Console.WriteLine($"Player dies due to {trap}");
                    break;
            if (PlayerGear > TrapType)
                    Console.WriteLine($"Player survives {trap}");
                    break;
                
        }
    


