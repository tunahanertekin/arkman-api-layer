using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *          "AirBookingStatus": {
                    "IsPrebooking": true,
                    "IsBooking": true,
                    "IsCancelled": false
                } 
     */

    public class AirBookingStatus
    {
        public Boolean IsPrebooking;
        public Boolean IsBooking;
        public Boolean IsCancelled;

        public AirBookingStatus(bool ısPrebooking, bool ısBooking, bool ısCancelled)
        {
            IsPrebooking = ısPrebooking;
            IsBooking = ısBooking;
            IsCancelled = ısCancelled;
        }
    }
}
