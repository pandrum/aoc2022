string stream = System.IO.File.ReadAllText(@"input.txt");

int start = 0;

for (int i = 0; i < stream.Length; i++)
{

    string slice = stream.Substring(start, 14);
    System.Console.WriteLine($"Slice: {slice}");

    bool unique = true;

    for (int j = 0; j < slice.Length; j++)
    {

        System.Console.WriteLine(slice[j]);
        for (int k = j + 1; k < slice.Length; k++)
        {
            if (slice[j] == slice[k])
            {
                System.Console.WriteLine($"{slice[j]} and {slice[k]} matched. Not unique.");
                unique = false;
            }
        }
    }

    System.Console.WriteLine(unique);

    if (unique)
    {
        System.Console.WriteLine($"Answer: {start + 14}");
        break;
    }

    System.Console.WriteLine("==========");
    start++;
}
