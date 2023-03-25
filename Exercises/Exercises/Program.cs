Console.WriteLine("Write something: ");
string text = Console.ReadLine();
text = text.ToLower();

Dictionary<char, int> counters = new Dictionary<char, int>();

foreach (char charInText in text)
{
    counters.TryGetValue(charInText, out int value);
    counters[charInText] = value + 1;
}

foreach (KeyValuePair<char, int> keyValuePair in counters)
{
    Console.WriteLine(keyValuePair);
}
