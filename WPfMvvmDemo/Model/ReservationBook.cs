using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPfMvvmDemo.Exceptions;

namespace WPfMvvmDemo.Model
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>(); 
        }

        public IEnumerable<Reservation> GetReservationsForUser(string userame)
        {
            return _reservations.Where(r => r.UserName == userame);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation item in _reservations)
            {
                if(item.Conflicts(reservation))
                {
                    throw new ReservationConflictException(item, reservation);
                }
            }

            _reservations.Add(reservation);
        }
    }
}
