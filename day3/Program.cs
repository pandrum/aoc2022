List<string> lines = System.IO.File.ReadLines(@"input.txt").ToList();
List<string> foundMatches = new List<string>();

string match = "";
string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
int score = 0;

foreach (var item in lines)
{
    var first = item.Substring(0, (int)(item.Length / 2));
    var last = item.Substring((int)(item.Length / 2), (int)(item.Length / 2));

    System.Console.WriteLine(first);
    System.Console.WriteLine(last);

    foreach (var c in first)
    {
        if (last.Contains(c))
        {
            match = c.ToString();
        }
    }
    System.Console.WriteLine(match);
    foundMatches.Add(match);
    System.Console.WriteLine("--------next rucksack--------");

}
System.Console.WriteLine("end");
foreach (var item in foundMatches)
{
    System.Console.WriteLine(item);
    score += (alphabet.IndexOf(item) + 1);

}

System.Console.WriteLine(score);
