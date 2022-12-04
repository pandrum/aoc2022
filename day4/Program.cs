List<string> lines = System.IO.File.ReadLines(@"input.txt").ToList();

// 1000 lines in input
// System.Console.WriteLine(lines.Count);

bool match = false;
int counter = 0;
int overlaps = 0;

string first = "";
string second = "";
string third = "";
string fourth = "";


foreach (string item in lines)
{
    foreach (var character in item)
    {

        if (character.ToString().Equals("-") || character.ToString().Equals(","))
        {
            counter++;
            continue;
        }

        if (counter == 0)
        {
            first += character.ToString();
        }
        if (counter == 1)
        {
            second += character.ToString();
        }
        if (counter == 2)
        {
            third += character.ToString();
        }
        if (counter == 3)
        {
            fourth += character.ToString();
        }
    }

    if ((Convert.ToInt32(first) < Convert.ToInt32(third) && Convert.ToInt32(first) < Convert.ToInt32(fourth) && Convert.ToInt32(second) < Convert.ToInt32(third) && Convert.ToInt32(second) < Convert.ToInt32(fourth))
    || (Convert.ToInt32(first) > Convert.ToInt32(third) && Convert.ToInt32(first) > Convert.ToInt32(fourth) && Convert.ToInt32(second) > Convert.ToInt32(third) && Convert.ToInt32(second) > Convert.ToInt32(fourth)))
    {
        match = true;
        System.Console.WriteLine("No overlap");
    }

    // System.Console.WriteLine(first);
    // System.Console.WriteLine(second);
    // System.Console.WriteLine(third);
    // System.Console.WriteLine(fourth);

    if (match)
    {
        overlaps++;
    }

    counter = 0;
    first = "";
    second = "";
    third = "";
    fourth = "";
    match = false;
    // System.Console.WriteLine("------------------end------------------");
}

System.Console.WriteLine(overlaps);
