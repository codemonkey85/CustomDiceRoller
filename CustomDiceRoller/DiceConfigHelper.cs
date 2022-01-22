namespace CustomDiceRoller;

public static class DiceConfigHelper
{
    private static Random random = new();

    public static List<DieModel> DieModels = new();

    public static void RollAll() => DieModels.ForEach(d => d.Roll(random));
}
