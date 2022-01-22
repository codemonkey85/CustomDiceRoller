namespace CustomDiceRoller.Components;

public partial class DiceConfigComponent
{
    private int NumberOfDice = 1;
    private int NumberOfSides = 6;

    private static int RollTotal => DiceConfigHelper.DieModels.Sum(d => d.RollResult);

    private void RollAll()
    {
        DiceConfigHelper.DieModels.Clear();
        for (int i = 0; i < NumberOfDice; i++)
        {
            DiceConfigHelper.DieModels.Add(new DieModel { NumberOfSides = NumberOfSides });
        }
        DiceConfigHelper.RollAll();
    }
}
