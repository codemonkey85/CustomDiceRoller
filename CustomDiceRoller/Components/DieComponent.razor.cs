using Microsoft.AspNetCore.Components;

namespace CustomDiceRoller.Components;

public partial class DieComponent
{
    [Parameter]
    public int RollResult { get; set; }
}
