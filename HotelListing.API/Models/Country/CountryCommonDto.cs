﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public abstract  class CountryCommonDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
