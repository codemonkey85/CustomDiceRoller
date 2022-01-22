namespace CustomDiceRoller;

public class DieModel
{
    public int NumberOfSides { get; set; }

    public int RollResult { get; private set; }

    public int Roll(Random random) => RollResult = random.Next(1, NumberOfSides + 1);
}
