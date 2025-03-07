using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {

            string selectedPerk = args[0].ToLower(); //All args are lowered so CAPS doesn't bother it
            int[] count = new int [4]; //Array where it will save values of each char in args

            foreach (char c in selectedPerk) //for each char in args
            {
                switch(c)
                {
                    case 'w': //WarpShift
                        count[0]++;
                        break;
                    case 'a': //Stealth
                        count[1]++;
                        break;
                    case 's': //AutoHeal
                        count[2]++;
                        break;
                    case 'd': //Doublejump
                        count[3]++;
                        break;
                    default: //if char doesn't correspond to anything
                        Console.WriteLine($"!Unknown perk!");
                        return;
                }
            }

            Perks player = 0; //new null variable

            if (count[0] % 2 != 0) player |= Perks.WarpShift;
            if (count[1] % 2 != 0) player |= Perks.AutoHeal;
            if (count[2] % 2 != 0) player |= Perks.Stealth;
            if (count[3] % 2 != 0) player |= Perks.DoubleJump;

         }
        }
        [Flags]
        enum Perks
        {
            WarpShift = 1 << 0,
            Stealth = 1 << 1,
            AutoHeal = 1 << 2,
            DoubleJump = 1 << 3
         }
    }
