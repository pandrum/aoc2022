
List<string> lines = System.IO.File.ReadLines(@"input.txt").ToList();

Dictionary<int, string> stacks = new Dictionary<int, string>() {
    {1, "PDQRVBHF"},
    {2, "VWQZDL"},
    {3, "CPRGQZLH"},
    { 4, "BVJFHDR"},
    { 5, "CLWZ"},
    { 6, "MVGTNPRJ"},
    { 7, "SBMVLRJ"},
    { 8, "JPD"},
    { 9, "VWNCD"}};

foreach (var item in lines)
{
    int amount = 0;
    int from = 0;
    int to = 0;

    string[] splitString = item.Split(" ");

    amount = Int32.Parse(splitString[1]);
    from = Int32.Parse(splitString[3]);
    to = Int32.Parse(splitString[5]);

    for (int i = 0; i < amount; i++)
    {
        stacks[to] = stacks[from].ToString().Substring(0, 1) + stacks[to];
        stacks[from] = stacks[from].ToString().Substring(1);
    }
}

foreach (var item in stacks)
{
    System.Console.WriteLine($"Column: {item.Key} Stacks: {item.Value.ToString().Substring(0, 1)}");
}
