using System;

namespace Studio2RotaControl
{
    internal static class logger
    {
        #region Fields

        private static bool flagDebug = false;

        #endregion Fields

        #region Methods

        public static void Say(string input)
        {
            if (flagDebug)
                Console.WriteLine(input);
        }

        #endregion Methods
    }
}