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

using Exercises;

Console.WriteLine("FarToCel [F] or CelToFar [C]");
var userAnswer = Console.ReadLine();
var degree = new DegreeCounter();
if (userAnswer == "f" || userAnswer == "F")
{
    Console.WriteLine("How much Farenhait degree you want convert to Celcius?: ");
    var degreeFromUser = Console.ReadLine();
    try
    {
        degree.FarToCel(degreeFromUser);
    }
    catch (Exception e)
    { 
        Console.WriteLine(e.Message);
    }
    Console.WriteLine($"It is: {degree.Degree} Celcius degree");
}
else if (userAnswer == "c" || userAnswer == "C")
{
    Console.WriteLine("How much Celcius degree you want convert to Farenhait?: ");
    var degreeFromUser = Console.ReadLine();
    try
    {
        degree.CelToFar(degreeFromUser);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine($"It is: {degree.Degree} Farenhait degree");
}
