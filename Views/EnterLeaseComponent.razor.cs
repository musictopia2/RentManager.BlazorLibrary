namespace RentManager.BlazorLibrary.Views;
public partial class EnterLeaseComponent
{
    //does not make it easier but harder to understand though.
#pragma warning disable IDE0075 // Simplify conditional expression
    private bool _amountfirst => DataContext!.IsFirstLease ? false : true;
#pragma warning restore IDE0075 // Simplify conditional expression
    [Inject]
    [AllowNull]
    public IEnterLeaseViewModel DataContext { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await DataContext.InitAsync();
    }
    private async Task ProcessAsync()
    {
        await DataContext!.ProcessAsync();
    }
}