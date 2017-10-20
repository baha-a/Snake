using System;

namespace TestProject
{
    public interface IRandom
    {
        int Get(int low, int max);
    }

    public class Randomer : IRandom
    {
        Random r = new Random();

        public int Get(int low, int max)
        {
            return r.Next(low, max);
        }
    }
}