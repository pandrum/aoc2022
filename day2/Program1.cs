List<string> lines = System.IO.File.ReadLines(@"input.txt").ToList();

int yourScore = 0;
int opponentScore = 0;

int rock = 1;
int paper = 2;
int scissor = 3;

int draw = 3;
int win = 6;

for (int i = 0; i < lines.Count(); i++)
{
    string opponent = Char.ToString(lines[i][0]);
    string you = Char.ToString(lines[i][2]);

    System.Console.WriteLine(opponent);
    System.Console.WriteLine(you);


    /* ROCKS */
    //rock against rock
    if (opponent.Equals("A") && you.Equals("X"))
    {
        System.Console.WriteLine("rock against your rock - draw");
        yourScore += (draw + rock);
    }
    //rock against paper
    if (opponent.Equals("A") && you.Equals("Y"))
    {
        System.Console.WriteLine("rock against your paper - win");
        yourScore += (win + paper);

    }
    //rock against scissor
    if (opponent.Equals("A") && you.Equals("Z"))
    {
        System.Console.WriteLine("rock against your scissor - lose");
        yourScore += (scissor);
    }


    /* PAPER */
    //paper against rock
    if (opponent.Equals("B") && you.Equals("X"))
    {
        System.Console.WriteLine("paper against your rock - lose");
        yourScore += (rock);
    }
    //paper against paper
    if (opponent.Equals("B") && you.Equals("Y"))
    {
        System.Console.WriteLine("paper against your paper - draw");
        yourScore += (draw + paper);

    }
    //rock against scissor
    if (opponent.Equals("B") && you.Equals("Z"))
    {
        System.Console.WriteLine("paper against your scissor - win");
        yourScore += (win + scissor);
    }

    /* SCISSOR */
    //scissor against rock
    if (opponent.Equals("C") && you.Equals("X"))
    {
        System.Console.WriteLine("scissor against your rock - win");
        yourScore += (win + rock);
    }
    //scissor against paper
    if (opponent.Equals("C") && you.Equals("Y"))
    {
        System.Console.WriteLine("scissor against your paper - lose");
        yourScore += (paper);

    }
    //scissor against scissor
    if (opponent.Equals("C") && you.Equals("Z"))
    {
        System.Console.WriteLine("scissor against your scissor - draw");
        yourScore += (draw + scissor);
    }
}
System.Console.WriteLine(yourScore);