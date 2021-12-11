namespace WPfMvvmDemo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Model.Hotel hotel)
        {
            CurrentViewModel = new MakeReservationViewModel(hotel);
            //CurrentViewModel = new ReservationListingViewModel();
        }
    }
}
