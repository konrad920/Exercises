//liczenie ile liter występuje we wpisanym tekscie
//Console.WriteLine("Write something: ");
//string text = Console.ReadLine();
//text = text.ToLower();

//Dictionary<char, int> counters = new Dictionary<char, int>();

//foreach (char charInText in text)
//{
//    counters.TryGetValue(charInText, out int value);
//    counters[charInText] = value + 1;
//}

//foreach (KeyValuePair<char, int> keyValuePair in counters)
//{
//    Console.WriteLine(keyValuePair);
//}



//zamiana celciusz na farenhajt
//using Exercises;

//Console.WriteLine("FarToCel [F] or CelToFar [C]");
//var userAnswer = Console.ReadLine();
//var degree = new DegreeCounter();
//if (userAnswer == "f" || userAnswer == "F")
//{
//    Console.WriteLine("How much Farenhait degree you want convert to Celcius?: ");
//    var degreeFromUser = Console.ReadLine();
//    try
//    {
//        degree.FarToCel(degreeFromUser);
//    }
//    catch (Exception e)
//    { 
//        Console.WriteLine(e.Message);
//    }
//    Console.WriteLine($"It is: {degree.Degree} Celcius degree");
//}
//else if (userAnswer == "c" || userAnswer == "C")
//{
//    Console.WriteLine("How much Celcius degree you want convert to Farenhait?: ");
//    var degreeFromUser = Console.ReadLine();
//    try
//    {
//        degree.CelToFar(degreeFromUser);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    Console.WriteLine($"It is: {degree.Degree} Farenhait degree");
//}


//Console.WriteLine("Write 3 numbers, then I saw you max of them");
//List<float> numbers = new List<float>();

//int i = 0;
//int countMax = 0;
//while (i < 3)
//{
//    Console.Write("Write number: ");
//    var number = Console.ReadLine();
//    if (float.TryParse(number, out float result))
//    {
//        numbers.Add(result);
//        i++;
//    }
//    else 
//    {
//        Console.WriteLine("This is not float");
//    }
//}

//int maxCounter = 0;
//foreach (var number in numbers)
//{
//    if (number == numbers.Max())
//    {
//        maxCounter++;
//    }
//}

//var maximum = numbers.Max();
//Console.WriteLine($"Your max is: {maximum}, you write it: {maxCounter} times");

using System;
using Exercises;

//var item = new MergeNames();
//item.Main
//


BinaryGap binaryGap = new BinaryGap();
//Dictionary<int, int> score = binaryGap.FindBinaryGap(8);
try
{
    Console.WriteLine(binaryGap.FindBinaryGapDictionary(11));
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}

