namespace CustomDiceRoller;

public class DieModel
{
    public int NumberOfSides { get; set; }

    public int Roll(Random random) => random.Next(1, NumberOfSides + 1);
}
