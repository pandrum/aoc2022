
List<string> array = System.IO.File.ReadLines(@"input.txt").ToList();

void Part1()
{
    int counter = 0;

    //rows
    for (int row = 1; row < array.Count - 1; row++)
    {
        Console.Write("Row: " + array[row]);
        System.Console.WriteLine();

        //columns
        for (int column = 1; column < 98; column++)
        {
            bool visibleRight = true;
            bool visibleLeft = true;
            bool visibleUp = true;
            bool visibleDown = true;

            // System.Console.WriteLine("Number: " + array[row][column]);

            //right
            for (int right = column + 1; right < array[0].Length; right++)
            {
                // System.Console.WriteLine("\t going right: " + array[row][right]);
                if (array[row][right] >= array[row][column])
                {
                    // System.Console.WriteLine(array[row][right] + " is bigger than " + array[row][column]);
                    visibleRight = false;
                }
            }

            //left
            for (int left = column - 1; left >= 0; left--)
            {
                // System.Console.WriteLine("\t going left: " + array[row][left]);
                if (array[row][left] >= array[row][column])
                {
                    // System.Console.WriteLine(array[row][left] + " is bigger than " + array[row][column]);
                    visibleLeft = false;
                }
            }

            //up
            for (int up = row - 1; up >= 0; up--)
            {
                // System.Console.WriteLine("\t going up: " + array[up][column]);
                if (array[up][column] >= array[row][column])
                {
                    // System.Console.WriteLine(array[up][column] + " is bigger than " + array[row][column]);
                    visibleUp = false;
                }
            }

            //down
            for (int down = row + 1; down < array.Count; down++)
            {
                // System.Console.WriteLine("\t going down: " + array[down][column]);
                if (array[down][column] >= array[row][column])
                {
                    // System.Console.WriteLine(array[down][column] + " is bigger than " + array[row][column]);
                    visibleDown = false;
                }
            }

            if (visibleRight)
            {
                System.Console.WriteLine($"{array[row][column]} is visible from the outside to the right");
            }

            if (visibleLeft)
            {
                System.Console.WriteLine($"{array[row][column]} is visible from the outside to the left");
            }

            if (visibleUp)
            {
                System.Console.WriteLine($"{array[row][column]} is visible from the outside upwards");
            }
            if (visibleDown)
            {
                System.Console.WriteLine($"{array[row][column]} is visible from the outside downwards");
            }

            if (visibleRight || visibleLeft || visibleUp || visibleDown)
            {
                counter++;
            }

            System.Console.WriteLine("--------NEXT NUMBER--------");

        }
        System.Console.WriteLine();
        System.Console.WriteLine("--------NEXT ROW--------");
    }
    System.Console.WriteLine("Hidden trees: " + counter);
    System.Console.WriteLine("Trees around the edge " + (array.Count + array.Count + array[0].Length + array[0].Length - 4));
    System.Console.WriteLine(counter + (array.Count + array.Count + array[0].Length + array[0].Length - 4));
}

void Part2()
{
    var scenicScores = new List<int>();
    int counter = 0;

    //rows
    for (int row = 1; row < array.Count - 1; row++)
    {
        Console.Write("Row: " + array[row]);
        System.Console.WriteLine();

        //columns
        for (int column = 1; column < 98; column++)
        {

            System.Console.WriteLine("Number: " + array[row][column]);

            int rightCounter = 0;
            int leftCounter = 0;
            int upCounter = 0;
            int downCounter = 0;

            //right
            for (int right = column + 1; right < array[0].Length; right++)
            {
                // System.Console.WriteLine("\t going right: " + array[row][right]);
                if (array[row][right] >= array[row][column])
                {
                    // System.Console.WriteLine(array[row][right] + " is bigger than " + array[row][column]);
                    rightCounter++;

                    break;
                }
                else
                {
                    rightCounter++;
                }
            }

            //left
            for (int left = column - 1; left >= 0; left--)
            {
                // System.Console.WriteLine("\t going left: " + array[row][left]);
                if (array[row][left] >= array[row][column])
                {
                    // System.Console.WriteLine(array[row][left] + " is bigger than " + array[row][column])
                    leftCounter++;
                    break;
                }
                else
                {
                    leftCounter++;
                }
            }

            //up
            for (int up = row - 1; up >= 0; up--)
            {
                // System.Console.WriteLine("\t going up: " + array[up][column]);
                if (array[up][column] >= array[row][column])
                {
                    // System.Console.WriteLine(array[up][column] + " is bigger than " + array[row][column]);
                    upCounter++;
                    break;
                }
                else
                {
                    upCounter++;
                }
            }

            //down
            for (int down = row + 1; down < array.Count; down++)
            {
                // System.Console.WriteLine("\t going down: " + array[down][column]);
                if (array[down][column] >= array[row][column])
                {
                    // System.Console.WriteLine(array[down][column] + " is bigger than " + array[row][column]);
                    downCounter++;
                    break;
                }
                else
                {
                    downCounter++;
                }
            }

            System.Console.WriteLine("Scenic score: " + (rightCounter * leftCounter * upCounter * downCounter));
            System.Console.WriteLine("--------NEXT NUMBER--------");
            scenicScores.Add(rightCounter * leftCounter * upCounter * downCounter);

        }
        System.Console.WriteLine();
        System.Console.WriteLine("--------NEXT ROW--------");
    }

    System.Console.WriteLine(scenicScores.Max());
}

Part2();