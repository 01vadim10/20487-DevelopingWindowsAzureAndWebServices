namespace BlueYonder.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location
    {
        public int LocationId { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string CountryCode { get; set; }

        public string ThumbnailImageFile { get; set; }

        public string TimeZoneId { get; set; }
    }
}
