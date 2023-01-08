var inputFile = System.IO.File.ReadLines(@"input.txt").ToList();
var inputs = new List<string>(inputFile);

void Part1()
{
    var unique = new HashSet<string>();

    int headX = 0;
    int headY = 0;
    System.Console.WriteLine($"Head starting at {headX} and {headY}");

    int tailX = 0;
    int tailY = 0;
    System.Console.WriteLine($"Tail starting at {tailX} and {tailY}");


    void KeepTailUp(string direction)
    {
        //up
        if (direction == "U")
        {
            //diagonal check
            if ((headY - tailY == 2 || headY - tailY == -2) && (headX - tailX == 1 || headX - tailX == -1))
            {
                System.Console.WriteLine("Tail is diagonally down left or down right");
                tailX = headX;
                tailY = headY - 1;
                System.Console.WriteLine($"Tail is now at {tailX},{tailY} ");
            }

            else if (headY - tailY == 2 || headY - tailY == -2)
            {
                System.Console.WriteLine($"Tail is catching up to head from {tailX},{tailY} to {tailX},{tailY + 1}");
                tailY++;
            }

        }

        //right
        if (direction == "R")
        {
            //diagonal check
            if ((headX - tailX == 2 || headX - tailX == -2) && (headY - tailY == 1 || headY - tailY == -1))
            {
                System.Console.WriteLine("Tail is diagonally left up or left down");
                tailY = headY;
                tailX = headX - 1;
                System.Console.WriteLine($"Tail is now at {tailX},{tailY} ");
            }

            else if (headX - tailX == 2 || headX - tailX == -2)
            {
                System.Console.WriteLine($"Tail is catching up to head from {tailX},{tailY} to {tailX + 1},{tailY}");
                tailX++;
            }

        }

        //down
        if (direction == "D")
        {
            //diagonal check
            if ((headY - tailY == 2 || headY - tailY == -2) && (headX - tailX == 1 || headX - tailX == -1))
            {
                System.Console.WriteLine("Tail is diagonally up left or up right");
                tailX = headX;
                tailY = headY + 1;
                System.Console.WriteLine($"Tail is now at {tailX},{tailY} ");
            }

            else if (headY - tailY == 2 || headY - tailY == -2)
            {
                System.Console.WriteLine($"Tail is catching up to head from {tailX},{tailY} to {tailX},{tailY - 1}");
                tailY--;
            }

        }

        //left
        if (direction == "L")
        {
            //diagonal check
            if ((headX - tailX == 2 || headX - tailX == -2) && (headY - tailY == 1 || headY - tailY == -1))
            {
                System.Console.WriteLine("Tail is diagonally up right or down right");
                tailY = headY;
                tailX = headX + 1;
                System.Console.WriteLine($"Tail is now at {tailX},{tailY} ");
            }

            else if (headX - tailX == 2 || headX - tailX == -2)
            {
                System.Console.WriteLine($"Tail is catching up to head from {tailX},{tailY} to {tailX - 1},{tailY}");
                tailX--;
            }

        }
    }

    foreach (var input in inputs)
    {
        var command = input.Split(" ");
        string direction = command[0].ToString();
        int amount = Convert.ToInt32(command[1]);

        System.Console.WriteLine($"{direction} - {amount}");

        //up
        if (direction == "U")
        {
            for (int up = 0; up < amount; up++)
            {
                headY++;
                System.Console.WriteLine($"Head is going up, {headX},{headY}");
                KeepTailUp(direction);
                unique.Add(tailX.ToString() + "," + tailY.ToString());

            }
        }

        //right
        if (direction == "R")
        {
            for (int right = 0; right < amount; right++)
            {
                headX++;
                System.Console.WriteLine($"Head is going right, {headX},{headY}");
                KeepTailUp(direction);
                unique.Add(tailX.ToString() + "," + tailY.ToString());

            }
        }

        //down
        if (direction == "D")
        {
            for (int down = 0; down < amount; down++)
            {
                headY--;
                System.Console.WriteLine($"Head is going down, {headX},{headY}");
                KeepTailUp(direction);
                unique.Add(tailX.ToString() + "," + tailY.ToString());

            }
        }

        //left
        if (direction == "L")
        {
            for (int left = 0; left < amount; left++)
            {
                headX--;
                System.Console.WriteLine($"Head is going left, {headX},{headY}");
                KeepTailUp(direction);
                unique.Add(tailX.ToString() + "," + tailY.ToString());

            }
        }
        System.Console.WriteLine($"========= Ended head at {headX},{headY} and tail at {tailX},{tailY} =========");
    }

    foreach (var item in unique)
    {
        System.Console.WriteLine(item);
    }
    System.Console.WriteLine("Count: " + unique.Count);

}

Part1();