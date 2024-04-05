using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace Exercises
{
    public class BinaryGap
    {
        //public int FindBinaryGap(int number)
        //{
        //    var binaryNumber = ConverterToBinary(number);
        //    var firstIndexOfValueOne = 0;
        //    var secondIndexOfValueOne = 0;
        //    for (int i = binaryNumber.Count - 1; i > 0; i++)
        //    {
        //        if (binaryNumber[i] == 1)
        //        {
        //            firstIndexOfValueOne = i;
        //            for (int j = firstIndexOfValueOne - 1; j > 0; j++)
        //            {
        //                if (binaryNumber[j] == 1)
        //                {
        //                    secondIndexOfValueOne = j;
        //                    break;
        //                }
        //            }break;
        //        }
        //    }
        //    Console.WriteLine($"pierwszy: {firstIndexOfValueOne}, drugi: {secondIndexOfValueOne}");
        //    return secondIndexOfValueOne - firstIndexOfValueOne - 1;
        //}

        public int FindBinaryGapDictionary(int number)
        {
            List<int> _counterList = new List<int>();

            var binaryNumber = ConverterToBinaryList(number);
            var amountOfNumberOne = binaryNumber.Count(x => x == 1);
            var counter = 0;
            if (amountOfNumberOne == 1)
            {
                throw new Exception("W zapisie binarnym wystepuje tylko jedna jedynka");
            }
            else
            {
                for ( var i = 0; i < binaryNumber.Count; i++)
                {
                    if (binaryNumber[i] == 1)
                    {
                        i++;
                        for (int j = i; j < binaryNumber.Count; j++)
                        {
                            if (binaryNumber[j] == 0)
                            {
                                counter++;
                            }
                            else
                            {
                                _counterList.Add(counter);
                                counter = 0;
                            }
                        }
                    }
                }
                var maxAmountZeros = _counterList.Max();
                return maxAmountZeros;
            }
        }

        //public Dictionary<int, int> ConverterToBinary(int  number)
        //{
        //    Dictionary<int, int> dictionary = new Dictionary<int, int>();
        //    int counter = 0;
        //    do
        //    {
        //        int restOfDivide = number % 2;
        //        dictionary[counter] = restOfDivide;
        //        counter++;
        //        number = number / 2;
        //    } while (number != 1);
        //    dictionary[counter] = 1;
        //    return dictionary;
        //}

        public List<int> ConverterToBinaryList(int number)
        {
            List<int> list = new List<int>();
            int counter = 0;
            do
            {
                int restOfDivide = number % 2;
                list.Add(restOfDivide);
                counter++;
                number = number / 2;
            } while (number != 1);
            list.Add(1);
            return list;
        }
    }
}
