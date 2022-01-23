namespace CustomDiceRoller;

public static class DiceConfigHelper
{
    private static readonly Random random = new();

    public static Enums.DiceDisplayType DiceDisplayType = Enums.DiceDisplayType.Number;

    public static List<DieModel> DieModels = new();

    public static void RollAll() => DieModels.ForEach(d => d.Roll(random));
}
