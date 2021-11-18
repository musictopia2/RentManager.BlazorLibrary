namespace RentManager.BlazorLibrary.ViewModels;
public interface IViewLeaseViewModel
{
    Task<LeaseModel?> GetCurrentLeaseAsync();
}