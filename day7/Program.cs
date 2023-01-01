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

    if (Char.IsDigit(input[0]))
    {
        var file = input.Split(" ");
        if (!folders.ContainsKey(createCurrentDirectory()))
        {
            folders[createCurrentDirectory()] = 0;
        }

        string dir = createCurrentDirectory();

        while (dir.Contains("/"))
        {
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

long diskSpace = 70000000;
long updateSize = 30000000;

//used space 42080344
long usedSpace = 0;

foreach (var item in folders)
{
    usedSpace += item.Value;
}
//unused space 27919656
long unUsedSpace = (diskSpace - usedSpace);

//needed space for update 2080344
long neededSpace = (updateSize - unUsedSpace);
System.Console.WriteLine($"Disk space: {diskSpace}");
System.Console.WriteLine($"Used space: {usedSpace}");
System.Console.WriteLine($"Unused space: {unUsedSpace}");
System.Console.WriteLine($"Needed space for update: {neededSpace}");

var list = new List<long>();

foreach (var item in folders)
{
    if (item.Value >= 2080344)
    {
        System.Console.WriteLine($"{item.Key}: {item.Value}");
        list.Add(item.Value);
    }
}
System.Console.WriteLine(list.Min());