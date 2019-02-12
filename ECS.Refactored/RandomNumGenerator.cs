using System;

namespace ECS.Refactored
{
    public class RandomNumGenerator : IRandomNumGenerator
    {
        private Random rand = new Random();
        public int Next(int min, int max)
        {
            return rand.Next(min, max);
        }
    }
}