List<string> inputs = System.IO.File.ReadLines(@"input.txt").ToList();
List<string> history = new List<string>();

for (int i = 0; i < inputs.Count; i++)
{
    long currentDirSize = 0;
    string[] dirs;
    string dirname;

    // if input starts with cd
    if (inputs[i].StartsWith("$ cd"))
    {
        dirs = inputs[i].Split(" ");
        dirname = dirs[2];

        if (dirname.Equals(".."))
        {
            history.RemoveAt(history.Count - 1);
        }
        else
        {
            history.Add(dirname);
        }
    }

    // if input starts with ls
    if (inputs[i].Equals("$ ls"))
    {
        for (int j = i + 1; j < inputs.Count; j++)
        {
            if (inputs[j].StartsWith("$"))
            {
                break;
            }

            if (Char.IsDigit(inputs[j][0]))
            {
                string[] files = inputs[j].Split(" ");
                int size = Convert.ToInt32(files[0]);
                currentDirSize += size;
            }

        }

        System.Console.WriteLine($"Adding {history.Last()} with size {currentDirSize} to list. Level is {history.Count}");


        System.Console.WriteLine("===================");
    }
}
