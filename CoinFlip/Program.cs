using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Welcome to Coin Flip Beta 0.0.1!");
            Console.WriteLine("Press Enter to Flip a Coin");
            Console.ReadKey();
            while (true)
            {
                Console.Clear();

                int flip = rand.Next(1, 1001);

                if (flip > 500)
                {
                    Console.WriteLine("Heads!");
                    StreamWriter sw = new StreamWriter(Application.StartupPath + @"\log.txt", true);
                    sw.Write("Heads; ");
                    sw.Close();
                }

                else if (flip < 500)
                {
                    Console.WriteLine("Tails!");
                    StreamWriter sw = new StreamWriter(Application.StartupPath + @"\log.txt", true);
                    sw.Write("Tails; ");
                    sw.Close();
                }

                else
                {
                    Console.WriteLine("Something went wrong!");
                }

                Console.ReadKey();
            }
        }
    }
}


