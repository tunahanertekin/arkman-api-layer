using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *          "AirBookingTimeTable": {
                    "PrebookingDate": "22.01.2020 13:54:50",
                    "PrebookingExpiresAt": "27.01.2020 12:00:00",
                    "BookingDate": "22.01.2020 13:57:14",
                    "CancellationDate": ""
                } 
     */

    public class AirBookingTimeTable
    {
        public String PrebookingDate;
        public String PrebookingExpiresAt;
        public String BookingDate;
        public String CancellationDate;

        public AirBookingTimeTable(string prebookingDate, string prebookingExpiresAt, string bookingDate, string cancellationDate)
        {
            PrebookingDate = prebookingDate;
            PrebookingExpiresAt = prebookingExpiresAt;
            BookingDate = bookingDate;
            CancellationDate = cancellationDate;
        }
    }
}
