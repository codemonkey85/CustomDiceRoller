namespace CustomDiceRoller.Components;

public partial class DiceConfigComponent
{
    protected override void OnInitialized()
    {
        DiceConfigHelper.DieModels.AddRange(new[]
        {
            new DieModel { NumberOfSides = 6 },
            new DieModel { NumberOfSides = 6 },
            new DieModel { NumberOfSides = 6 },
            new DieModel { NumberOfSides = 6 },
        });
    }
}
