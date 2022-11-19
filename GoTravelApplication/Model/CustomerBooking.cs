﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GoTravelApplication.Model
{
    public partial class CustomerBooking
    {
        public CustomerBooking()
        {
            ReceptionistChanges = new HashSet<ReceptionistChange>();
        }

        public int CustomerBookingId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Status { get; set; }
        public int BookingId { get; set; }
        public int CustomerId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<ReceptionistChange> ReceptionistChanges { get; set; }
    }
}
