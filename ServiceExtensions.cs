namespace RentManager.BlazorLibrary;
public static class ServiceExtensions
{
    public static IServiceCollection RegisterRentViewModels(this IServiceCollection services)
    {
        services.AddTransient<IViewLeaseViewModel, ViewLeaseViewModel>();
        services.AddTransient<IEnterLeasetViewModel, EnterLeaseViewModel>();
        return services;
    }
}