namespace MauiApp1.ViewModels
{
    public class CompositeViewModel
    {
        public CompositeViewModel(FuelAmountViewModel fuelAmountViewModel)
        {
            FuelAmountViewModel = fuelAmountViewModel;
        }

        public FuelAmountViewModel FuelAmountViewModel { get; }
    }
}
