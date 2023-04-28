namespace Exercises
{
    internal class DegreeCounter
    {
        public float Degree { get; private set; }
        public void CelToFar(float degree)
        {
            this.Degree = (degree * 9 / 5) + 32;
        }

        public void CelToFar(string degree)
        {
            if (float.TryParse(degree, out float result))
            {
                CelToFar(result);
            }
            else
            {
                throw new Exception("This is not float");
            }
        }

        public void FarToCel(float degree)
        {
            this.Degree = (degree - 32) * 5 / 9;
        }

        public void FarToCel(string degree)
        {
            if (float.TryParse(degree, out float result))
            {
                FarToCel(result);
            }
            else
            {
                throw new Exception("This is not float");
            }
        }
    }
}
