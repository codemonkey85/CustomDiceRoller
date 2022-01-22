namespace CustomDiceRoller;

public static class DiceConfigHelper
{
    private static Random random = new();

    public static List<DieModel> DieModels = new();

    public static IEnumerable<int> RollAll() => DieModels.Select(d => d.Roll(random));
}
