namespace Exercises
{
    public class JewelinsAndStones
    {
        public int CountJewelsInStones(string jewels, string stones)
        {
            var _jewelinsArray = jewels.Distinct().ToArray();
            var _stonesArray = stones.ToArray();
            var counter = 0;

            foreach (var jewelin in _jewelinsArray)
            {
                foreach (var stone  in _stonesArray)
                {
                    if (jewelin == stone)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
