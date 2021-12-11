using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPfMvvmDemo.Model;

namespace WPfMvvmDemo.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation { get; private set; }
        public Reservation IncomingReservation { get; private set; }

        public ReservationConflictException(Reservation existingReservation, Reservation incomingReservation)
        {
            SetReservations(existingReservation: existingReservation, incomingReservation: incomingReservation);
        }

        public ReservationConflictException(string message, Reservation existingReservation, Reservation incomingReservation) : base(message)
        {
            SetReservations(existingReservation: existingReservation, incomingReservation: incomingReservation);
        }

        public ReservationConflictException(string message, Exception innerException, Reservation existingReservation, Reservation incomingReservation) : base(message, innerException)
        {
            SetReservations(existingReservation: existingReservation, incomingReservation: incomingReservation);
        }

        private void SetReservations(Reservation existingReservation, Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }
    }
}
