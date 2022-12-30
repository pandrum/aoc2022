List<string> inputs = System.IO.File.ReadLines(@"input.txt").ToList();

List<string> path = new List<string>();


string createCurrentDirectory()
{
    string dir = string.Join("/", path);
    dir = dir.Replace("//", "/");
    return dir;
}

Dictionary<string, long> folders = new Dictionary<string, long>();

foreach (var input in inputs)
{
    if (input.Substring(0, 1).Equals("$"))
    {
        var command = input.Split(" ");

        if (command[1] == "cd")
        {
            if (command[2] == "..")
            {
                path.RemoveAt(path.Count - 1);
            }
            else
            {
                path.Add(command[2]);
            }
        }

        else if (command[1] == "ls")
        {
            //
        }
    }

    else if (input.StartsWith("dir"))
    {
        //
    }

    else
    {
        var file = input.Split(" ");
        if (!folders.ContainsKey(createCurrentDirectory()))
        {
            folders[createCurrentDirectory()] = 0;
        }

        string dir = createCurrentDirectory();
        while (dir.Contains("/"))
        {
            System.Console.WriteLine(dir);
            if (!folders.ContainsKey(dir))
            {
                folders[dir] = 0;
            }
            folders[dir] += Convert.ToInt32(file[0]);

            if (dir == "/") break;

            var dirSplit = dir.Split("/").ToList();
            dirSplit.RemoveAt(dirSplit.Count - 1);
            dir = string.Join("/", dirSplit);
        }

    }
}


long total = 0;
foreach (var item in folders)
{
    if (item.Value <= 100000)
    {
        total += item.Value;
    }
    System.Console.WriteLine($"{item.Key}: {item.Value}");
}
System.Console.WriteLine(total);
