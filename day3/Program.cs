//puzzle 1
List<string> lines = System.IO.File.ReadLines(@"input.txt").ToList();
List<string> foundMatches = new List<string>();

string match = "";
string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
int score = 0;

int end = 3;


for (int i = 0; i < lines.Count; end = end + 3)
{
    foreach (var c in lines[i])
    {
        if (lines[i + 1].Contains(c) && lines[i + 2].Contains(c))
        {
            match = c.ToString();
        }
    }
    foundMatches.Add(match);
    System.Console.WriteLine(match);
    System.Console.WriteLine("-------end-------");
    i = i + 3;
}


foreach (var item in foundMatches)
{
    System.Console.WriteLine(item);
    score += (alphabet.IndexOf(item) + 1);

}

System.Console.WriteLine(score);
