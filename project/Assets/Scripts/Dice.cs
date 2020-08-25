using Random = System.Random;
using UnityEngine;

namespace Scripts
{
    public interface IDice
    {
        int Roll();
    }

    public class Dice : IDice
    {
        private const int MAXVALUE = 6;
        private const int MINVALUE = 1;

        private Random random = null;
    
        public Dice()
        {
            random = new Random();
        }
        public int Roll()
        {
            var temp = random.Next(MINVALUE, MAXVALUE);
            Debug.Log(temp);
            return temp;
        }
    
    }

}
