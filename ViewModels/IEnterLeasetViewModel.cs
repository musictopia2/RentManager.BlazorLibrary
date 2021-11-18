namespace RentManager.BlazorLibrary.ViewModels;
public interface IEnterLeasetViewModel
{
    int RentAmount { get; set; }
    bool Visible { get; }
    bool IsFirstLease { get; }
    bool CanStart { get; }
    DateOnly FirstStartDate { get; set; }
    DateOnly? GetNewStartDate { get; }
    Task InitAsync();
    Task ProcessAsync();
}