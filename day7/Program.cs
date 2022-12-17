List<string> inputs = System.IO.File.ReadLines(@"input.txt").ToList();
List<string> history = new List<string>();

foreach (var input in inputs)
{
    long fileSize = 0;

    // if input starts with cd
    if (input.StartsWith("$ cd"))
    {
        string[] dirs = input.Split(" ");
        string dirname = dirs[2];

        if (dirname.Equals(".."))
        {
            history.RemoveAt(history.Count - 1);
        }
        else
        {
            history.Add(dirname);
        }
    }

    if (Char.IsDigit(input[0]))
    {
        string[] files = input.Split(" ");
        int size = Convert.ToInt32(files[0]);
        fileSize += size;
        System.Console.WriteLine($"File size of {files[1]} in {history.Last()} is {size}");
    }
}
System.Console.WriteLine(history.Count);
