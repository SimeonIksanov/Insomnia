using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int pause = GetTimeout(args); // milliseconds
            while (true)
            {
                PowerHelper.ForceSystemAwake();
                await Task.Delay(pause);
            }
        }

        private static int GetTimeout(string[] args)
        {
            if (args.Length == 1 && int.TryParse(args[0],out int pause))
            {
                return pause;
            }

            return 60_000;
        }
    }
}
