using Microsoft.AspNetCore.Components;

namespace CustomDiceRoller.Components;

public partial class DieComponent
{
    [Parameter]
    public DieModel DieModel { get; set; }
}
