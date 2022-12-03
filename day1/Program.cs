List<string> lines = System.IO.File.ReadLines(@"input.txt").ToList();

int counter = 0;
List<int> nums = new List<int>();
foreach (string line in lines)
{
    if (string.IsNullOrEmpty(line))
    {
        nums.Add(counter);
        counter = 0;
        continue;
    }
    counter += Int32.Parse(line);
}

nums.Sort();
nums.Reverse();

Console.WriteLine(nums[0] + nums[1] + nums[2]);