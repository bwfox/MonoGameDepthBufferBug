using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphics3DSample
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Graphics3DSampleGame())
                game.Run();
        }
    }
}


