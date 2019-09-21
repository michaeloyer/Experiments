using System;

namespace ClassLib
{
    public static class Numbers
    {
        private static Random random = new Random();
        public static int Get()
        {
            var x = 10;
            x++;
            return x;
        }

        public static int GetRandom()
        {
            return random.Next(1, 11);
        }
    }
}
