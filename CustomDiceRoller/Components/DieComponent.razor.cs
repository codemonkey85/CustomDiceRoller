namespace CustomDiceRoller.Components;

public partial class DieComponent
{
    [Parameter, EditorRequired]
    public DieModel DieModel { get; set; } = default!;

    private (string BackgroundColor, string TextColor) defaultColor = ("white", "black");

    private readonly IDictionary<int, (string BackgroundColor, string TextColor)> NumberColors = new Dictionary<int, (string BackgroundColor, string TextColor)>
    {
        { 1, ("red", "black") },
        { 2, ("orange", "black") },
        { 3, ("yellow", "black") },
        { 4, ("green", "black") },
        { 5, ("cyan", "black") },
        { 6, ("indigo", "white") },
        { 7, ("violet", "black") },
        { 8, ("purple", "white") },
        { 9, ("grey", "black") },
        { 10, ("#e5e5e5", "black") },
    };

    private (string BackgroundColor, string TextColor) CssColor => DiceConfigHelper.DiceDisplayType switch
    {
        Enums.DiceDisplayType.Number => defaultColor,
        Enums.DiceDisplayType.Color => NumberColors.TryGetValue(DieModel.RollResult, out var result) ? result : defaultColor,
        _ => defaultColor,
    };
}
