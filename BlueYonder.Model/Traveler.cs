namespace BlueYonder.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Traveler
    {
        public int TravelerId { get; set; }

        public string TravelerUserIdentity { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobilePhone { get; set; }

        public string HomeAddress { get; set; }

        public string Passport { get; set; }
    }
}
