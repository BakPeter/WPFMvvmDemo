using WPfMvvmDemo.Model;

namespace WPfMvvmDemo.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID => _reservation.RoomID?.ToString();
        public string UserName => _reservation.UserName.ToString();
        public string StartDate => _reservation.StartTime.ToString("d");
        public string EndDate => _reservation.EndTime.ToString("d");


        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
